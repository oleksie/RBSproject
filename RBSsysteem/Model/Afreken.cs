using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Afreken
    {

        #region Private Properties

    
        private int aantal;
        private string naam;
        private double prijs;

        #endregion

        #region Constructors

        public Afreken()
        {

        }

        public Afreken(int aantal,  string naam, double prijs)
        {
            this.aantal = aantal;
            this.naam = naam;
            this.prijs = prijs;
        }

        #endregion

        #region Public Properties

       
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

        #endregion

    }
}