using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Bestelling
    {
        public int tafelId;
        public int aantal;
        public string naam;
        public double prijs;

        public Bestelling(int aantal, int tafelId,string naam, double prijs)
        {
            this.tafelId = tafelId;
            this.aantal = aantal;
            this.naam = naam;
            this.prijs = prijs;
        }
    }
}