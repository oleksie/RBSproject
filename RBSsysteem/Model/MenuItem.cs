using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MenuItem
    {
        public int menuItem_id;
        public int voorraad;
        public string naam;
        public float prijs;
        public Categorie categorie;
        public Kaart kaart;

        public MenuItem()
        {

        }
    }
}