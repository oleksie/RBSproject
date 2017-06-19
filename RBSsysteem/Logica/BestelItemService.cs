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
        BestellingItemDAO itemNaarDB = new BestellingItemDAO();
        MenuItemService getListMetItems = new MenuItemService();

        public BestelItemService()
        {

        }

        public void VerwerkNieuweBestelling(int bestellingID, List<ListviewBestellen> list)
        {
            foreach (ListviewBestellen x in list)
            {
                besteldeItem.bestellingID = bestellingID;
                besteldeItem.aantal = x.aantal;
                besteldeItem.commentaar = x.opmerking;
                besteldeItem.menuitemid = x.id;
                besteldeItem.status = "besteld";
                besteldeItem.tijdOpgenomen = DateTime.Now;

                itemNaarDB.PlaatsBestellingItem(besteldeItem);
            }

            itemNaarDB.vulTotaalPrijs(bestellingID, list);
            itemNaarDB.vulBTW(bestellingID, list);
        }

        public void VerwerkHuidigeBestelling(int bestellingID, List<ListviewBestellen> list)
        {
            foreach (ListviewBestellen x in list)
            {
                besteldeItem.bestellingID = bestellingID;
                besteldeItem.aantal = x.aantal;
                besteldeItem.commentaar = x.opmerking;
                besteldeItem.menuitemid = x.id;
                besteldeItem.status = "besteld";
                besteldeItem.tijdOpgenomen = DateTime.Now;

                itemNaarDB.PlaatsBestellingItem(besteldeItem);
            }
            itemNaarDB.vulTotaalPrijs(bestellingID, list);
            itemNaarDB.vulBTW(bestellingID, list);
        }

        public void VulAfrekenListview(int bestellingid, ListView list)
        {
            List<Afreken> listMetItems =  itemNaarDB.GetAllAfrekenen(bestellingid);

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
            List<BestellingItem> bestellingItemsList = itemNaarDB.GetAll();

            return bestellingItemsList;
        }
    }
}
