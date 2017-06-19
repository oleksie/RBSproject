using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Medewerker
    {
        private int medewerkerID { get; set; }
        private string naam { get; set; }
        private int inlogNummer { get; set; }
        private Rol rol { get; set; }//enum

        public Medewerker()
        {

        }

        public Medewerker(int medewerkerID, string naam, int inlogNummer, Rol rol)
        {
            this.medewerkerID = medewerkerID;
            this.naam = naam;
            this.inlogNummer = inlogNummer;
            this.rol = rol;
        }
    }
}