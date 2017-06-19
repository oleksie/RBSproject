using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MenuItem
    {
        private int menuItemID;
        private int voorraad;
        private string naam;
        private double prijs;
        private string omschrijving;
        private int categorieID;


        public MenuItem()
        {

        }

        public MenuItem(int menuItemID, int voorraad, string naam, double prijs, string omschrijving, int categorieID)
        {
            this.menuItemID = menuItemID;
            this.voorraad = voorraad;
            this.naam = naam;
            this.prijs = prijs;
            this.omschrijving = omschrijving;
            this.categorieID = categorieID;
        }

        public int MenuItemID
        {
            get { return menuItemID; }
            set { menuItemID = value; }
        }

        public int Voorraad
        {
            get { return voorraad; }
            set { voorraad = value; }
        }

        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        public double Prijs
        {
            get { return prijs; }
            set { prijs = value; }
        }

        public string Omschrijving
        {
            get { return omschrijving; }
            set { omschrijving = value; }
        }

        public int CategorieID
        {
            get { return categorieID; }
            set { categorieID = value; }
        }
    }
}