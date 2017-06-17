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
        MenuItemService getListMetItems = new MenuItemService();
        List<ListviewBestellen> listvoorDB;

        public BestelItemService()
        {

        }

        public BestelItemService(List<ListviewBestellen> list)
        {
            this.listvoorDB = list;
        }

        public void VerwerkNieuweBestelling(int bestellingID)
        {
            BestellingItem besteldeItem = new BestellingItem();
            BestellingItemDAO itemNaarDB = new BestellingItemDAO();

            

            foreach (ListviewBestellen x in listvoorDB)
            {
                besteldeItem.bestellingID = bestellingID;
                besteldeItem.aantal = x.aantal;
                besteldeItem.commentaar = x.opmerking;
                besteldeItem.menuitemid = x.id;
                besteldeItem.status = "besteld";
                besteldeItem.tijdOpgenomen = DateTime.Now;

                itemNaarDB.PlaatsBestellingItem(besteldeItem);
            }
        }

        /*public void VerwerkHuidigeBestelling(int bestellingID)
        {
            BestellingItem besteldeItem = new BestellingItem();
            BestellingItemDAO itemNaarDB = new BestellingItemDAO();

            foreach (ListViewItem x in list.Items)
            {
                for (int i = 0; i < x.SubItems.Count; i++)
                {
                    besteldeItem.bestelitemID = bestellingID;
                    besteldeItem.aantal = int.Parse(x.SubItems[1].Text); ;
                    besteldeItem.commentaar = x.SubItems[2].Text;
                    besteldeItem.menuitemid = int.Parse(x.SubItems[4].Text);
                    besteldeItem.status = "besteld";
                    besteldeItem.tijdOpgenomen = DateTime.Now;
                }

                itemNaarDB.PlaatsBestellingItem(besteldeItem);
            }
        }*/
    }
}
