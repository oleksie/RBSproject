using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Medewerker
    {
        public int Id { get; private set; }
        public string Naam { get; private set; }
        public int Inlognummer { get; private set; }
        public Rol Rol { get; private set; }

        public Medewerker(int medewerkerId, string naam, int inlognummer, Rol rol)
        {
            this.Id = medewerkerId;
            this.Naam = naam;
            this.Inlognummer = inlognummer;
            this.Rol = rol;
        }
    }
}