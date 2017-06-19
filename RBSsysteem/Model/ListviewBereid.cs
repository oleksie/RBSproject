using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ListviewBereid
    {
        private string naam;
        private int aantal;
        private DateTime tijdOpgenomen;

        public ListviewBereid()
        {

        }

        public ListviewBereid(string naam, int aantal, DateTime tijdOpgenomen)
        {
            this.naam = naam;
            this.aantal = aantal;
            this.tijdOpgenomen = tijdOpgenomen;
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

        public DateTime TijdOpgenomen
        {
            get { return tijdOpgenomen; }
            set { tijdOpgenomen = value; }
        }
    }
}
