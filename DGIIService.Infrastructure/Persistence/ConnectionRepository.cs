using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGIIService.Infrastructure.Persistence
{
    public class ConnectionRepository
    {
        public readonly IDbConnection _dbConnection;

        public ConnectionRepository()
        {
            //esto permite cambiar el origen de datos en caso de
            //ser necesario sin modificar toda la aplicación pieza por pieza
            _dbConnection = DapperDbConnectionFactory.GetConnection();
        }
    }
}
