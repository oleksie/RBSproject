using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MenuKaart
    {
        private int menuKaartID;
        private string naam;

        public MenuKaart()
        {

        }

        public MenuKaart(int menuKaartID, string naam)
        {
            this.menuKaartID = menuKaartID;
            this.naam = naam;
        }

        public int MenuKaartID
        {
            get { return menuKaartID; }
            set { menuKaartID = value; }
        }

        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }
    }
}
