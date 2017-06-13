using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Model;

namespace UI
{
    public partial class Bestellen : StyleGuide.BasisHandheldForm
    {
        public Bestellen()
        {
            InitializeComponent();
            CategorieLunch.SelectedIndexChanged += CategorieLunch_SelectedIndexChanged;
            CategorieDiner.SelectedIndexChanged += CategorieDiner_SelectedIndexChanged;
            CategorieDranken.SelectedIndexChanged += CategorieDranken_SelectedIndexChanged;

            //BestellingService hee = new BestellingService();
            //hee.MenuItemNaarListView(this.ListViewtje);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HandheldLogin hee1 = new HandheldLogin();
            hee1.Show();
            this.Hide();
        }

        private void CategorieLunch_SelectedIndexChanged(Object sender, EventArgs e)
        {
            MenuItemService hoi = new MenuItemService();

            if (CategorieLunch.SelectedTab.Name == "HoofdgerechtLunch")
            {
                hoi.MenuItemNaarButton(this.CategorieLunch, this.FLPLunchHoofd);
            }
            else if (CategorieLunch.SelectedTab.Name == "VoorgerechtLunch")
            {
                hoi.MenuItemNaarButton(this.CategorieLunch, this.FLPLunchVoor);
            }
            else
            {
                hoi.MenuItemNaarButton(this.CategorieLunch, this.FLPLucnhNa);
            }
                
        }

        private void CategorieDiner_SelectedIndexChanged(Object sender, EventArgs e)
        {
            MenuItemService hoi = new MenuItemService();

            if (CategorieDiner.SelectedTab.Name == "HoofdgerechtDiner")
            {
                hoi.MenuItemNaarButton(this.CategorieDiner, this.FLPDinerHoofd);
            }
            else if (CategorieDiner.SelectedTab.Name == "VoorgerechtDiner")
            {
                hoi.MenuItemNaarButton(this.CategorieDiner, this.FLPDinerVoor);
            }
            else if (CategorieDiner.SelectedTab.Name == "TussengerechtDiner")
            {
                hoi.MenuItemNaarButton(this.CategorieDiner, this.FLPDinerTussen);
            }
            else
            {
                hoi.MenuItemNaarButton(this.CategorieDiner, this.FLPDinerNa);
            }
        }

        private void CategorieDranken_SelectedIndexChanged(Object sender, EventArgs e)
        {
            MenuItemService hoi = new MenuItemService();

            if (CategorieDranken.SelectedTab.Name == "Frisdrank")
            {
                hoi.MenuItemNaarButton(this.CategorieDranken, this.FLPDrankFris);
            }
            else if (CategorieDranken.SelectedTab.Name == "Bier")
            {
                hoi.MenuItemNaarButton(this.CategorieDranken, this.FLPDrankBier);
            }
            else if (CategorieDranken.SelectedTab.Name == "Wijn")
            {
                hoi.MenuItemNaarButton(this.CategorieDranken, this.FLPDrankWijn);
            }
            else if (CategorieDranken.SelectedTab.Name == "Gedistileerd")
            {
                hoi.MenuItemNaarButton(this.CategorieDranken, this.FLPDrankGedis);
            }
            else
            {
                hoi.MenuItemNaarButton(this.CategorieDranken, this.FLPDrankKoffthee);
            }
        }
    }
}
