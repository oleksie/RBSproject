using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class DALConnection
    {
        public SqlConnection openConnectieDB(string naam)
        {
            string connString = ConfigurationManager.ConnectionStrings[naam].ConnectionString;
            SqlConnection connection = new SqlConnection(connString);

            connection.Open();
            return connection;
        }

        private void sluitConnectieDB(SqlConnection connection)
        {
            connection.Close();
        }
    }
}
