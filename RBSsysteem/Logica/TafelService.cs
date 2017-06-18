using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Model;

namespace Logica
{
    public class TafelService
    {
        private BestellingItemDAO bestellingItemDAO = new BestellingItemDAO();
        private BestellingDAO bestellingDAO = new BestellingDAO();
        private TafelDAO tafelDAO = new TafelDAO();
        public TafelService()
        {

        }

        public List<Tafel> GetTafels()
        {
            List<Tafel> tafels = tafelDAO.GetTafels();

            return tafels;
        }

        public void TafelOpBezetZetten(int inlognummer, int tafelnr)
        {
            tafelDAO.TafelBezetInDB(inlognummer, tafelnr);
        }

        public List<BestellingItem> GetGereedBestellingItemsList(int tafelId)
        {
            List<BestellingItem> alleBestellingItems = bestellingItemDAO.GetAll();
            List<Bestelling> alleBestellingen = bestellingDAO.GetBestelling();

            List<BestellingItem> gereedBestellingItems = new List<BestellingItem>();

            foreach (BestellingItem bestellingItem in alleBestellingItems)
            {
                if (bestellingItem.status == "bereid")
                    gereedBestellingItems.Add(bestellingItem);
            }

            return gereedBestellingItems;
        }
    }
}
