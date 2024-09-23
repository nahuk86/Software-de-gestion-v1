using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ArqBase.DAL.Helper
{
    public static class SqlHelper
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ServicesConnection"].ConnectionString;
        }
        public static int ExecuteNonQuery(string commandText, params SqlParameter[] parameters)
        {
            using (var cnn = new SqlConnection(GetConnectionString()))
            {
                cnn.Open();
                using (var cmd = new SqlCommand(commandText, cnn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static object ExecuteScalar(string commandText, params SqlParameter[] parameters)
        {
            using (var cnn = new SqlConnection(GetConnectionString()))
            {
                cnn.Open();
                using (var cmd = new SqlCommand(commandText, cnn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    return cmd.ExecuteScalar();
                }
            }
        }

        public static SqlDataReader ExecuteReader(string commandText, params SqlParameter[] parameters)
        {
            var cnn = new SqlConnection(GetConnectionString());
            cnn.Open();
            using (var cmd = new SqlCommand(commandText, cnn))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
        }
    }
}