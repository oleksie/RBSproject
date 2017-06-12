using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MenuItem
    {
        private int id;
        private int voorraad;
        private string naam;
        private double prijs;
        private string omschrijving;
        private int categorieid;


        public MenuItem()
        {

        }

        public int ID
        {
            get { return id; }
            set { id = value; }
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
            get { return categorieid; }
            set { categorieid = value; }
        }
    }
}