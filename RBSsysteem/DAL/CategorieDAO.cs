using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class CategorieDAO
    {
        private SqlConnection DBConnectie;

        public CategorieDAO()
        {

        }

        public List<Categorie> GetCategorie()
        {
            DALConnection connectie = new DALConnection();
            DBConnectie = connectie.MaakConnectieDB("Reader");

            DBConnectie.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Categorie", DBConnectie);
            List<Categorie> CategorieItems = new List<Categorie>();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                int menukaartid = reader.GetInt32(1);
                string naam = reader.GetString(2);

                Categorie categorie = new Categorie();
                categorie.ID = id;
                categorie.MenuKaartID = menukaartid;
                categorie.Naam = naam;

                CategorieItems.Add(categorie);
            }

            reader.Close();
            DBConnectie.Close();

            return CategorieItems;
        }
    }
}
