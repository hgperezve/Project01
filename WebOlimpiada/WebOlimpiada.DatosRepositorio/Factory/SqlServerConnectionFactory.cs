using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOlimpiada.DatosRepositorio.Context;

namespace WebOlimpiada.DatosRepositorio.Factory
{
    public class SqlServerConnectionFactory : IConnectionFactory
    {
        private static readonly Lazy<SqlServerConnectionFactory> lazy = new Lazy<SqlServerConnectionFactory>(() => new SqlServerConnectionFactory());

        private readonly DbProviderFactory _provider;
        private readonly string _connectionString;
        private readonly string _name;

        private AdoNetContext _context;

        private SqlServerConnectionFactory()
        {
            //if (connectionName == null) throw new ArgumentNullException("connectionName");

            string connectionName = "OlimpiadaDB";

            var conStr = ConfigurationManager.ConnectionStrings[connectionName];
            if (conStr == null)
                throw new ConfigurationErrorsException(string.Format("Failed to find connection string named '{0}' in app/web.config.", connectionName));

            _name = conStr.ProviderName;
            _provider = DbProviderFactories.GetFactory(conStr.ProviderName);
            _connectionString = conStr.ConnectionString;
            //_name = "System.Data.SqlClient";
            //_provider = DbProviderFactories.GetFactory("System.Data.SqlClient");
            //_connectionString = "";

            // during start of the current session
            _context = new AdoNetContext(this);
        }

        public static SqlServerConnectionFactory Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        internal AdoNetContext DatabaseContext
        {
            get
            {
                return _context;
            }
        }

        public IDbConnection Create()
        {
            var connection = _provider.CreateConnection();
            if (connection == null)
                throw new ConfigurationErrorsException(string.Format("Failed to create a connection using the connection string named '{0}' in app/web.config.", _name));

            connection.ConnectionString = _connectionString;
            connection.Open();
            return connection;
        }
    }
}
