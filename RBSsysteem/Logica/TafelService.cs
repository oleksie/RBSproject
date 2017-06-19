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

        public void UpdateTafel(int tafelnr)
        {
            tafelDAO.UpdateTafel(tafelnr);
        }
        //public List<ListviewBereid> GetGereedBestellingItemsList(int tafelId)
        //{
        //    List<BestellingItem> alleBestellingItems = bestellingItemDAO.GetAll();
        //    List<Bestelling> alleBestellingen = bestellingDAO.GetAllBestellingen();

        //    List<ListviewBereid> gereedBestellingItems = new List<ListviewBereid>();

        //    for (int i = 0; i < alleBestellingen.Count; i++)
        //    {
        //        if(alleBestellingItems[i].status == "bereid")
        //        {
        //            if(alleBestellingItems[i].bestellingID == alleBestellingen[i].bestelling_id)
        //            {
        //                ListviewBereid gereedBestelling = new ListviewBereid();
        //                gereedBestelling.aantal = alleBestellingItems[i].aantal;
        //                gereedBestelling.naam = alleBestellingItems[i].
        //            }
        //        }
        //    }

        //    return gereedBestellingItems;
        //}
    }
}
