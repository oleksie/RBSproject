using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ListviewBestellen
    {
        private string naam;
        private int aantal;
        private string opmerking;
        private double prijs;
        private double itemPrijs;
        private int menuItemID;

        public ListviewBestellen()
        {

        }

        public ListviewBestellen(string naam, int aantal, string opmerking, double prijs, double itemPrijs, int menuItemID)
        {
            this.naam = naam;
            this.aantal = aantal;
            this.opmerking = opmerking;
            this.prijs = prijs;
            this.itemPrijs = itemPrijs;
            this.menuItemID = menuItemID;
        }

        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        public int Aantal
        {
            get { return aantal; }
            set { aantal = value; }
        }

        public string Opmerking
        {
            get { return opmerking; }
            set { opmerking = value; }
        }

        public double Prijs
        {
            get { return prijs; }
            set { prijs = value; }
        }

        public double ItemPrijs
        {
            get { return itemPrijs; }
            set { itemPrijs = value; }
        }

        public int MenuItemID
        {
            get { return menuItemID; }
            set { menuItemID = value; }
        }
    }
}
