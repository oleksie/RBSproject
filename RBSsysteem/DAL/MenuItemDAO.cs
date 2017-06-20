using System;
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

        //Code Alex
        public List<MenuItem> GetMenuItems()
        {
            DALConnection connectie = new DALConnection();
            DBConnectie = connectie.MaakConnectieDB("Reader");

            DBConnectie.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM MenuItem", DBConnectie);
            List<MenuItem> listMenuItems = new List<MenuItem>();

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
                menuItem.MenuItemID = id;
                menuItem.CategorieID = categorieid;
                menuItem.Voorraad = voorraad;
                menuItem.Naam = naam;
                menuItem.Prijs = prijs;
                menuItem.Omschrijving = omschrijving;

                listMenuItems.Add(menuItem);
            }

            reader.Close();
            DBConnectie.Close();

            return listMenuItems;
        }

        //Code Alex
        public List<MenuItem> GetSpecefiekegerechtItems(int categorieID)
        {
            DALConnection connectie = new DALConnection();
            DBConnectie = connectie.MaakConnectieDB("Reader");

            DBConnectie.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM MenuItem WHERE categorie_id = @categorieID", DBConnectie);
            List<MenuItem> listMenuItems = new List<MenuItem>();

            SqlParameter IdParam1 = new SqlParameter("@categorieID", SqlDbType.Int);
            command.Parameters.Add(IdParam1);
            IdParam1.Value = categorieID;

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
                menuItem.MenuItemID = id;
                menuItem.CategorieID = categorieid;
                menuItem.Voorraad = voorraad;
                menuItem.Naam = naam;
                menuItem.Prijs = prijs;
                menuItem.Omschrijving = omschrijving;

                listMenuItems.Add(menuItem);
            }

            reader.Close();
            DBConnectie.Close();

            return listMenuItems;
        }
        //dit is voor anne
        public List<MenuItem> GetNaamCategorie()
        {
            DALConnection connectie = new DALConnection();
            DBConnectie = connectie.MaakConnectieDB("Reader");
            List<MenuItem> menuItemList = new List<MenuItem>();

            DBConnectie.Open();
            StringBuilder sb = new StringBuilder();

            sb.Append("select BestelItem.bestelitem_id,BestelItem.menuitem_id,MenuItem.naam,MenuItem.categorie_id,MenuItem.omschrijving,MenuItem.prijs,MenuItem.voorraad from BestelItem inner join MenuItem on BestelItem.menuitem_id = MenuItem.menuitem_id; ");

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

                menuitem.MenuItemID = menuitemid;
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

        //Code Alex
        public void UpdateVoorraad(List<ListviewBestellen> listMetBesteldeItems)
        {
            foreach (ListviewBestellen x in listMetBesteldeItems)
            {
                DALConnection connectie = new DALConnection();
                DBConnectie = connectie.MaakConnectieDB("Reader");

                DBConnectie.Open();

                SqlCommand command = new SqlCommand("UPDATE MenuItem SET voorraad = voorraad - @aantal WHERE menuitem_id = @menuitemid", DBConnectie);

                SqlParameter IdParam1 = new SqlParameter("@aantal", SqlDbType.Int);
                command.Parameters.Add(IdParam1);
                IdParam1.Value = x.Aantal;

                SqlParameter IdParam2 = new SqlParameter("@menuitemid", SqlDbType.Int);
                command.Parameters.Add(IdParam2);
                IdParam2.Value = x.MenuItemID;

                command.Prepare();

                command.ExecuteNonQuery();

                DBConnectie.Close();
            }
            
        }
    }
}
