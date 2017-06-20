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
        public void VerwerkNieuweBestelling(int bestellingID, List<ListviewBestellen> listMetBesteldeItems)
        {
            foreach (ListviewBestellen x in listMetBesteldeItems)
            {
                besteldeItem.BestellingID = bestellingID;
                besteldeItem.Aantal = x.Aantal;
                besteldeItem.Commentaar = x.Opmerking;
                besteldeItem.MenuItemID = x.MenuItemID;
                besteldeItem.Status = "besteld";
                besteldeItem.TijdOpgenomen = DateTime.Now;

                bestellingItemDAO.PlaatsBestellingItem(besteldeItem);
            }

            bestellingItemDAO.vulTotaalPrijs(bestellingID, listMetBesteldeItems);
            bestellingItemDAO.vulBTW(bestellingID, listMetBesteldeItems);
        }

        public void VulAfrekenListview(int bestellingid, ListView list)
        {
            List<Afreken> listMetItems =  bestellingItemDAO.GetAllAfrekenen(bestellingid);

            foreach (Afreken afrekenObject in listMetItems)
            {
                ListViewItem item = new ListViewItem(afrekenObject.Naam);
                item.SubItems.Add(afrekenObject.Aantal.ToString());
                item.SubItems.Add(afrekenObject.Prijs.ToString());
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
