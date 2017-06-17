using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Bestelling
    {
        public int bestelling_id;
        public string commentaarKlant;
        public int medewerkerid;
        public int tafelId;
        public double totaalprijs;
        public string betaald;
        public double btw;
        public double fooi;


        public Bestelling( int tafelId, double prijs)
        {
            this.tafelId = tafelId;
            this.totaalprijs = prijs;
        }

        public Bestelling()
        {

        }
    }
}