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
        private SqlConnection DBConnectie;
        
        public List<Bestelling> GetBestelling()
        {
            List<Bestelling> lijstbestellingen = new List<Bestelling>();
            string sqlquery = "SELECT aantal, Bestelling.tafel_id, MenuItem.naam, MenuItem.prijs FROM Bestelling JOIN BestelItem ON BestelItem.bestelling_id = Bestelling.bestelling_id JOIN MenuItem ON BestelItem.menuitem_id = MenuItem.menuitem_id";

            DALConnection connectie = new DALConnection();
            DBConnectie = connectie.MaakConnectieDB("Reader");
            SqlCommand command = new SqlCommand(sqlquery, DBConnectie);
            command.Prepare();
            DBConnectie.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int aantal = reader.GetInt32(0);
                int tafelId = reader.GetInt32(1);
                string naam = reader.GetString(2);
                double prijs = reader.GetDouble(3);

                Bestelling bestelling = new Bestelling(aantal, tafelId, naam, prijs);

                lijstbestellingen.Add(bestelling);
            }

            DBConnectie.Close();
            reader.Close();
            return lijstbestellingen;
        }
    }
}


 