using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Bestelling
    {
        public int tafel_id;
        public int  aantal;
        public string naam;
        public int prijs;
        public Bestelling(int aantal, int tafel_id,string naam, int prijs)
        {
            this.tafel_id = tafel_id;
            this.aantal = aantal;
            this.naam = naam;
            this.prijs = prijs;
          
        }
    }
}