using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArqBase.DAL.Helper;
using ArqBase.Domain;
using Servicios.BLL;


namespace ArqBase.DAL.Repositories
{
    public class UsuariosRepository
    {
        //PermisosRepository repoPermisos;

        private string connectionString = SqlHelper.GetConnectionString();

        public UsuariosRepository()
        {
            // repoPermisos = new PermisosRepository();
        }

        // Método que obtiene todos los usuarios de la base de datos

        public void CrearUsuario(Usuario usuario)
        {
            string hashedPassword = PasswordHasher.HashPassword(usuario.Password);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Usuarios (email, password, nombre, apellido, dni) " +
                               "VALUES (@Email, @Password, @Nombre, @Apellido, @DNI)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@email", usuario.Email);
                cmd.Parameters.AddWithValue("@password", hashedPassword);
                cmd.Parameters.AddWithValue("@nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@apellido", usuario.Apellido);
                cmd.Parameters.AddWithValue("@dni", usuario.DNI);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }


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
