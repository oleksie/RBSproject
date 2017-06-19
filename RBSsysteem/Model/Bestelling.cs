using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Bestelling
    {
        public int Id { get; set; }
        public string CommentaarKlant { get; set; }
        public int Medewerkerid { get; set; }
        public int TafelId { get; set; }
        public double Totaalprijs { get; set; }
        public string Betaald { get; set; }
        public double Btw { get; set; }
        public double Fooi { get; set; }
        public string BetaalWijze { get; set; }


        public Bestelling( int tafelId, double prijs)
        {
            this.TafelId = tafelId;
            this.Totaalprijs = prijs;
        }

        public Bestelling()
        {

        }
    }
}