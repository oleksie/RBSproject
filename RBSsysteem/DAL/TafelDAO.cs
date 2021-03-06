﻿using System;
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
            // Database verbinding tot stand brengen en query aanmaken en uitvoeren
            DALConnection connectie = new DALConnection();
            DBConnectie = connectie.MaakConnectieDB("Reader");
            DBConnectie.Open();
            SqlCommand command = new SqlCommand("SELECT tafel_id, status, capaciteit, bezet_door FROM Tafel", DBConnectie);
            SqlDataReader reader = command.ExecuteReader();

            // Maak een list aan met Tafel als datatype
            List<Tafel> tafels = new List<Tafel>();

            // vul tafels list met resultaten
            while (reader.Read())
            {
                // Schrijf de opgehaalde data weg in variabelen
                int tafelId = reader.GetInt32(0);
                string status = reader.GetString(1);
                int capaciteit = reader.GetInt32(2);
                int bezetDoor = reader.GetInt32(3);
                // Maak tafel object aan met de bovenstaande gegevens als parameters voor de constructor
                Tafel tafel = new Tafel(tafelId, status, capaciteit, bezetDoor);
                // Voeg tafel object toe aan List<Tafel> tafels
                tafels.Add(tafel);
            }

            // Sluit sql reader en database verbinding
            reader.Close();
            DBConnectie.Close();

            // Retourneer opgehaalde tafels
            return tafels;
        }

        public void TafelBezetInDB(int inlognummer, int tafelnr)
        {
            DALConnection connectie = new DALConnection();
            DBConnectie = connectie.MaakConnectieDB("Writer");

            DBConnectie.Open();

            SqlCommand command = new SqlCommand("UPDATE Tafel SET status = 'bezet', bezet_door = @inlognummer WHERE tafel_id = @tafelnr; ", DBConnectie);

            SqlParameter IdParam1 = new SqlParameter("@inlognummer", SqlDbType.Int);
            SqlParameter IdParam2 = new SqlParameter("@tafelnr", SqlDbType.Int);

            command.Parameters.Add(IdParam1);
            command.Parameters.Add(IdParam2);

            IdParam1.Value = inlognummer;
            IdParam2.Value = tafelnr;

            command.Prepare();

            command.ExecuteNonQuery();

            DBConnectie.Close();
        }

        public void UpdateTafel(int tafelnr)
        {
            DALConnection connectie = new DALConnection();
            DBConnectie = connectie.MaakConnectieDB("Writer");

            DBConnectie.Open();

            SqlCommand command = new SqlCommand("UPDATE Tafel SET status = 'vrij', bezet_door = 0 WHERE tafel_id = @tafelnr; ", DBConnectie);

            SqlParameter IdParam1 = new SqlParameter("@tafelnr", SqlDbType.Int);
            command.Parameters.Add(IdParam1);
            IdParam1.Value = tafelnr;

            command.Prepare();

            command.ExecuteNonQuery();

            DBConnectie.Close();
        }
    }
}
