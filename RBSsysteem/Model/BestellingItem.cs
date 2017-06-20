using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BestellingItem
    {
        private int bestelitemID;
        private int bestellingID;
        private int menuitemID;
        private int aantal;
        private string commentaar;
        private string status;
        private DateTime tijdOpgenomen;
        private string naam;

        public BestellingItem()
        {

        }

        public BestellingItem(int bestelItemID, int bestellingID, int menuItemID, int aantal, string commentaar, string status, DateTime tijdOpgenomen)
        {
            this.bestelitemID = bestelItemID;
            this.bestellingID = bestellingID;
            this.menuitemID = menuItemID;
            this.aantal = aantal;
            this.commentaar = commentaar;
            this.status = status;
            this.tijdOpgenomen = tijdOpgenomen;
        }

        public int BestelitemID
        {
            get { return bestelitemID; }
            set { bestelitemID = value; }
        }

        public int BestellingID
        {
            get { return bestellingID; }
            set { bestellingID = value; }
        }

        public int MenuItemID
        {
            get { return menuitemID; }
            set { menuitemID = value; }
        }

        public int Aantal
        {
            get { return aantal; }
            set { aantal = value; }
        }

        public string Commentaar
        {
            get { return commentaar; }
            set { commentaar = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public DateTime TijdOpgenomen
        {
            get { return tijdOpgenomen; }
            set { tijdOpgenomen = DateTime.Now; }
        }

        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }
    }
}