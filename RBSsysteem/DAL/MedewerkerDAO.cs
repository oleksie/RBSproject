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
            // Breng verbinding met database tot stand
            DALConnection connectie = new DALConnection();
            DBConnectie = connectie.MaakConnectieDB("Reader");
            DBConnectie.Open();

            // Query aanmaken
            SqlCommand command = new SqlCommand(
                "SELECT medewerker_id, naam, rol FROM Medewerker WHERE inlognummer = @inlognummer",
                DBConnectie
            );
            // Inlognummer als parameter meegeven ter voorkoming van SQL injectie
            command.Parameters.Add(new SqlParameter("inlognummer", inlognummer));
            // Query uitvoeren
            SqlDataReader reader = command.ExecuteReader();

            // controleer of er ten minste één record is terug gestuurd
            if (!reader.Read())
                return null;

            // Vul de opgehaalde data in variabelen
            int medewerkerId = reader.GetInt32(0);
            string naam = reader.GetString(1);
            Rol rol = (Rol) reader.GetInt32(2);

            // Maak het Medewerker object aan met de opgevraagde data en het als parameter doorgegeven inlognummer
            Medewerker medewerker = new Medewerker(medewerkerId, naam, inlognummer, rol);

            // controleer of er nog een record is terug gestuurd, dit zou in geen enkel geval voor moeten komen
            // aangezien inlognummers uniek zijn
            if (reader.Read())
                throw new InvalidOperationException("Multiple records were returned.");

            // Sluit reader en verbinding
            reader.Close();
            DBConnectie.Close();

            // Retourneer het gevulde object
            return medewerker;
        }
    }
}
