using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class TafelDAO
    {
        private SqlConnection DBConnectie;

        public TafelDAO()
        {

        }

        public List<Tafel> GetTafels()
        {
            List<Tafel> tafels = new List<Tafel>();

            DALConnection connectie = new DALConnection();
            DBConnectie = connectie.MaakConnectieDB("Reader");
            DBConnectie.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Tafel", DBConnectie);

            SqlDataReader reader = command.ExecuteReader();
            
            // vul tafels list met resultaten
            while (reader.Read())
            {
                Tafel tafel = new Tafel(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3));
                tafels.Add(tafel);
            }

            reader.Close();
            DBConnectie.Close();

            return tafels;
        }
    }
}
