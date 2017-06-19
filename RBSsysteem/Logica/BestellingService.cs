using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using Logica;
using System.Windows.Forms;

namespace Logica
{
    public class BestellingService
    {
        List<ListviewBestellen> listvoorDB = new List<ListviewBestellen>();
        
        BestellingDAO bestellingDAO = new BestellingDAO();
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

        // Code Alex
        public void MaakNieuweBestelling(Medewerker medewerker, int tafelnr)
        {
            double totaalprijs = 0;
            string naam = "";
            foreach (ListviewBestellen x in listvoorDB)
            {
                totaalprijs = totaalprijs + x.Prijs;
                naam = x.Naam;
            }
            Bestelling bestellingInfo = new Bestelling();

            bestellingInfo.CommentaarKlant = "";
            bestellingInfo.Medewerkerid = medewerker.Id;
            bestellingInfo.Betaald = "nee";
            bestellingInfo.Btw = totaalprijs * 0.21;
            bestellingInfo.TafelId= tafelnr;
            bestellingInfo.Fooi = 0;
            bestellingInfo.Totaalprijs = totaalprijs;
            bestellingInfo.BetaalWijze = "";

            bestellingDAO.PlaatsBestelling(bestellingInfo);
        }

        public int GetBestellingID(Medewerker medewerker, int tafelnr)
        {
            BestellingDAO bestelling = new BestellingDAO();
            int bestellingID = bestelling.GetHuidigeBestellingID(medewerker.Id, tafelnr);

            return bestellingID;
        }

        public void GetTotaalPrijs(int bestellingid, TextBox txtprijs)
        {
            double prijs = bestellingDAO.GetTotaalPrijs(bestellingid);
            txtprijs.Text = prijs.ToString("0.00");
        }

        public void GetBTW(int bestellingid, TextBox txtbtw)
        {
            double btw = bestellingDAO.GetBTW(bestellingid);
            txtbtw.Text = btw.ToString("0.00");
        }

        public List<Bestelling> GetAlleBestellingen()
        {
            // Haal alle bestellingen op uit de bestelling tabel via de BestellingDAO en retourneer deze
            List<Bestelling> alleBestellingen = bestellingDAO.GetAllBestellingen();
            return alleBestellingen;
        }

        public void UpdateBestelling(int bestellingid, string betaalwijze, double fooi, string betaald)
        {
            bestellingDAO.UpdateBestelling(bestellingid, betaalwijze, fooi, betaald);
        }
    }
}
