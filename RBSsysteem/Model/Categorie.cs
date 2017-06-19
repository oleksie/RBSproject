using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Categorie
    {
        private int categorieID;
        private int menukaartID;
        private string naam;

        public Categorie()
        {

        }

        public Categorie(int categorieID, int menukaartID, string naam)
        {
            this.categorieID = categorieID;
            this.menukaartID = menukaartID;
            this.naam = naam;
        }

        public int CategorieID
        {
            get { return categorieID; }
            set { categorieID = value; }
        }

        public int MenuKaartID
        {
            get { return menukaartID; }
            set { menukaartID = value; }
        }

        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }
    } 
}
