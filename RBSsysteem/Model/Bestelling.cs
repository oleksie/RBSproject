using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Bestelling
    {
        private int bestellingID;
        private string commentaarKlant;
        private int medewerkerID;
        private int tafelID;
        private double totaalPrijs;
        private string betaald;
        private double btw;
        private double fooi;
        private string betaalWijze;

        public Bestelling()
        {

        }

        public Bestelling(int tafelId, double prijs)
        {
            this.tafelID = tafelId;
            this.totaalPrijs = prijs;
        }

        public Bestelling(int bestellingID, string commentaarKlant, int medewerkerID, int tafelID, double totaalPrijs, string betaald, double btw, double fooi, string betaalWijze)
        {
            this.bestellingID = bestellingID;
            this.commentaarKlant = commentaarKlant;
            this.medewerkerID = medewerkerID;
            this.TafelId = tafelID;
            this.totaalPrijs = totaalPrijs;
            this.betaald = betaald;
            this.btw = btw;
            this.fooi = fooi;
            this.betaalWijze = betaalWijze;
        }

        public int Bestelling_id
        {
            get { return bestellingID; }
            set { bestellingID = value; }
        }

        public string CommentaarKlant
        {
            get { return commentaarKlant; }
            set { commentaarKlant = value; }
        }

        public int Medewerkerid
        {
            get { return medewerkerID; }
            set { medewerkerID = value; }
        }

        public int TafelId
        {
            get { return tafelID; }
            set { tafelID = value; }
        }

        public double Totaalprijs
        {
            get { return totaalPrijs; }
            set { totaalPrijs = value; }
        }

        public string Betaald
        {
            get { return betaald; }
            set { betaald = value; }
        }

        public double Btw
        {
            get { return btw; }
            set { btw = value; }
        }

        public double Fooi
        {
            get { return fooi; }
            set { fooi = value; }
        }

        public string BetaalWijze
        {
            get { return betaalWijze; }
            set { betaalWijze = value; }
        }
    }
}