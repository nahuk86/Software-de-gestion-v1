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
    public class CategoriaRepository
    {
        private string connectionString = ConfigHelper.GetConnectionString();

        public CategoriaRepository()
        {
        }
        public void AgregarCategoria(Categoria categoria)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Categoria (Nombre) VALUES (@Nombre)", conn);
                    cmd.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al agregar la categoria", ex);
            }
        }

        public List<Categoria> ObtenerCategorias()
        {
            var categorias = new List<Categoria>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT Id, Nombre FROM Categoria", conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    categorias.Add(new Categoria
                    {
                        Id = (int)reader["Id"],
                        Nombre = reader["Nombre"].ToString()
                    });
                }
            }

            return categorias;
        }
    }

    // Repositorios similares para ProveedorRepository y MarcaRepository
}

