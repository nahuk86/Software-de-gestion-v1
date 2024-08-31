using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using ArqBase;

namespace DAL.Repositories
{
    public class UsuarioRepository
    {
        private readonly string _connectionString;

        public UsuarioRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void CrearUsuario(Usuario usuario)
        {
            string hashedPassword = PasswordHasher.HashPassword(usuario.Password);

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Usuarios (Username, Password, Email, Nombre, Apellido, DNI, Rol) " +
                               "VALUES (@Username, @Password, @Email, @Nombre, @Apellido, @DNI, @Rol)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", usuario.Username);
                command.Parameters.AddWithValue("@Password", hashedPassword);
                command.Parameters.AddWithValue("@Email", usuario.Email);
                command.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                command.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                command.Parameters.AddWithValue("@DNI", usuario.DNI);
                command.Parameters.AddWithValue("@Rol", usuario.Rol);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public Usuario ObtenerUsuarioPorNombre(string username)
        {
            Usuario usuario = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT Id, Username, Password, Email, Nombre, Apellido, DNI, Rol " +
                               "FROM Usuarios WHERE Username = @Username";
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
                        Password = (string)reader["Password"],
                        Email = (string)reader["Email"],
                        Nombre = (string)reader["Nombre"],
                        Apellido = (string)reader["Apellido"],
                        DNI = (string)reader["DNI"],
                        Rol = (string)reader["Rol"]
                    };
                }
            }

            return usuario;
        }

        public Usuario ObtenerUsuarioPorEmail(string email)
        {
            Usuario usuario = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT Id, Username, Password, Email, Nombre, Apellido, DNI, Rol " +
                               "FROM Usuarios WHERE Email = @Email";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    usuario = new Usuario
                    {
                        Id = (int)reader["Id"],
                        Username = (string)reader["Username"],
                        Password = (string)reader["Password"],
                        Email = (string)reader["Email"],
                        Nombre = (string)reader["Nombre"],
                        Apellido = (string)reader["Apellido"],
                        DNI = (string)reader["DNI"],
                        Rol = (string)reader["Rol"]
                    };
                }
            }

            return usuario;
        }

        public Usuario ObtenerUsuarioPorNombreYPassword(string username, string password)
        {
            Usuario usuario = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT Id, Username, Password, Email, Nombre, Apellido, DNI, Rol " +
                               "FROM Usuarios WHERE Username = @Username";
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
                            Password = storedHash,  // Se recomienda no guardar esto en memoria
                            Email = (string)reader["Email"],
                            Nombre = (string)reader["Nombre"],
                            Apellido = (string)reader["Apellido"],
                            DNI = (string)reader["DNI"],
                            Rol = (string)reader["Rol"]
                        };
                    }
                }
            }

            return usuario;
        }

        public string ObtenerRolPorUsuarioId(int userId)
        {
            string rol = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT Rol FROM Usuarios WHERE Id = @UsuarioId";
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
        }
    }
}