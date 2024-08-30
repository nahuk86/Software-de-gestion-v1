using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ClienteRepository
    {
        private readonly string _connectionString;

        public ClienteRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AgregarCliente(ClienteDTO cliente)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Clientes (Nombre, Apellido, DNI, Telefono, Direccion, Email, FechaNacimiento) " +
                               "VALUES (@Nombre, @Apellido, @DNI, @Telefono, @Direccion, @Email, @FechaNacimiento)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                command.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                command.Parameters.AddWithValue("@DNI", cliente.DNI);
                command.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                command.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                command.Parameters.AddWithValue("@Email", cliente.Email);
                command.Parameters.AddWithValue("@FechaNacimiento", cliente.FechaNacimiento);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}