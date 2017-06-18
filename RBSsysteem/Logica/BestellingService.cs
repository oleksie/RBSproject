using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using Logica;

namespace Logica
{
    public class BestellingService
    {
        
        List<ListviewBestellen> listvoorDB = new List<ListviewBestellen>();
        
        BestellingDAO bestelling = new BestellingDAO();
        MenuItemService getListMetItems = new MenuItemService();

        public BestellingService()
        {

        }

        public List<Bestelling> GetBestelling()
        {
            BestellingDAO bestellingDAO = new BestellingDAO();
            return bestellingDAO.GetBestelling();

            //return bestellingen;
        }

        public void MaakNieuweBestelling(Medewerker medewerker, int tafelnr)
        {
            

            //Getlist.listvoorDB = getListMetItems.listVoorListview;

            double totaalprijs = 0;
            string naam = "";
            foreach (ListviewBestellen x in listvoorDB)
            {
                totaalprijs = totaalprijs + x.prijs;
                naam = x.naam;
                
            }
            Bestelling bestellingInfo = new Bestelling();

            bestellingInfo.commentaarKlant = "";
            bestellingInfo.medewerkerid = medewerker.medewerkerId;
            bestellingInfo.betaald = "nee";
            bestellingInfo.btw = totaalprijs * 0.21;
            bestellingInfo.tafelId= tafelnr;
            bestellingInfo.fooi = 0;
            bestellingInfo.totaalprijs = totaalprijs;
            bestellingInfo.betaalWijze = "";

            
            bestelling.PlaatsBestelling(bestellingInfo);
        }

        public int GetBestellingID(Medewerker medewerker, int tafelnr)
        {
            BestellingDAO bestelling = new BestellingDAO();
            int bestellingID = bestelling.GetHuidigeBestellingID(medewerker.medewerkerId, tafelnr);

            return bestellingID;
        }
    }
}
