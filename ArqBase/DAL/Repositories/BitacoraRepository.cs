using ArqBase.DAL.Helper;
using Servicios.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.DAL.Repositories
{
    public class BitacoraRepository
    {
        private string connectionString = SqlHelper.GetConnectionString();

        public void RegistrarEnBitacora(Bitacora bitacora)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Bitacora (FechaHora, Email, Accion, Detalle) " +
                               "VALUES (@FechaHora, @Email, @Accion, @Detalle)";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@FechaHora", bitacora.FechaHora);
                command.Parameters.AddWithValue("@Email", bitacora.Email);
                command.Parameters.AddWithValue("@Accion", bitacora.Accion);
                command.Parameters.AddWithValue("@Detalle", bitacora.Detalle ?? (object)DBNull.Value);

                conn.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}