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
        private int bestelling_id;

        #endregion

        #region Constructors

        public Afreken()
        {

        }

        public Afreken(int aantal, string naam, double prijs,int bestelling_id)
        {
            this.aantal = aantal;
            this.naam = naam;
            this.prijs = prijs;
            this.bestelling_id = bestelling_id;
        }

        #endregion

        #region Public Properties

       
        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }
        public int BestellingID
        {
            get { return bestelling_id; }
            set { bestelling_id = value; }
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