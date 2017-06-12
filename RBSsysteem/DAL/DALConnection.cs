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
        public SqlConnection MaakConnectieDB(string naam)
        {
            string connString =  ConfigurationManager.ConnectionStrings[naam].ConnectionString;
            SqlConnection connection = new SqlConnection(connString);

            return connection;
        }
    }
}
