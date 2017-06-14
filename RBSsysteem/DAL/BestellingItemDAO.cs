using System;
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
            SqlConnection connection = dbConnection.MaakConnectieDB("reader");
            List<BestellingItem> bestellingItemList = new List<BestellingItem>();

            connection.Open();
            StringBuilder sb = new StringBuilder();

            sb.Append("select BestelItem.bestelitem_id,BestelItem.menuitem_id,BestelItem.opmerkingen,BestelItem.aantal,BestelItem.status,BestelItem.tijd_opgenomen,MenuItem.naam from BestelItem inner join MenuItem on BestelItem.menuitem_id = MenuItem.menuitem_id; ");

            String sql = sb.ToString();

            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int bestellingID = reader.GetInt32(0);
                int menuitemID = reader.GetInt32(1);
                string opmerkingen = reader.GetString(2);
                int aantal = reader.GetInt32(3);
                string status = reader.GetString(4);
                DateTime tijdOpgenomen = reader.GetDateTime(5);
                string naam = reader.GetString(6);


                BestellingItem bestellingitem = new BestellingItem();

                bestellingitem.bestelitemID = bestellingID;
                //bestellingitem.menuitem = menuitemID;
                bestellingitem.commentaar = opmerkingen;
                bestellingitem.aantal = aantal;
                bestellingitem.status = status;
                bestellingitem.tijdOpgenomen = tijdOpgenomen;
                //bestellingitem.menuitem.Naam = naam;

                bestellingItemList.Add(bestellingitem);
            }

            connection.Close();
            reader.Close();
            return bestellingItemList;
        }

        public List<MenuItem> GetNaamCategorie()
        {
            SqlConnection connection = dbConnection.MaakConnectieDB("reader");
            List<MenuItem> menuItemList = new List<MenuItem>();

            connection.Open();
            StringBuilder sb = new StringBuilder();

            sb.Append("select BestelItem.bestelitem_id,BestelItem.menuitem_id,BestelItem.opmerkingen,BestelItem.aantal,BestelItem.status,BestelItem.tijd_opgenomen,MenuItem.naam,MenuItem.categorie_id from BestelItem inner join MenuItem on BestelItem.menuitem_id = MenuItem.menuitem_id; ");

            String sql = sb.ToString();

            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string naam = reader.GetString(6);
                int id = reader.GetInt32(7);


                MenuItem menuitem = new MenuItem();
                menuitem.Naam = naam;
                menuitem.CategorieID = id;

                menuItemList.Add(menuitem);
            }

            connection.Close();
            reader.Close();
            return menuItemList;
        }
        public void UpdateStatus(int id)
        {
            SqlConnection connection = dbConnection.MaakConnectieDB("writer");

            connection.Open();
            StringBuilder sb = new StringBuilder();

            sb.Append("Update BESTELITEM SET status = 'bereid' where bestelitem_id = @id");
            
            SqlParameter BestelIDParam = new SqlParameter("@id", SqlDbType.Int, 32);

            String sql = sb.ToString();

            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.Add(BestelIDParam);

            BestelIDParam.Value = id;
            command.Prepare();
            command.ExecuteNonQuery();

            connection.Close(); ;
        }
    }
}
