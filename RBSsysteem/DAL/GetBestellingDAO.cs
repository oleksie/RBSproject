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
    public class GetBestellingDAO
    {


        public static List<Bestelling> Getbestelling()
        {

            string sqlquery = "SELECT aantal,Bestelling.tafel_id,MenuItem.naam, MenuItem.prijs FROM Bestelling join BestelItem ON BestelItem.bestelling_id = Bestelling.bestelling_id join MenuItem ON BestelItem.menuitem_id = MenuItem.menuitem_id";

            string connString = ConfigurationManager.ConnectionStrings["reader"].ConnectionString;
            SqlConnection connect = new SqlConnection(connString);
            connect.Open();

            SqlCommand sqlCmnd = new SqlCommand(sqlquery, connect);


            sqlCmnd.Prepare();

            SqlDataReader reader = sqlCmnd.ExecuteReader();

            List<Bestelling> lijstbestellingen = new List<Bestelling>();

            while (reader.Read())
            {
                int aantal = reader.GetInt32(0);
                int tafel_id = reader.GetInt32(1);
                string naam = reader.GetString(2);
                int prijs = reader.GetInt32(3);

                Model.Bestelling bestelling = new Bestelling(aantal, tafel_id, naam, prijs);

                lijstbestellingen.Add(bestelling);
            }
            
            connect.Close();
            reader.Close();
            return lijstbestellingen;
        }
    }
}


