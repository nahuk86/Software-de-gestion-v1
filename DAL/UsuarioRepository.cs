using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using ArqBase;

namespace DAL
{
    public class UsuarioRepository
    {
        private readonly string _connectionString;

        public UsuarioRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void CrearUsuario(string username, string password)
        {
            string hashedPassword = PasswordHasher.HashPassword(password);
            // Inserta el usuario en la base de datos con la contraseña hasheada
            // Ejemplo de SQL:
            // INSERT INTO Usuarios (Username, Password) VALUES (@Username, @Password)
        }

        public Usuario ObtenerUsuarioPorNombre(string username)
        {
            Usuario usuario = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT Id, Username, Password FROM Usuarios WHERE Username = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    usuario = new Usuario
                    {
                        Id = (int)reader["Id"],
                        Username = (string)reader["Username"],
                        Password = (string)reader["Password"]
                    };
                }
            } // Retorna el usuario encontrado o null si no existe

            return usuario;
        } // Método para obtener un usuario por nombre.

        public Usuario ObtenerUsuarioPorNombreYPassword(string username, string password)
        {
            Usuario usuario = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT Id, Username, Password FROM Usuarios WHERE Username = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string storedHash = reader["Password"].ToString();
                    if (PasswordHasher.VerifyPassword(password, storedHash))
                    {
                        usuario = new Usuario
                        {
                            Id = (int)reader["Id"],
                            Username = (string)reader["Username"],
                            Password = storedHash  // Se recomienda no guardar esto en memoria
                        };
                    }
                }
            }

            return usuario;
        } // Método para obtener un usuario por nombre y contraseña

        public string ObtenerRolPorUsuarioId(int userId)
        {
            string rol = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT Rol FROM RolesUsuarios WHERE UsuarioId = @UsuarioId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UsuarioId", userId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    rol = (string)reader["Rol"];
                }
            }

            return rol;
        } // Método para obtener el rol de un usuario por su Id
    }
}