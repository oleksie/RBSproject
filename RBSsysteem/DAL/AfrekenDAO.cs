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
        /*private SqlConnection DBConnectie;

        public AfrekenDAO()
        {

        }

        public static List<Afreken> GetAfreken()
        {
            List<Afreken> lijstAfreken = new List<Afreken>();
            string sqlquery = "SELECT aantal, MenuItem.naam, MenuItem.prijs FROM Bestelling JOIN BestelItem ON BestelItem.bestelling_id = Bestelling.bestelling_id JOIN MenuItem ON BestelItem.menuitem_id = MenuItem.menuitem_id";
            SqlConnection DBConnectie = new SqlConnection();
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
               // int bestelling_id = reader.GetInt32(3);

                Afreken afreken = new Afreken(aantal, naam, prijs);

                lijstAfreken.Add(afreken);
            }

            DBConnectie.Close();
            reader.Close();
            return lijstAfreken;
        }
        // public static List<Afreken> SetMethodeContant()
        //{
        //    List<Afreken> lijstAfreken = new List<Afreken>();
        //    string sqlquery = "UPDATE Bestelling SET betaalwijze = 'Contant' WHERE bestelling_id = 1029 SELECT bestelitem.bestelling_id";
        //    SqlConnection DBConnectie = new SqlConnection();
        //     DALConnection connectie = new DALConnection();
        //    DBConnectie = connectie.MaakConnectieDB("Reader");
        //    SqlCommand command = new SqlCommand(sqlquery, DBConnectie);
        //    command.Prepare();
        //    DBConnectie.Open();

        //    SqlDataReader reader = command.ExecuteReader();

        //    while (reader.Read())
        //    {
        //        int aantal = reader.GetInt32(0);
        //        string naam = reader.GetString(1);
        //        double prijs = reader.GetDouble(2);
        //        int bestelling_id = reader.GetInt32(3);


        //        Afreken afreken = new Afreken(aantal, naam, prijs,bestelling_id);

        //        lijstAfreken.Add(afreken);
        //    }

        //    DBConnectie.Close();
        //    reader.Close();
        //    return lijstAfreken;
        //}
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int aantal = reader.GetInt32(0);
                string naam = reader.GetString(1);
                double prijs = reader.GetDouble(2);
                int bestelling_id = reader.GetInt32(3);


                Afreken afreken = new Afreken(aantal, naam, prijs,bestelling_id);

                lijstAfreken.Add(afreken);
            }

            DBConnectie.Close();
            reader.Close();
            return lijstAfreken;
        }*/


    }
}