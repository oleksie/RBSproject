using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class MedewerkerDAO
    {
        private SqlConnection DBConnectie;

        public MedewerkerDAO()
        {

        }

        public Medewerker GetMedewerker(int inlognummer)
        {
            Medewerker medewerker = new Medewerker();

            DALConnection connectie = new DALConnection();
            DBConnectie = connectie.MaakConnectieDB("Reader");
            DBConnectie.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Medewerker WHERE inlognummer = @inlognummer", DBConnectie);
            command.Parameters.Add(new SqlParameter("inlognummer", inlognummer));
            
            SqlDataReader reader = command.ExecuteReader();

            // controleer of er ten minste één record is terug gestuurd
            if (!reader.Read())
                throw new InvalidOperationException("No records were returned.");

            medewerker.medewerkerId = reader.GetInt32(0);
            medewerker.naam = reader.GetString(1);
            medewerker.inlognummer = reader.GetInt32(2);
            medewerker.rol = (Rol) reader.GetInt32(3);

            // controleer of er nog een record is terug gestuurd
            if (reader.Read())
                throw new InvalidOperationException("Multiple records were returned.");

            reader.Close();
            DBConnectie.Close();

            return medewerker;
        }
    }
}
