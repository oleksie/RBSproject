﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace DAL
{
    public class MenuItemDAO
    {
        private SqlConnection DBConnectie;

        public MenuItemDAO()
        {

        }

        public List<MenuItem> GetMenuItems()
        {
            DALConnection connectie = new DALConnection();
            DBConnectie = connectie.MaakConnectieDB("Reader");

            DBConnectie.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM MenuItem", DBConnectie);
            List<MenuItem> menuItems = new List<MenuItem>();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                int categorieid = reader.GetInt32(1);
                int voorraad = reader.GetInt32(2);
                string naam = reader.GetString(3);
                double prijs = reader.GetDouble(4);
                string omschrijving = reader.GetString(5);

                MenuItem menuItem = new MenuItem();
                menuItem.ID = id;
                menuItem.CategorieID = categorieid;
                menuItem.Voorraad = voorraad;
                menuItem.Naam = naam;
                menuItem.Prijs = prijs;
                menuItem.Omschrijving = omschrijving;

                menuItems.Add(menuItem);
            }

            reader.Close();
            DBConnectie.Close();

            return menuItems;
        }

        public List<MenuItem> GetSpecefiekegerechtItems(int getal)
        {
            DALConnection connectie = new DALConnection();
            DBConnectie = connectie.MaakConnectieDB("Reader");

            DBConnectie.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM MenuItem WHERE categorie_id = @getal", DBConnectie);
            List<MenuItem> menuItems = new List<MenuItem>();

            SqlParameter IdParam1 = new SqlParameter("@getal", SqlDbType.Int);
            command.Parameters.Add(IdParam1);
            IdParam1.Value = getal;

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                int categorieid = reader.GetInt32(1);
                int voorraad = reader.GetInt32(2);
                string naam = reader.GetString(3);
                double prijs = reader.GetDouble(4);
                string omschrijving = reader.GetString(5);

                MenuItem menuItem = new MenuItem();
                menuItem.ID = id;
                menuItem.CategorieID = categorieid;
                menuItem.Voorraad = voorraad;
                menuItem.Naam = naam;
                menuItem.Prijs = prijs;
                menuItem.Omschrijving = omschrijving;

                menuItems.Add(menuItem);
            }

            reader.Close();
            DBConnectie.Close();

            return menuItems;
        }
        //dit is voor anne
        public List<MenuItem> GetNaamCategorie()
        {
            DALConnection connectie = new DALConnection();
            DBConnectie = connectie.MaakConnectieDB("Reader");
            List<MenuItem> menuItemList = new List<MenuItem>();

            DBConnectie.Open();
            StringBuilder sb = new StringBuilder();

            sb.Append("select BestelItem.bestelitem_id,BestelItem.menuitem_id,BestelItem.opmerkingen,BestelItem.aantal,BestelItem.status,BestelItem.tijd_opgenomen,MenuItem.naam,MenuItem.categorie_id from BestelItem inner join MenuItem on BestelItem.menuitem_id = MenuItem.menuitem_id; ");

            String sql = sb.ToString();

            SqlCommand command = new SqlCommand(sql, DBConnectie);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int menuitemid = reader.GetInt32(1);
                string naam = reader.GetString(2);
                int categorieid = reader.GetInt32(3);
                string omschrijving = reader.GetString(4);
                double prijs = reader.GetDouble(5);
                int voorraad = reader.GetInt32(6);


                MenuItem menuitem = new MenuItem();

                menuitem.ID = menuitemid;
                menuitem.Voorraad = voorraad;
                menuitem.Prijs = prijs;
                menuitem.Naam = naam;
                menuitem.CategorieID = categorieid;
                menuitem.Omschrijving = omschrijving;

                menuItemList.Add(menuitem);
            }

            DBConnectie.Close();
            reader.Close();
            return menuItemList;
        }
    }
}
