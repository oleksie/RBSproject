using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using System.Windows.Forms;

namespace Logica
{
    public class BestelItemService
    {
        BestellingItem besteldeItem = new BestellingItem();
        BestellingItemDAO bestellingItemDAO = new BestellingItemDAO();

        public BestelItemService()
        {

        }

        //Code Alex
        public void VerwerkNieuweBestelling(int bestellingID, List<ListviewBestellen> list)
        {
            foreach (ListviewBestellen x in list)
            {
                besteldeItem.BestellingID = bestellingID;
                besteldeItem.Aantal = x.Aantal;
                besteldeItem.Commentaar = x.Opmerking;
                besteldeItem.MenuItemID = x.MenuItemID;
                besteldeItem.Status = "besteld";
                besteldeItem.TijdOpgenomen = DateTime.Now;

                bestellingItemDAO.PlaatsBestellingItem(besteldeItem);
            }

            bestellingItemDAO.vulTotaalPrijs(bestellingID, list);
            bestellingItemDAO.vulBTW(bestellingID, list);
        }

        //Code Alex
        public void VerwerkHuidigeBestelling(int bestellingID, List<ListviewBestellen> list)
        {
            foreach (ListviewBestellen x in list)
            {
                besteldeItem.BestellingID = bestellingID;
                besteldeItem.Aantal = x.Aantal;
                besteldeItem.Commentaar = x.Opmerking;
                besteldeItem.MenuItemID = x.MenuItemID;
                besteldeItem.Status = "besteld";
                besteldeItem.TijdOpgenomen = DateTime.Now;

                bestellingItemDAO.PlaatsBestellingItem(besteldeItem);
            }
            bestellingItemDAO.vulTotaalPrijs(bestellingID, list);
            bestellingItemDAO.vulBTW(bestellingID, list);
        }

        public void VulAfrekenListview(int bestellingid, ListView list)
        {
            List<Afreken> listMetItems =  bestellingItemDAO.GetAllAfrekenen(bestellingid);

            foreach (Afreken x in listMetItems)
            {
                ListViewItem item = new ListViewItem(x.Naam);
                item.SubItems.Add(x.Aantal.ToString());
                item.SubItems.Add(x.Prijs.ToString());
                list.Items.Add(item);
            }
        }

        public List<BestellingItem> GetAllBestellingItems()
        {
            List<BestellingItem> bestellingItemsList = bestellingItemDAO.GetAll();

            return bestellingItemsList;
        }
    }
}
