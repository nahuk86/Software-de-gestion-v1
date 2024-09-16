using DAL.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ProductoDAL
    {
        private string connectionString = ConfigHelper.GetConnectionString();

        public List<string> GetCategorias()
        {
            List<string> categorias = new List<string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Nombre FROM Categoria";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    categorias.Add(reader["Nombre"].ToString());
                }
            }
            return categorias;
        }

        public List<string> GetProveedores()
        {
            List<string> proveedores = new List<string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Nombre FROM Proveedor";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    proveedores.Add(reader["Nombre"].ToString());
                }
            }
            return proveedores;
        }

        public List<string> GetMarcas()
        {
            List<string> marcas = new List<string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Nombre FROM Marca";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    marcas.Add(reader["Nombre"].ToString());
                }
            }
            return marcas;
        }
    }
}