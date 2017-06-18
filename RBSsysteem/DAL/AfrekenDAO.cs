using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System;
using Model;
using System.Configuration;
using System.Data;

namespace DAL
{
    public class AfrekenDAO
    {
        private SqlConnection DBConnectie;

        public AfrekenDAO()
        {

        }

        public List<Afreken> GetAfreken()
        {
            List<Afreken> lijstAfreken = new List<Afreken>();
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
                string naam = reader.GetString(1);
                double prijs = reader.GetDouble(2);

                Afreken bestelling = new Afreken(aantal, naam, prijs);

                lijstAfreken.Add(bestelling);
            }

            DBConnectie.Close();
            reader.Close();
            return lijstAfreken;
        }


    }
}