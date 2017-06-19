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
            bestellingInfo.medewerkerid = medewerker.Id;
            bestellingInfo.betaald = "nee";
            bestellingInfo.btw = totaalprijs * 0.21;
            bestellingInfo.tafelId= tafelnr;
            bestellingInfo.fooi = 0;
            bestellingInfo.totaalprijs = totaalprijs;
            bestellingInfo.betaalWijze = "";

            
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
            List<Bestelling> alleBestellingen = bestellingDAO.GetAllBestellingen();

            return alleBestellingen;
        }

        public void UpdateBestelling(int bestellingid, string betaalwijze, double fooi, string betaald)
        {
            bestellingDAO.UpdateBestelling(bestellingid, betaalwijze, fooi, betaald);
        }
    }
}
