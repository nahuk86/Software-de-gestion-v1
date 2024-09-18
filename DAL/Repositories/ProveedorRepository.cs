using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Helpers;

namespace DAL.Repositories
{
    public class ProveedorRepository
    {
        private string connectionString = ConfigHelper.GetConnectionString();

        public ProveedorRepository()
        {
        }

        public void AgregarProveedor(Proveedor proveedor)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Proveedor (Nombre) VALUES (@Nombre)", conn);
                    cmd.Parameters.AddWithValue("@Nombre", proveedor.Nombre);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al agregar el proveedor", ex);
            }
        }


        public List<Proveedor> ObtenerProveedores()
        {
            var proveedores = new List<Proveedor>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
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
