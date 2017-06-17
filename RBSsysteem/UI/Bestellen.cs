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
        MenuItemService actieButton = new MenuItemService();

        public int tafelnr;
        public Bestellen()
        {
            InitializeComponent();

            ShowLunchStart();
            ShowDinerStart();
            ShowDrankStart();

            CategorieLunch.SelectedIndexChanged += CategorieLunch_SelectedIndexChanged;
            CategorieDiner.SelectedIndexChanged += CategorieDiner_SelectedIndexChanged;
            CategorieDranken.SelectedIndexChanged += CategorieDranken_SelectedIndexChanged;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.ListViewtje.Items.Count != 0)
            {
                if ((MessageBox.Show("Weet je zeker dat je wilt verlaten?", "Naar overzicht tafels?",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                     MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                {
                    this.ListViewtje.Clear();
                    HandheldLogin hee1 = new HandheldLogin();
                    hee1.Show();
                    this.Hide();
                }
            }
            
        }

        private void ShowLunchStart()
        {
            MenuItemService hoi = new MenuItemService();
            List<Button> btnList = null;
            btnList = hoi.MenuItemNaarButton(this.CategorieLunch, this.FLPLunchVoor);
            foreach (Button x in btnList)
            {
                x.Click += new EventHandler(button_Click);
            }
        }

        private void ShowDinerStart()
        {
            MenuItemService hoi = new MenuItemService();
            List<Button> btnList = null;
            btnList = hoi.MenuItemNaarButton(this.CategorieDiner, this.FLPDinerVoor);
            foreach (Button x in btnList)
            {
                x.Click += new EventHandler(button_Click);
            }
        }

        private void ShowDrankStart()
        {
            MenuItemService hoi = new MenuItemService();
            List<Button> btnList = null;
            btnList = hoi.MenuItemNaarButton(this.CategorieDranken, this.FLPDrankFris);
            foreach (Button x in btnList)
            {
                x.Click += new EventHandler(button_Click);
            }
        }

        public void button_Click(object sender, EventArgs e)
        {
            HandheldPopUpBestel aantalItem = new HandheldPopUpBestel();
            aantalItem.ShowDialog();

            if (aantalItem.ok)
            {
                
                ListviewBestellen item = actieButton.MenuItemNaarList(sender as Button, aantalItem.aantal, aantalItem.opmerking);

                actieButton.MenuItemNaarListView(this.ListViewtje,item);
            }
        }

        private void CategorieLunch_SelectedIndexChanged(Object sender, EventArgs e)
        {
            MenuItemService hoi = new MenuItemService();
            List<Button> btnList = null;

            if (CategorieLunch.SelectedTab.Name == "HoofdgerechtLunch")
            {
                btnList = hoi.MenuItemNaarButton(this.CategorieLunch, this.FLPLunchHoofd);
                foreach (Button x in btnList)
                {
                    x.Click += new EventHandler(button_Click);
                }
            }
            else if (CategorieLunch.SelectedTab.Name == "VoorgerechtLunch")
            {
                btnList = hoi.MenuItemNaarButton(this.CategorieLunch, this.FLPLunchVoor);
                foreach (Button x in btnList)
                {
                    x.Click += new EventHandler(button_Click);
                }
            }
            else
            {
                btnList = hoi.MenuItemNaarButton(this.CategorieLunch, this.FLPLucnhNa);
                foreach (Button x in btnList)
                {
                    x.Click += new EventHandler(button_Click);
                }
            }
                
        }

        private void CategorieDiner_SelectedIndexChanged(Object sender, EventArgs e)
        {
            MenuItemService hoi = new MenuItemService();
            List<Button> btnList = null;

            if (CategorieDiner.SelectedTab.Name == "HoofdgerechtDiner")
            {
                btnList = hoi.MenuItemNaarButton(this.CategorieDiner, this.FLPDinerHoofd);
                foreach (Button x in btnList)
                {
                    x.Click += new EventHandler(button_Click);
                }
            }
            else if (CategorieDiner.SelectedTab.Name == "VoorgerechtDiner")
            {
                btnList = hoi.MenuItemNaarButton(this.CategorieDiner, this.FLPDinerVoor);
                foreach (Button x in btnList)
                {
                    x.Click += new EventHandler(button_Click);
                }
            }
            else if (CategorieDiner.SelectedTab.Name == "TussengerechtDiner")
            {
                btnList = hoi.MenuItemNaarButton(this.CategorieDiner, this.FLPDinerTussen);
                foreach (Button x in btnList)
                {
                    x.Click += new EventHandler(button_Click);
                }
            }
            else
            {
                btnList = hoi.MenuItemNaarButton(this.CategorieDiner, this.FLPDinerNa);
                foreach (Button x in btnList)
                {
                    x.Click += new EventHandler(button_Click);
                }
            }
        }

        private void CategorieDranken_SelectedIndexChanged(Object sender, EventArgs e)
        {
            MenuItemService hoi = new MenuItemService();
            List<Button> btnList = null;

            if (CategorieDranken.SelectedTab.Name == "Frisdrank")
            {
                btnList = hoi.MenuItemNaarButton(this.CategorieDranken, this.FLPDrankFris);
                foreach (Button x in btnList)
                {
                    x.Click += new EventHandler(button_Click);
                }
            }
            else if (CategorieDranken.SelectedTab.Name == "Bier")
            {
                btnList = hoi.MenuItemNaarButton(this.CategorieDranken, this.FLPDrankBier);
                foreach (Button x in btnList)
                {
                    x.Click += new EventHandler(button_Click);
                }
            }
            else if (CategorieDranken.SelectedTab.Name == "Wijn")
            {
                btnList = hoi.MenuItemNaarButton(this.CategorieDranken, this.FLPDrankWijn);
                foreach (Button x in btnList)
                {
                    x.Click += new EventHandler(button_Click);
                }
            }
            else if (CategorieDranken.SelectedTab.Name == "Gedistileerd")
            {
                btnList = hoi.MenuItemNaarButton(this.CategorieDranken, this.FLPDrankGedis);
                foreach (Button x in btnList)
                {
                    x.Click += new EventHandler(button_Click);
                }
            }
            else
            {
                btnList = hoi.MenuItemNaarButton(this.CategorieDranken, this.FLPDrankKoffthee);
                foreach (Button x in btnList)
                {
                    x.Click += new EventHandler(button_Click);
                }
            }
        }

        private void btn_afrondenHuidig_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("De bestelling wordt nu opgeslagen.", "Is de bestelling compleet?",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                     MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                BestellingService bestelling = new BestellingService();
                BestelItemService gebruik = new BestelItemService();
                if (String.IsNullOrEmpty(gebruik.bestellingID.ToString()))
                {
                    bestelling.MaakNieuweBestelling();
                    gebruik.VerwerkNieuweBestelling(this.ListViewtje);
                }
                else
                {
                    bestelling.MaakNieuweBestelling();
                    gebruik.VerwerkHuidigeBestelling(this.ListViewtje);
                }

                this.ListViewtje.Clear();
            }
        }

        private void Bestellen_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            HandheldLogin login = (HandheldLogin)Application.OpenForms["HandheldLogin"];
            login.Show();
        }
    }
}
