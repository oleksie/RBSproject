using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ListviewBereid
    {
        public string naam;
        public int aantal;
        public DateTime tijdOpgenomen;

        public ListviewBereid()
        {

        }

        public ListviewBereid(string naam, int aantal, DateTime tijdOpgenomen)
        {
            this.naam = naam;
            this.aantal = aantal;
            this.tijdOpgenomen = tijdOpgenomen;
        }
    }
}
