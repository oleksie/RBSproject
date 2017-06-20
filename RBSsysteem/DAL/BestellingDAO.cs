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
    public class BestellingDAO
    {
        private SqlConnection DBConnectie;

        public BestellingDAO()
        {

        }

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

                //Bestelling bestelling = new Bestelling(aantal, tafelId, naam, prijs);

                //lijstbestellingen.Add(bestelling);
            }

            DBConnectie.Close();
            reader.Close();
            return lijstbestellingen;
        }

        
        // Code Alex
        public void PlaatsBestelling(Bestelling bestelling)
        {
            DALConnection connectie = new DALConnection();
            DBConnectie = connectie.MaakConnectieDB("Writer");

            DBConnectie.Open();

            SqlCommand command = new SqlCommand("INSERT INTO Bestelling (commentaar_klant, tafel_id, medewerker_id, totaal_prijs, betaald, btw, fooi, betaalwijze) VALUES (@commentaar, @tafelnr, @medewerkerid, @totaalprijs, @betaald, @btw, @fooi, @betaalwijze)", DBConnectie);

            SqlParameter IdParam1 = new SqlParameter("@commentaar", SqlDbType.NVarChar, -1);
            SqlParameter IdParam2 = new SqlParameter("@tafelnr", SqlDbType.Int);
            SqlParameter IdParam3 = new SqlParameter("@medewerkerid", SqlDbType.Int);
            SqlParameter IdParam4 = new SqlParameter("@totaalprijs", SqlDbType.Float);
            SqlParameter IdParam5 = new SqlParameter("@betaald", SqlDbType.NVarChar, 50);
            SqlParameter IdParam6 = new SqlParameter("@btw", SqlDbType.Float);
            SqlParameter IdParam7 = new SqlParameter("@fooi", SqlDbType.Float);
            SqlParameter IdParam8 = new SqlParameter("@betaalwijze", SqlDbType.NVarChar, 50);

            command.Parameters.Add(IdParam1);
            IdParam1.Value = bestelling.CommentaarKlant;

            command.Parameters.Add(IdParam2);
            IdParam2.Value = bestelling.TafelId;

            command.Parameters.Add(IdParam3);
            IdParam3.Value = bestelling.MedewerkerId;

            command.Parameters.Add(IdParam4);
            IdParam4.Value = bestelling.Totaalprijs;

            command.Parameters.Add(IdParam5);
            IdParam5.Value = bestelling.Betaald;

            command.Parameters.Add(IdParam6);
            IdParam6.Value = bestelling.Btw;

            command.Parameters.Add(IdParam7);
            IdParam7.Value = bestelling.Fooi;

            command.Parameters.Add(IdParam8);
            IdParam8.Value = bestelling.BetaalWijze;

            command.Prepare();

            command.ExecuteNonQuery();

            DBConnectie.Close();
        }

        //Code Alex
        public int GetHuidigeBestellingID(int medewerkerid, int tafelnr)
        {
            DALConnection connectie = new DALConnection();
            DBConnectie = connectie.MaakConnectieDB("Reader");

            DBConnectie.Open();

            SqlCommand command = new SqlCommand("SELECT bestelling_id FROM Bestelling WHERE medewerker_id = @medewerkerid AND tafel_id = @tafelnr AND betaald = 'nee'", DBConnectie);

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

        //voor anne
        public List<Bestelling> GetTafel()
        {
            DALConnection connectie = new DALConnection();
            DBConnectie = connectie.MaakConnectieDB("Reader");

            DBConnectie.Open();
            List<Bestelling> bestellingList = new List<Bestelling>();
            StringBuilder sb = new StringBuilder();

            sb.Append("select BestelItem.bestelitem_id, Bestelling.bestelling_id,Bestelling.commentaar_klant,Bestelling.medewerker_id,Bestelling.tafel_id,Bestelling.totaal_prijs,Bestelling.betaald,Bestelling.btw,Bestelling.fooi,Bestelling.betaalwijze from BestelItem inner join MenuItem on BestelItem.menuitem_id = MenuItem.menuitem_id inner join Bestelling on BestelItem.bestelling_id=Bestelling.bestelling_id;");

            String sql = sb.ToString();

            SqlCommand command = new SqlCommand(sql, DBConnectie);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int bestellingid = reader.GetInt32(1);
                string commentaar = reader.GetString(2);
                int medewerkerid = reader.GetInt32(3);
                int tafel = reader.GetInt32(4);
                double totaalPrijs = reader.GetDouble(5);
                string betaald = reader.GetString(6);
                double btw = reader.GetDouble(7);
                double fooi = reader.GetDouble(8);
                string betaalwijze = reader.GetString(9);

                Bestelling bestelling = new Bestelling();

                bestelling.Id = bestellingid;
                bestelling.CommentaarKlant = commentaar;
                bestelling.MedewerkerId = medewerkerid;
                bestelling.TafelId = tafel;
                bestelling.Totaalprijs = totaalPrijs;
                bestelling.Betaald = betaald;
                bestelling.Btw = btw;
                bestelling.Fooi = fooi;
                bestelling.BetaalWijze = betaalwijze;

                bestellingList.Add(bestelling);
            }

            DBConnectie.Close();
            reader.Close();
            return bestellingList;
        }

        public double GetTotaalPrijs(int bestellingid)
        {
            DALConnection connectie = new DALConnection();
            DBConnectie = connectie.MaakConnectieDB("Reader");

            DBConnectie.Open();

            SqlCommand command = new SqlCommand("SELECT totaal_prijs FROM Bestelling WHERE bestelling_id = @bestellingid", DBConnectie);

            SqlParameter IdParam1 = new SqlParameter("@bestellingid", SqlDbType.Int);
            command.Parameters.Add(IdParam1);
            IdParam1.Value = bestellingid;

            SqlDataReader reader = command.ExecuteReader();

            double prijs = 0;

            while (reader.Read())
            {
                prijs = reader.GetDouble(0);
            }

            reader.Close();
            DBConnectie.Close();

            return prijs;
        }

        public double GetBTW(int bestellingid)
        {
            DALConnection connectie = new DALConnection();
            DBConnectie = connectie.MaakConnectieDB("Reader");

            DBConnectie.Open();

            SqlCommand command = new SqlCommand("SELECT btw FROM Bestelling WHERE bestelling_id = @bestellingid", DBConnectie);

            SqlParameter IdParam1 = new SqlParameter("@bestellingid", SqlDbType.Int);
            command.Parameters.Add(IdParam1);
            IdParam1.Value = bestellingid;

            SqlDataReader reader = command.ExecuteReader();

            double btw = 0;

            while (reader.Read())
            {
                btw = reader.GetDouble(0);
            }

            reader.Close();
            DBConnectie.Close();

            return btw;
        }

        public List<Bestelling> GetAllBestellingen()
        {
            // Breng de database verbinding tot stand en voer een query uit
            DALConnection connectie = new DALConnection();
            DBConnectie = connectie.MaakConnectieDB("Reader");
            DBConnectie.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Bestelling", DBConnectie);
            SqlDataReader reader = command.ExecuteReader();

            // Maak een list met Bestelling
            List<Bestelling> bestellingen = new List<Bestelling>();

            // Vul de list met alle records die geretourneerd worden
            while (reader.Read())
            {
                Bestelling bestelling = new Bestelling();

                bestelling.Id = reader.GetInt32(0);
                bestelling.CommentaarKlant = reader.GetString(1);
                bestelling.TafelId = reader.GetInt32(2);
                bestelling.MedewerkerId = reader.GetInt32(3);
                bestelling.Totaalprijs = reader.GetDouble(4);
                bestelling.Betaald = reader.GetString(5);
                bestelling.Btw = reader.GetDouble(6);
                bestelling.Fooi = reader.GetDouble(7);
                bestelling.BetaalWijze = reader.GetString(8);

                bestellingen.Add(bestelling);
            }

            reader.Close();
            DBConnectie.Close();

            return bestellingen;
        }
        public void UpdateBestelling(int bestellingid, string betaalwijze, double fooi, string betaald)
        {
            DALConnection connectie = new DALConnection();
            DBConnectie = connectie.MaakConnectieDB("Writer");

            DBConnectie.Open();

            SqlCommand command = new SqlCommand("UPDATE Bestelling SET betaald = @betaald, fooi = @fooi, betaalwijze = @betaalwijze WHERE bestelling_id = @bestellingid", DBConnectie);

            SqlParameter IdParam1 = new SqlParameter("@betaald", SqlDbType.NVarChar, 50);
            SqlParameter IdParam2 = new SqlParameter("@fooi", SqlDbType.Float);
            SqlParameter IdParam3 = new SqlParameter("@betaalwijze", SqlDbType.NVarChar, 50);
            SqlParameter IdParam4 = new SqlParameter("@bestellingid", SqlDbType.Int);

            command.Parameters.Add(IdParam1);
            command.Parameters.Add(IdParam2);
            command.Parameters.Add(IdParam3);
            command.Parameters.Add(IdParam4);

            IdParam1.Value = betaald;
            IdParam2.Value = fooi;
            IdParam3.Value = betaalwijze;
            IdParam4.Value = bestellingid;

            command.Prepare();

            command.ExecuteNonQuery();

            DBConnectie.Close();
        }
    }
}