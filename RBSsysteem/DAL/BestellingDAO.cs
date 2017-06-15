using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System;
using Model;
using System.Configuration;

namespace DAL
{
    public class BestellingDAO
    {
        public List<Bestelling> GetBestelling()
        {
            string sqlquery = "SELECT aantal, Bestelling.tafel_id, MenuItem.naam, MenuItem.prijs FROM Bestelling JOIN BestelItem ON BestelItem.bestelling_id = Bestelling.bestelling_id JOIN MenuItem ON BestelItem.menuitem_id = MenuItem.menuitem_id";

            string connString = ConfigurationManager.ConnectionStrings["Reader"].ConnectionString;
            SqlConnection connect = new SqlConnection(connString);
            connect.Open();

            SqlCommand sqlCmnd = new SqlCommand(sqlquery, connect);


            sqlCmnd.Prepare();

            SqlDataReader reader = sqlCmnd.ExecuteReader();

            List<Bestelling> lijstbestellingen = new List<Bestelling>();
            if (!reader.Read())
                return null;
            while (reader.Read())
            {
                int aantal = reader.GetInt32(0);
                int tafelId = reader.GetInt32(1);
                string naam = reader.GetString(2);
                float prijs = reader.GetFloat(3);

                Bestelling bestelling = new Bestelling(aantal, tafelId, naam, prijs);

                lijstbestellingen.Add(bestelling);
            }

            connect.Close();
            reader.Close();
            return lijstbestellingen;
        }
    }
}


 