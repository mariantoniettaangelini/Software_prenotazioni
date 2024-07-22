using Microsoft.Data.SqlClient;
using System.Data.Common;

namespace Software_prenotazioni.Services
{
    public class SqlServerServiceBase : ServiceBase
    {
        private readonly IConfiguration _configuration;
        public SqlServerServiceBase(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override DbConnection CreateConnection()
        {
            return new SqlConnection(_configuration.GetConnectionString("Db"));
        }

        protected override DbCommand GetCommand(string commandText, DbConnection connection)
        {
            return new SqlCommand(commandText, connection as SqlConnection);
        }
    }
}
