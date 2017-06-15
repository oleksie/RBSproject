using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Logica
{
    public class BestellingService
    {
        public int tafelnr = 1;
        public int medewerkerid = 2;

        public BestellingService()
        {

        }

        public List<Bestelling> GetBestelling()
        {
            BestellingDAO bestellingDAO = new BestellingDAO();
            return bestellingDAO.GetBestelling();

            //return bestellingen;
        }

        public void MaakNieuweBestelling()
        {
            BestellingItemDAO bestellingPrijs = new BestellingItemDAO();

            Bestelling bestellingInfo = new Bestelling();

            bestellingInfo.medewerkerid= medewerkerid;
            bestellingInfo.commentaarKlant = "";
            bestellingInfo.tafelId= tafelnr;
            bestellingInfo.prijs= 0;

            BestellingDAO bestelling = new BestellingDAO();
            bestelling.PlaatsBestelling(bestellingInfo);
        }
    }
}
