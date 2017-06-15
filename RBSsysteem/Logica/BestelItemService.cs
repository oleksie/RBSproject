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
        public int bestellingID;

        public BestelItemService()
        {

        }

        public void VerwerkNieuweBestelling(ListView list)
        {
            BestellingService bestelling = new BestellingService();

            BestellingDAO huidigeBestelling = new BestellingDAO();
            bestellingID = huidigeBestelling.GetHuidigeBestellingID(bestelling.medewerkerid, bestelling.tafelnr);

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
        }

        public void VerwerkHuidigeBestelling(ListView list)
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
        }
    }
}
