using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGIIService.Infrastructure.Persistence
{
    public static class DapperDbConnectionFactory
    {
        private static string connectionString = "Data Source=.\\SQL2017;Initial Catalog=DGIISeviceDatabase;Integrated Security=True"; // Configura tu cadena de conexión aquí

        public static IDbConnection GetConnection()
        {
            var connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
