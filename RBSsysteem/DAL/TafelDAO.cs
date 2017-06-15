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

            // controleer of er ten minste één record is terug gestuurd
            if (!reader.Read())
                return null;

            // vul tafels list met resultaten
            while (reader.Read())
            {
                Tafel tafel = new Tafel(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2));
                tafels.Add(tafel);
            }

            reader.Close();
            DBConnectie.Close();

            return tafels;
        }
    }
}
