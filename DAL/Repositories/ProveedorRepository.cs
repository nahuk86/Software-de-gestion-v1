using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ProveedorRepository
    {
        private readonly string _connectionString;

        public ProveedorRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Proveedor> ObtenerProveedores()
        {
            var proveedores = new List<Proveedor>();

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT Id, Nombre FROM Proveedor", conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        proveedores.Add(new Proveedor
                        {
                            Id = (int)reader["Id"],
                            Nombre = reader["Nombre"].ToString()
                        });
                    }
                }
            }
            catch (SqlException ex)
            {
                // Manejar la excepción, registrar el error, etc.
                throw new Exception("Error al obtener proveedores", ex);
            }

            return proveedores;
        }
    }
}
