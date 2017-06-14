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
    public class BestellingltemDAO
    {
        DALConnection dbConnection = new DALConnection();

        public BestellingltemDAO()
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
                string opmerkingen = reader.GetString(3);
                int aantal = reader.GetInt32(4);
                string status = reader.GetString(5);
                DateTime tijdOpgenomen = reader.GetDateTime(6);



                BestellingItem bestellingitem = new BestellingItem();

                bestellingitem.bestelitemID = bestellingID;
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
