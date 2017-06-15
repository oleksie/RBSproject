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


 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class BestellingDAO
    {
        private SqlConnection DBConnectie;

        public BestellingDAO()
        {

        }

        public void PlaatsBestelling(Bestelling bestelling)
        {
            DALConnection connectie = new DALConnection();
            DBConnectie = connectie.MaakConnectieDB("Writer");

            DBConnectie.Open();

            SqlCommand command = new SqlCommand("INSERT INTO Bestelling (commentaar_klant, tafel_id, medewerker_id, totaal_prijs) VALUES (@commentaar, @tafelnr, @medewerkerid, @totaalprijs)", DBConnectie);

            SqlParameter IdParam1 = new SqlParameter("@commentaar", SqlDbType.NVarChar, -1);
            SqlParameter IdParam2 = new SqlParameter("@tafelnr", SqlDbType.Int);
            SqlParameter IdParam3 = new SqlParameter("@medewerkerid", SqlDbType.Int);
            SqlParameter IdParam4 = new SqlParameter("@totaalprijs", SqlDbType.Float);

            command.Parameters.Add(IdParam1);
            IdParam1.Value = bestelling.commentaarKlant;

            command.Parameters.Add(IdParam2);
            IdParam2.Value = bestelling.tafel.tafel_id;

            command.Parameters.Add(IdParam3);
            IdParam3.Value = bestelling.medewerker.medewerkerId;

            command.Parameters.Add(IdParam4);
            IdParam4.Value = bestelling.totaalprijs;

            command.Prepare();

            command.ExecuteNonQuery();

            DBConnectie.Close();
        }

        public int GetHuidigeBestellingID(int medewerkerid, int tafelnr)
        {
            DALConnection connectie = new DALConnection();
            DBConnectie = connectie.MaakConnectieDB("Reader");

            DBConnectie.Open();

            SqlCommand command = new SqlCommand("SELECT bestelling_id FROM Bestelling INNER JOIN Tafel ON Tafel.tafel_id = Bestelling.tafel_id WHERE Bestelling.medewerker_id = @medewerkerid AND Tafel.tafel_id = @tafelnr AND Tafel.status = 'bezet'", DBConnectie);

            SqlParameter IdParam1 = new SqlParameter("@medewerkerid", SqlDbType.Int);
            command.Parameters.Add(IdParam1);
            IdParam1.Value = medewerkerid;

            SqlParameter IdParam2 = new SqlParameter("@tafelnr", SqlDbType.Int);
            command.Parameters.Add(IdParam2);
            IdParam2.Value = tafelnr;

            SqlDataReader reader = command.ExecuteReader();

            int id = 0;

            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }

            reader.Close();
            DBConnectie.Close();

            return id;
        }
    }
}