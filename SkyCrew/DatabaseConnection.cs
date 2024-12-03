using System;
using System.Configuration;
using System.Data.SqlClient;

namespace SkyCrew
{
    public static class DatabaseConnection
    {
        public static SqlConnection ConnectToDatabase()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["LNBAirlines"].ConnectionString;
            return new SqlConnection(connectionString);
        }
    }
}
