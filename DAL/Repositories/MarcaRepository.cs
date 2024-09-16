using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class MarcaRepository
    {
        private readonly string _connectionString;

        public MarcaRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Marca> ObtenerMarcas()
        {
            var marcas = new List<Marca>();

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT Id, Nombre FROM Marca", conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        marcas.Add(new Marca
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
                throw new Exception("Error al obtener marcas", ex);
            }

            return marcas;
        }
    }
}
