﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Categorie
    {
        private int id;
        private int menukaartid;
        private string naam;

        public Categorie()
        {

        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int MenuKaartID
        {
            get { return menukaartid; }
            set { menukaartid = value; }
        }

        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }
    } 
}
