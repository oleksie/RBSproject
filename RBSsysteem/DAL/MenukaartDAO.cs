using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class MenukaartDAO
    {
        private SqlConnection DBConnectie;

        public MenukaartDAO()
        {
            
        }

        public List<MenuKaart> GetMenuKaart()
        {
            DALConnection connectie = new DALConnection();
            DBConnectie = connectie.MaakConnectieDB("Reader");

            DBConnectie.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM MenuKaart", DBConnectie);
            List<MenuKaart> MenuKaartItems = new List<MenuKaart>();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string naam = reader.GetString(1);

                MenuKaart kaart = new MenuKaart();
                kaart.ID = id;
                kaart.Naam = naam;

                MenuKaartItems.Add(kaart);
            }

            reader.Close();
            DBConnectie.Close();

            return MenuKaartItems;
        }
    }
}
