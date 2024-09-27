using ArqBase.Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArqBase.DAL.Helper;


namespace ArqBase.DAL.Repositories
{
    public class PermisosRepository
    {
        private string connectionString = SqlHelper.GetConnectionString();

        public Array GetAllPermission()
        {
            return Enum.GetValues(typeof(TipoPermiso));
        }

        public Componente GuardarComponente(Componente p, bool esFamilia)
        {
            try
            {
                var sql = @"INSERT INTO permiso (nombre, permiso) VALUES (@nombre, @permiso); 
                            SELECT ID AS LastID FROM permiso WHERE ID = @@Identity;";

                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@nombre", p.Nombre),
                    new SqlParameter("@permiso", esFamilia ? (object)DBNull.Value : p.Permiso.ToString())
                };

                var id = SqlHelper.ExecuteScalar(sql, parameters.ToArray());
                p.Id = (int)id;
                return p;
            }
            catch (Exception ex)
            {
                throw new Exception("Error guardando componente", ex);
            }
        }

        public void GuardarFamilia(Familia c)
        {
            try
            {
                var deleteSql = "DELETE FROM permiso_permiso WHERE id_permiso_padre=@id;";
                SqlHelper.ExecuteNonQuery(deleteSql, new SqlParameter("@id", c.Id));

                foreach (var item in c.Hijos)
                {
                    var insertSql = @"INSERT INTO permiso_permiso (id_permiso_padre, id_permiso_hijo) 
                                      VALUES (@id_permiso_padre, @id_permiso_hijo);";
                    SqlHelper.ExecuteNonQuery(insertSql,
                        new SqlParameter("@id_permiso_padre", c.Id),
                        new SqlParameter("@id_permiso_hijo", item.Id));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error guardando familia", ex);
            }
        }

        public IList<Patente> GetAllPatentes()
        {
            var lista = new List<Patente>();
            var sql = @"SELECT * FROM permiso WHERE permiso IS NOT NULL;";

            using (var reader = SqlHelper.ExecuteReader(sql))
            {
                while (reader.Read())
                {
                    var patente = new Patente
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id")),
                        Nombre = reader.GetString(reader.GetOrdinal("nombre")),
                        Permiso = (TipoPermiso)Enum.Parse(typeof(TipoPermiso), reader.GetString(reader.GetOrdinal("permiso")))
                    };
                    lista.Add(patente);
                }
            }
            return lista;
        }

        public IList<Familia> GetAllFamilias()
        {
            var lista = new List<Familia>();
            var sql = @"SELECT * FROM permiso WHERE permiso IS NULL;";

            using (var reader = SqlHelper.ExecuteReader(sql))
            {
                while (reader.Read())
                {
                    var familia = new Familia
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id")),
                        Nombre = reader.GetString(reader.GetOrdinal("nombre"))
                    };
                    lista.Add(familia);
                }
            }
            return lista;
        }

        public IList<Componente> GetAll(string familia)
        {
            var where = "IS NULL";
            if (!string.IsNullOrEmpty(familia))
            {
                where = familia;
            }

            var lista = new List<Componente>();
            var sql = $@"
                        WITH recursivo AS (
                            SELECT sp2.id_permiso_padre, sp2.id_permiso_hijo  
                            FROM permiso_permiso SP2
                            WHERE sp2.id_permiso_padre {where}
                            UNION ALL 
                            SELECT sp.id_permiso_padre, sp.id_permiso_hijo 
                            FROM permiso_permiso sp 
                            INNER JOIN recursivo r ON r.id_permiso_hijo = sp.id_permiso_padre
                        )
                        SELECT r.id_permiso_padre, r.id_permiso_hijo, p.id, p.nombre, p.permiso
                        FROM recursivo r 
                        INNER JOIN permiso p ON r.id_permiso_hijo = p.id;
                        ";

            using (var reader = SqlHelper.ExecuteReader(sql))
            {
                while (reader.Read())
                {
                    int idPadre = reader["id_permiso_padre"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("id_permiso_padre")) : 0;
                    var id = reader.GetInt32(reader.GetOrdinal("id"));
                    var nombre = reader.GetString(reader.GetOrdinal("nombre"));
                    var permiso = reader["permiso"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("permiso")) : null;

                    Componente c;

                    if (string.IsNullOrEmpty(permiso))
                    {
                        c = new Familia();
                    }
                    else
                    {
                        c = new Patente
                        {
                            Permiso = (TipoPermiso)Enum.Parse(typeof(TipoPermiso), permiso)
                        };
                    }

                    c.Id = id;
                    c.Nombre = nombre;

                    var padre = GetComponent(idPadre, lista);
                    if (padre == null)
                    {
                        lista.Add(c);
                    }
                    else
                    {
                        padre.AgregarHijo(c);
                    }
                }
            }
            return lista;
        }

        private Componente GetComponent(int id, IList<Componente> lista)
        {
            Componente component = lista?.FirstOrDefault(i => i.Id == id);
            if (component == null && lista != null)
            {
                foreach (var c in lista)
                {
                    var l = GetComponent(id, c.Hijos);
                    if (l != null && l.Id == id) return l;
                    else if (l != null) return GetComponent(id, l.Hijos);
                }
            }
            return component;
        }

        //public void FillUserComponents(Usuario u)
        //{
        //    var sql = @"SELECT p.* 
        //                FROM usuarios_permisos up 
        //                INNER JOIN permiso p ON up.id_permiso = p.id 
        //                WHERE id_usuario = @id;";

        //    using (var reader = SqlHelper.ExecuteReader(sql, new SqlParameter("@id", u.Id)))
        //    {
        //        u.Permisos.Clear();

        //        while (reader.Read())
        //        {
        //            var id = reader.GetInt32(reader.GetOrdinal("id"));
        //            var nombre = reader.GetString(reader.GetOrdinal("nombre"));
        //            var permiso = reader.IsDBNull(reader.GetOrdinal("permiso")) ? null : reader.GetString(reader.GetOrdinal("permiso"));

        //            Componente c;

        //            if (string.IsNullOrEmpty(permiso))
        //            {
        //                // Si 'permiso' es nulo o vacío, crea una instancia de Familia
        //                c = new Familia();
        //            }
        //            else
        //            {
        //                // Si 'permiso' no es nulo o vacío, crea una instancia de Patente y asigna el Permiso
        //                c = new Patente
        //                {
        //                    Permiso = (TipoPermiso)Enum.Parse(typeof(TipoPermiso), permiso)
        //                };
        //            }

        //            c.Id = id;
        //            c.Nombre = nombre;
        //            u.Permisos.Add(c);
        //        }
        //    }
        //}

        public void FillUserComponents(Usuario u)
        {

            var cnn = new SqlConnection(SqlHelper.GetConnectionString());
            cnn.Open();

            var cmd2 = new SqlCommand();
            cmd2.Connection = cnn;
            cmd2.CommandText = $@"select p.* from usuarios_permisos up inner join permiso p on up.id_permiso=p.id where id_usuario=@id;";
            cmd2.Parameters.AddWithValue("id", u.Id);

            var reader = cmd2.ExecuteReader();
            u.Permisos.Clear();
            while (reader.Read())
            {

                var idp = reader.GetInt32(reader.GetOrdinal("id"));
                var nombrep = reader.GetString(reader.GetOrdinal("nombre"));

                var permisop = String.Empty;
                if (reader["permiso"] != DBNull.Value)
                    permisop = reader.GetString(reader.GetOrdinal("permiso"));

                Componente c1;
                if (!String.IsNullOrEmpty(permisop))
                {
                    c1 = new Patente();
                    c1.Id = idp;
                    c1.Nombre = nombrep;
                    c1.Permiso = (TipoPermiso)Enum.Parse(typeof(TipoPermiso), permisop);
                    u.Permisos.Add(c1);
                }
                else
                {
                    c1 = new Familia();
                    c1.Id = idp;
                    c1.Nombre = nombrep;

                    var f = GetAll("=" + idp);

                    foreach (var familia in f)
                    {
                        c1.AgregarHijo(familia);
                    }
                    u.Permisos.Add(c1);
                }



            }
            reader.Close();

        }

        public void FillFamilyComponents(Familia familia)
        {
            familia.VaciarHijos();
            foreach (var item in GetAll("=" + familia.Id))
            {
                familia.AgregarHijo(item);
            }
        }
    }
}