using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArqBase.DAL.Helper;
using ArqBase.Domain;


namespace ArqBase.DAL.Repositories
{
    public class UsuariosRepository
    {
        //PermisosRepository repoPermisos;
        public UsuariosRepository()
        {
            // repoPermisos = new PermisosRepository();
        }

        // Método que obtiene todos los usuarios de la base de datos
        public List<Usuario> GetAll()
        {
            var sql = @"SELECT * FROM usuarios;";
            var lista = new List<Usuario>();

            using (var reader = SqlHelper.ExecuteReader(sql))
            {
                while (reader.Read())
                {
                    Usuario usuario = new Usuario
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id_usuario")),
                        Email = reader.GetString(reader.GetOrdinal("email"))
                    };
                    lista.Add(usuario);
                }
            }
            return lista;
        }

        // Método que guarda los permisos de un usuario
        public void GuardarPermisos(Usuario usuario)
        {
            try
            {
                // Primero eliminar los permisos antiguos
                var deleteSql = @"DELETE FROM usuarios_permisos WHERE id_usuario = @id;";
                SqlHelper.ExecuteNonQuery(deleteSql, new SqlParameter("@id", usuario.Id));

                // Insertar los nuevos permisos
                foreach (var permiso in usuario.Permisos)
                {
                    var insertSql = @"INSERT INTO usuarios_permisos (id_usuario, id_permiso) VALUES (@id_usuario, @id_permiso);";
                    SqlHelper.ExecuteNonQuery(insertSql,
                        new SqlParameter("@id_usuario", usuario.Id),
                        new SqlParameter("@id_permiso", permiso.Id));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar permisos", ex);
            }
        }
    }
}
