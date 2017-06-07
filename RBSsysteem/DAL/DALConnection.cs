using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALConnection
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
