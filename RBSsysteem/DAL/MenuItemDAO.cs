using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

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
    }
}
