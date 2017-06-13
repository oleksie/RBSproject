using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Medewerker
    {
        public int medewerkerId { get; set; }
        public string naam { get; set; }
        public int inlognummer { get; set; }
        public Rol rol { get; set; }//enum

        public Medewerker()
        {

        }
    }
}