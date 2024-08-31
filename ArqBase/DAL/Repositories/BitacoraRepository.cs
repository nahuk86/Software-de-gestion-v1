using ArqBase.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArqBase.DAL.Repositories
{
    public class BitacoraRepository
    {
        private readonly string _connectionString;

        public BitacoraRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void RegistrarEnBitacora(Bitacora bitacora)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Bitacora (FechaHora, Usuario, Accion, Detalle) " +
                               "VALUES (@FechaHora, @Usuario, @Accion, @Detalle)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FechaHora", bitacora.FechaHora);
                command.Parameters.AddWithValue("@Usuario", bitacora.Usuario);
                command.Parameters.AddWithValue("@Accion", bitacora.Accion);
                command.Parameters.AddWithValue("@Detalle", bitacora.Detalle ?? (object)DBNull.Value);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}