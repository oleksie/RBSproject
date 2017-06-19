using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Afreken
    {
        private int aantal;
        private string naam;
        private double prijs;

        public Afreken()
        {

        }

        public Afreken(int aantal, string naam, double prijs)
        {
            this.aantal = aantal;
            this.naam = naam;
            this.prijs = prijs;
        }

        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        public double Prijs
        {
            get { return prijs; }
            set { prijs = value; }
        }

        public int Aantal
        {
            get { return aantal; }
            set { aantal = value; }
        }
    }
}