﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class BestellingItemDAO
    {
        DALConnection dbConnection = new DALConnection();
       
        public BestellingItemDAO()
        {

        }

        public List<BestellingItem> GetAll()
        {
            //open connectie
            SqlConnection connection = dbConnection.MaakConnectieDB("reader");
            List<BestellingItem> bestellingItemList = new List<BestellingItem>();

            connection.Open();
            StringBuilder sb = new StringBuilder();
            //string en execute
            sb.Append("select BestelItem.bestelitem_id,BestelItem.bestelling_id,BestelItem.menuitem_id,BestelItem.opmerkingen,BestelItem.aantal,BestelItem.status,BestelItem.tijd_opgenomen,MenuItem.naam,MenuItem.categorie_id,Bestelling.tafel_id from BestelItem inner join MenuItem on BestelItem.menuitem_id = MenuItem.menuitem_id inner join Bestelling on BestelItem.bestelling_id=Bestelling.bestelling_id;");

            string sql = sb.ToString();

            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                //read uit database
                int bestellingitemID = reader.GetInt32(0);
                int bestellingID = reader.GetInt32(1);
                int menuitemID = reader.GetInt32(2);
                string opmerkingen = reader.GetString(3);
                int aantal = reader.GetInt32(4);
                string status = reader.GetString(5);
                DateTime tijdOpgenomen = reader.GetDateTime(6);
                string naam = reader.GetString(7);

                //vul object(volledig!)
                BestellingItem bestellingitem = new BestellingItem();

                bestellingitem.BestelitemID = bestellingitemID;
                bestellingitem.MenuItemID = menuitemID;
                bestellingitem.BestellingID = bestellingID;
                bestellingitem.Commentaar = opmerkingen;
                bestellingitem.Aantal = aantal;
                bestellingitem.Status = status;
                bestellingitem.TijdOpgenomen = tijdOpgenomen;
                bestellingitem.Naam = naam;

                bestellingItemList.Add(bestellingitem);
            }
            //close connection en geef list terug
            connection.Close();
            reader.Close();
            return bestellingItemList;
        }

        public void UpdateStatus(int id,string status)
        {
            //connection open
            SqlConnection connection = dbConnection.MaakConnectieDB("writer");

            connection.Open();
            StringBuilder sb = new StringBuilder();
            //string met een variable @id wordt id die is meegegeven
            sb.Append("Update BESTELITEM SET status = @status where bestelitem_id = @id");
            
            SqlParameter BestelIDParam = new SqlParameter("@id", SqlDbType.Int, 32);
            SqlParameter StatusParam = new SqlParameter("@status", SqlDbType.NVarChar, 50);

            String sql = sb.ToString();

            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.Add(BestelIDParam);
            command.Parameters.Add(StatusParam);

            StatusParam.Value = status;
            BestelIDParam.Value = id;
            //uitvoeren query
            command.Prepare();
            command.ExecuteNonQuery();

            connection.Close(); ;
        }

        //Code Alex
        public void PlaatsBestellingItem(BestellingItem besteldeItem)
        {
            SqlConnection connection = dbConnection.MaakConnectieDB("Writer");
            connection.Open();

            SqlCommand command = new SqlCommand("INSERT INTO BestelItem (bestelling_id, menuitem_id, opmerkingen, aantal, status, tijd_opgenomen) VALUES (@bestellingID, @menuitemID, @commentaar, @aantal ,@status, @tijdopgenomen)", connection);

            SqlParameter IdParam1 = new SqlParameter("@bestellingiD", SqlDbType.Int);
            SqlParameter IdParam2 = new SqlParameter("@menuitemID", SqlDbType.Int);
            SqlParameter IdParam3 = new SqlParameter("@commentaar", SqlDbType.NVarChar, -1);
            SqlParameter IdParam4 = new SqlParameter("@aantal", SqlDbType.Int);
            SqlParameter IdParam5 = new SqlParameter("@status", SqlDbType.NVarChar, 50);
            SqlParameter IdParam6 = new SqlParameter("@tijdopgenomen", SqlDbType.DateTime);

            command.Parameters.Add(IdParam1);
            IdParam1.Value = besteldeItem.BestellingID;

            command.Parameters.Add(IdParam2);
            IdParam2.Value = besteldeItem.MenuItemID;

            command.Parameters.Add(IdParam3);
            IdParam3.Value = besteldeItem.Commentaar;

            command.Parameters.Add(IdParam4);
            IdParam4.Value = besteldeItem.Aantal;

            command.Parameters.Add(IdParam5);
            IdParam5.Value = besteldeItem.Status;

            command.Parameters.Add(IdParam6);
            IdParam6.Value = besteldeItem.TijdOpgenomen;

            command.Prepare();

            command.ExecuteNonQuery();

            connection.Close();
        }

        //Code Alex
        public void vulTotaalPrijs(int bestellingid, List<ListviewBestellen> listMetBesteldeItems)
        {
            foreach (ListviewBestellen x in listMetBesteldeItems)
            {
                SqlConnection connection = dbConnection.MaakConnectieDB("Writer");
                connection.Open();

                SqlCommand command = new SqlCommand("UPDATE Bestelling SET totaal_prijs = totaal_prijs + @prijs WHERE bestelling_id = @bestellingid", connection);

                SqlParameter IdParam1 = new SqlParameter("@bestellingid", SqlDbType.Int);
                command.Parameters.Add(IdParam1);
                IdParam1.Value = bestellingid;

                SqlParameter IdParam2 = new SqlParameter("@prijs", SqlDbType.Float);
                command.Parameters.Add(IdParam2);
                IdParam2.Value = x.Prijs;

                command.Prepare();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        //Code Alex
        public void vulBTW(int bestellingid, List<ListviewBestellen> listMetBesteldeItems)
        {
            SqlConnection connection = dbConnection.MaakConnectieDB("Writer");
            connection.Open();

            SqlCommand command = new SqlCommand("UPDATE Bestelling SET btw = totaal_prijs * 0.21 WHERE bestelling_id = @bestellingid", connection);

            SqlParameter IdParam1 = new SqlParameter("@bestellingid", SqlDbType.Int);
            command.Parameters.Add(IdParam1);
            IdParam1.Value = bestellingid;

            command.Prepare();

            command.ExecuteNonQuery();

            connection.Close();
        }

        public List<Afreken> GetAllAfrekenen(int bestellingid)
        {
            SqlConnection connection = dbConnection.MaakConnectieDB("reader");
            List<Afreken> bestellingItemList = new List<Afreken>();

            connection.Open();
            StringBuilder sb = new StringBuilder();

            sb.Append("SELECT BestelItem.aantal, MenuItem.naam, MenuItem.prijs from BestelItem inner join MenuItem on BestelItem.menuitem_id = MenuItem.menuitem_id WHERE bestelling_id = @bestellingid");



            String sql = sb.ToString();

            SqlCommand command = new SqlCommand(sql, connection);

            SqlParameter IdParam1 = new SqlParameter("@bestellingid", SqlDbType.Int);
            command.Parameters.Add(IdParam1);
            IdParam1.Value = bestellingid;

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string naam = reader.GetString(1);
                int aantal = reader.GetInt32(0);
                double prijs = reader.GetDouble(2);

                Afreken bestellingitem = new Afreken();

                bestellingitem.Naam = naam;
                bestellingitem.Aantal = aantal;
                bestellingitem.Prijs = prijs;

                bestellingItemList.Add(bestellingitem);
            }

            connection.Close();
            reader.Close();
            return bestellingItemList;
        }
    }
}
