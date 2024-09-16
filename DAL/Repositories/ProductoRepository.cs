using DAL.Helpers;
using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ProductoRepository
    {
        private string connectionString = ConfigHelper.GetConnectionString();

        public void AgregarProducto(Producto producto)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Producto (Nombre, IdCategoria, IdProveedor, IdMarca, ValorUnitario) VALUES (@Nombre, @IdCategoria, @IdProveedor, @IdMarca, @ValorUnitario)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@IdCategoria", producto.IdCategoria);
                cmd.Parameters.AddWithValue("@IdProveedor", producto.IdProveedor);
                cmd.Parameters.AddWithValue("@IdMarca", producto.IdMarca);
                cmd.Parameters.AddWithValue("@ValorUnitario", producto.ValorUnitario);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Categoria> ObtenerCategorias()
        {
            List<Categoria> categorias = new List<Categoria>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Nombre FROM Categoria";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    categorias.Add(new Categoria
                    {
                        Id = (int)reader["Id"],
                        Nombre = (string)reader["Nombre"]
                    });
                }
            }
            return categorias;
        }

        public List<Proveedor> ObtenerProveedores()
        {
            List<Proveedor> proveedores = new List<Proveedor>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Nombre FROM Proveedor";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    proveedores.Add(new Proveedor
                    {
                        Id = (int)reader["Id"],
                        Nombre = (string)reader["Nombre"]
                    });
                }
            }
            return proveedores;
        }

        public List<Marca> ObtenerMarcas()
        {
            List<Marca> marcas = new List<Marca>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Nombre FROM Marca";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    marcas.Add(new Marca
                    {
                        Id = (int)reader["Id"],
                        Nombre = (string)reader["Nombre"]
                    });
                }
            }
            return marcas;
        }
    }
}