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
            List<Tafel> tafels = new List<Tafel>();

            DALConnection connectie = new DALConnection();
            DBConnectie = connectie.MaakConnectieDB("Reader");
            DBConnectie.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Tafel", DBConnectie);

            SqlDataReader reader = command.ExecuteReader();
            
            // vul tafels list met resultaten
            while (reader.Read())
            {
                Tafel tafel = new Tafel(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3));
                tafels.Add(tafel);
            }

            reader.Close();
            DBConnectie.Close();

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
