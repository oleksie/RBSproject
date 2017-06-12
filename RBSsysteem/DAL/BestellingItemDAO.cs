using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using System.Configuration;
using System.Data.SqlClient;

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

            sb.Append("Select * From BestelItem");

            String sql = sb.ToString();

            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int bestellingID = reader.GetInt32(0);
                int menuitemID = reader.GetInt32(1);
                string opmerkingen = reader.GetString(2);
                int aantal = reader.GetInt32(3);
                int status = reader.GetInt32(4);
                DateTime tijdOpgenomen = reader.GetDateTime(5);



                BestellingItem bestellingitem = new BestellingItem();

                //bestellingitem.menuitem = menuitemID;
                bestellingitem.commentaar = opmerkingen;
                bestellingitem.aantal = aantal;
                bestellingitem.status = status;
                bestellingitem.tijdOpgenomen = tijdOpgenomen;
                

                bestellingItemList.Add(bestellingitem);
            }

            connection.Close();
            reader.Close();
            return bestellingItemList;
        }
    }
}
