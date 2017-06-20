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
        public int MedewerkerId { get; set; }
        public int TafelId { get; set; }
        public double Totaalprijs { get; set; }
        public string Betaald { get; set; }
        public double Btw { get; set; }
        public double Fooi { get; set; }
        public string BetaalWijze { get; set; }

        public Bestelling()
        {

        }

        #region Alternatieve manier van getters en setters, is dit beter of niet? Lijkt ons overbodig
        //public int Bestelling_id
        //{
        //    get { return Id; }
        //    set { Id = value; }
        //}

        //public string CommentaarKlant
        //{
        //    get { return CommentaarKlant; }
        //    set { CommentaarKlant = value; }
        //}

        //public int Medewerkerid
        //{
        //    get { return MedewerkerID; }
        //    set { MedewerkerID = value; }
        //}

        //public int TafelId
        //{
        //    get { return TafelID; }
        //    set { TafelID = value; }
        //}

        //public double Totaalprijs
        //{
        //    get { return TotaalPrijs; }
        //    set { TotaalPrijs = value; }
        //}

        //public string Betaald
        //{
        //    get { return Betaald; }
        //    set { Betaald = value; }
        //}

        //public double Btw
        //{
        //    get { return Btw; }
        //    set { Btw = value; }
        //}

        //public double Fooi
        //{
        //    get { return Fooi; }
        //    set { Fooi = value; }
        //}

        //public string BetaalWijze
        //{
        //    get { return BetaalWijze; }
        //    set { BetaalWijze = value; }
        //}
        #endregion
    }
}