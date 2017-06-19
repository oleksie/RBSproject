using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BestellingItem
    {
        public int bestelitemID;
        public int bestellingID;
        public int menuitemid;
        public int aantal;
        public string commentaar;
        public string status;
        public DateTime tijdOpgenomen;
        public string naam;

        public BestellingItem()
        {

        }

        /*
         * public int MenuItemID
        {
            get { return menuitemid; }
            set { menuitemid = value; }
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
        */
    }
}