﻿using System;
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
        HandheldTafels naarTafelOverzicht = (HandheldTafels)Application.OpenForms["HandheldTafels"];

        List<ListviewBestellen> listVoorDB;

        public int bestellingID;
        private int tafelNummer;
        private Medewerker medewerker;

        BestellingService bestelling = new BestellingService();
        BestelItemService gebruik = new BestelItemService();
        TafelService tafel = new TafelService();

        public Bestellen()
        {
            InitializeComponent();
            // Startpositie voor het scherm meegeven
            this.StartPosition = FormStartPosition.CenterScreen;
            // Eventhandler voor als het scherm wordt gesloten (bijv. door middel van kruisje)
            this.FormClosing += Bestellen_FormClosing;

            ShowLunchStart();
            ShowDinerStart();
            ShowDrankStart();

            CategorieLunch.SelectedIndexChanged += CategorieLunch_SelectedIndexChanged;
            CategorieDiner.SelectedIndexChanged += CategorieDiner_SelectedIndexChanged;
            CategorieDranken.SelectedIndexChanged += CategorieDranken_SelectedIndexChanged;
            ListViewtje.ItemSelectionChanged += ListViewtje_ItemSelectionChanged;
        }

        public Bestellen(Medewerker medewerker, int tafelNummer) : this()
        {
            this.medewerker = medewerker;
            this.tafelNummer = tafelNummer;
            this.bestellingID = bestelling.GetBestellingID(medewerker, tafelNummer);

            lblPersoneelsNummer.Text += medewerker.Inlognummer.ToString();
            lblTafelNummer.Text += tafelNummer.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.ListViewtje.Items.Count != 0)
            {
                if ((MessageBox.Show("Weet je zeker dat je wilt verlaten?", "Naar overzicht tafels?",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                     MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                {
                    this.ListViewtje.Items.Clear();
                    this.Hide();
                    naarTafelOverzicht.CreateTafelButtons();
                    naarTafelOverzicht.Show();
                    
                }
            }
            else
            {
                this.Hide();
                naarTafelOverzicht.CreateTafelButtons();
                naarTafelOverzicht.Show();
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
            Button btn = new Button();
            btn = sender as Button;
            HandheldPopUpBestel aantalItem = new HandheldPopUpBestel();
            aantalItem.selectedItemNaam.Text = btn.Tag.ToString();
            aantalItem.ShowDialog();

            if (aantalItem.ok)
            {
                
                ListviewBestellen item = actieButton.MenuItemNaarList(sender as Button, aantalItem.aantal, aantalItem.opmerking);
                listVoorDB = actieButton.MenuItemNaarListView(this.ListViewtje, item);

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
            if (this.ListViewtje.Items.Count == 0)
            {
                MessageBox.Show("De huidige bestelling is nog leeg.", "Let op!");
                return;
            }

            bool genoegOpVoorraad = true;

            List<Model.MenuItem> checkVoorraad = actieButton.GetVoorraad();
            string naamItemVoorraad = "";
            int aantalItemVoorraad = 0;

            foreach (ListviewBestellen x in listVoorDB)
            {
                foreach (Model.MenuItem y in checkVoorraad)
                {
                    if (x.id == y.ID && y.Voorraad < x.aantal)
                    {
                        naamItemVoorraad = y.Naam;
                        aantalItemVoorraad = y.Voorraad;
                        genoegOpVoorraad = false;
                        break;
                    }

                    y.Voorraad = y.Voorraad - x.aantal;
                }

                if (genoegOpVoorraad == false)
                {
                    break;
                }
            }

            if (genoegOpVoorraad == true)
            {
                if ((MessageBox.Show("Is de bestelling compleet?", "De bestelling wordt nu opgeslagen.",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                     MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                {
                    if (bestellingID == 0)
                    {
                        bestelling.MaakNieuweBestelling(medewerker, tafelNummer);
                        tafel.TafelOpBezetZetten(medewerker.Inlognummer, tafelNummer);
                        bestellingID = bestelling.GetBestellingID(medewerker, tafelNummer);
                        gebruik.VerwerkNieuweBestelling(bestellingID, listVoorDB);
                        actieButton.UpdateVoorraad(listVoorDB);
                        actieButton.listVoorListview.Clear();
                    }
                    else
                    {
                        gebruik.VerwerkHuidigeBestelling(bestellingID, listVoorDB);
                        actieButton.UpdateVoorraad(listVoorDB);
                        actieButton.listVoorListview.Clear();
                    }

                    this.ListViewtje.Items.Clear();
                    this.Hide();
                    naarTafelOverzicht.CreateTafelButtons();
                    naarTafelOverzicht.Show();
                }
            }
            else
            {
                MessageBox.Show("Er zijn nog maar " + naamItemVoorraad + " " + aantalItemVoorraad + " beschikbaar!", "Let op!");
                return;
            }
            


        }

        private void Bestellen_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            HandheldLogin login = (HandheldLogin)Application.OpenForms["HandheldLogin"];
            Control[] txtInlognummer = login.Controls.Find("txtInlognummer", false);
            txtInlognummer[0].Text = "";
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HandheldAfrekenen afrekenen = new HandheldAfrekenen(bestellingID, medewerker, tafelNummer);
            this.Hide();
            afrekenen.Show();
        }

        private void btnAantalOmhoog_Click(object sender, EventArgs e)
        {
            int aantal = int.Parse(this.ListViewtje.SelectedItems[0].SubItems[1].Text);
            int id = int.Parse(this.ListViewtje.SelectedItems[0].SubItems[4].Text);
            string opmerking = this.ListViewtje.SelectedItems[0].SubItems[2].Text;

            aantal++;

            foreach (ListviewBestellen x in listVoorDB)
            {
                if (id == x.id && opmerking.Equals(x.opmerking))
                {
                    x.aantal = aantal;
                    break;
                }
            }

            this.ListViewtje.SelectedItems[0].SubItems[1].Text = aantal.ToString();
        }

        private void btnAantalOmlaag_Click(object sender, EventArgs e)
        {
            int aantal = int.Parse(this.ListViewtje.SelectedItems[0].SubItems[1].Text);
            int id = int.Parse(this.ListViewtje.SelectedItems[0].SubItems[4].Text);
            string opmerking = this.ListViewtje.SelectedItems[0].SubItems[2].Text;

            if (aantal > 1)
            {
                aantal--;
            }

            foreach (ListviewBestellen x in listVoorDB)
            {
                if (id == x.id && opmerking.Equals(x.opmerking))
                {
                    x.aantal = aantal;
                    break;
                }
            }

            this.ListViewtje.SelectedItems[0].SubItems[1].Text = aantal.ToString();
        }

        private void btnVerwijderItem_Click(object sender, EventArgs e)
        {
            int aantal = int.Parse(this.ListViewtje.SelectedItems[0].SubItems[1].Text);
            int id = int.Parse(this.ListViewtje.SelectedItems[0].SubItems[4].Text);
            string opmerking = this.ListViewtje.SelectedItems[0].SubItems[2].Text;

            foreach (ListviewBestellen x in listVoorDB)
            {
                if (id == x.id && opmerking.Equals(x.opmerking) && aantal == x.aantal)
                {
                    listVoorDB.Remove(x);
                    break;
                }
            }

            this.ListViewtje.SelectedItems[0].Remove();
        }

        private void ListViewtje_ItemSelectionChanged(Object sender, EventArgs e)
        {
            
            btnAantalOmhoog.Enabled = true;
            btnAantalOmlaag.Enabled = true;
            btnVerwijderItem.Enabled = true;
            
        }

        private void Bestellen_Load(object sender, EventArgs e)
        {

        }
    }
}
