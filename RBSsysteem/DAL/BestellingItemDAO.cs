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

        public void PlaatsBestellingItem(BestellingItem item)
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
            IdParam1.Value = item.bestellingID;

            command.Parameters.Add(IdParam2);
            IdParam2.Value = item.menuitemid;

            command.Parameters.Add(IdParam3);
            IdParam3.Value = item.commentaar;

            command.Parameters.Add(IdParam4);
            IdParam4.Value = item.aantal;

            command.Parameters.Add(IdParam5);
            IdParam5.Value = item.status;

            command.Parameters.Add(IdParam6);
            IdParam6.Value = item.tijdOpgenomen;

            command.Prepare();

            command.ExecuteNonQuery();

            connection.Close();
        }

        public int GetTotaalPrijs(int bestellingid)
        {
            SqlConnection connection = dbConnection.MaakConnectieDB("Reader");
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT (prijs * aantal) FROM MenuItem INNER JOIN BestelItem ON BestelItem.menuitemid = MenuItem.menuitemid WHERE bestellingid = @bestellingid", connection);

            SqlDataReader reader = command.ExecuteReader();
            int totaalPrijs = 0;

            while (reader.Read())
            {
                totaalPrijs = totaalPrijs + reader.GetInt32(0);
            }

            connection.Close();
            reader.Close();

            return totaalPrijs;
        }
    }
}
