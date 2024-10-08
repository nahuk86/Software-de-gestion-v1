﻿using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Helpers;

namespace DAL.Repositories
{
    public class MarcaRepository
    {
        private string connectionString = ConfigHelper.GetConnectionString();

        public MarcaRepository()
        {

        }

        public void AgregarMarca(Marca marca)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Marca (Nombre) VALUES (@Nombre)", conn);
                    cmd.Parameters.AddWithValue("@Nombre", marca.Nombre);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al agregar la marca", ex);
            }
        }

        public List<Marca> ObtenerMarcas()
        {
            var marcas = new List<Marca>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
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
