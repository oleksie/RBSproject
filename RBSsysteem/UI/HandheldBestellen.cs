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
    public partial class HandheldBestellen : StyleGuide.BasisHandheldForm
    {
        private int bestellingID;
        private int tafelNummer;
        private Medewerker medewerker;

        List<ListviewBestellen> listVoorDB;

        //Gebruikte UI
        HandheldTafels naarTafelOverzicht = (HandheldTafels)Application.OpenForms["HandheldTafels"];

        //Gebruikte Logica
        BestellingService bestellingService = new BestellingService();
        BestelItemService bestelItemService = new BestelItemService();
        TafelService tafelService = new TafelService();
        MenuItemService menuItemService = new MenuItemService();

        public HandheldBestellen()
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

        public HandheldBestellen(Medewerker medewerker, int tafelNummer) : this()
        {
            this.medewerker = medewerker;
            this.tafelNummer = tafelNummer;
            this.bestellingID = bestellingService.GetBestellingID(medewerker, tafelNummer);

            lblPersoneelsNummer.Text += medewerker.Inlognummer.ToString();
            lblTafelNummer.Text += tafelNummer.ToString();
        }

        //Button voor als je terug wilt naar overzicht
        private void btnTerugNaarOverzicht_Click(object sender, EventArgs e)
        {
            if (this.ListViewtje.Items.Count != 0)
            {
                if ((MessageBox.Show("Weet je zeker dat je wilt verlaten?", "Naar overzicht tafels?",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                     MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                {
                    this.ListViewtje.Items.Clear();
                    this.Hide();
                    naarTafelOverzicht.CreateTafelOverzichtButtons();
                    naarTafelOverzicht.Show();
                }
            }
            else
            {
                this.Hide();
                naarTafelOverzicht.CreateTafelOverzichtButtons();
                naarTafelOverzicht.Show();
            }
        }

        //Laat menuitems buttons zien bij opstart
        private void ShowLunchStart()
        {
            List<Button> btnList = null;
            btnList = menuItemService.MenuItemNaarButton(this.CategorieLunch, this.FLPLunchVoor);
            foreach (Button x in btnList)
            {
                x.Click += new EventHandler(button_Click);
            }
        }

        //Laat menuitems buttons zien bij opstart
        private void ShowDinerStart()
        {
            List<Button> btnList = null;
            btnList = menuItemService.MenuItemNaarButton(this.CategorieDiner, this.FLPDinerVoor);
            foreach (Button x in btnList)
            {
                x.Click += new EventHandler(button_Click);
            }
        }

        //Laat menuitems buttons zien bij opstart
        private void ShowDrankStart()
        {
            List<Button> btnList = null;
            btnList = menuItemService.MenuItemNaarButton(this.CategorieDranken, this.FLPDrankFris);
            foreach (Button x in btnList)
            {
                x.Click += new EventHandler(button_Click);
            }
        }

        //MenuItem button
        public void button_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn = sender as Button;
            HandheldPopUpBestel aantalItem = new HandheldPopUpBestel();
            aantalItem.selectedItemNaam.Text = btn.Tag.ToString();
            aantalItem.ShowDialog();

            if (aantalItem.Ok)
            {
                ListviewBestellen item = menuItemService.MenuItemNaarList(sender as Button, aantalItem.Aantal, aantalItem.Opmerking);
                listVoorDB = menuItemService.MenuItemNaarListView(this.ListViewtje, item);
            }
        }

        private void CategorieLunch_SelectedIndexChanged(Object sender, EventArgs e)
        {
            List<Button> btnList = null;

            if (CategorieLunch.SelectedTab.Name == "HoofdgerechtLunch")
            {
                btnList = menuItemService.MenuItemNaarButton(this.CategorieLunch, this.FLPLunchHoofd);
                foreach (Button x in btnList)
                {
                    x.Click += new EventHandler(button_Click);
                }
            }
            else if (CategorieLunch.SelectedTab.Name == "VoorgerechtLunch")
            {
                btnList = menuItemService.MenuItemNaarButton(this.CategorieLunch, this.FLPLunchVoor);
                foreach (Button x in btnList)
                {
                    x.Click += new EventHandler(button_Click);
                }
            }
            else
            {
                btnList = menuItemService.MenuItemNaarButton(this.CategorieLunch, this.FLPLucnhNa);
                foreach (Button x in btnList)
                {
                    x.Click += new EventHandler(button_Click);
                }
            }
                
        }

        private void CategorieDiner_SelectedIndexChanged(Object sender, EventArgs e)
        {
            List<Button> btnList = null;

            if (CategorieDiner.SelectedTab.Name == "HoofdgerechtDiner")
            {
                btnList = menuItemService.MenuItemNaarButton(this.CategorieDiner, this.FLPDinerHoofd);
                foreach (Button x in btnList)
                {
                    x.Click += new EventHandler(button_Click);
                }
            }
            else if (CategorieDiner.SelectedTab.Name == "VoorgerechtDiner")
            {
                btnList = menuItemService.MenuItemNaarButton(this.CategorieDiner, this.FLPDinerVoor);
                foreach (Button x in btnList)
                {
                    x.Click += new EventHandler(button_Click);
                }
            }
            else if (CategorieDiner.SelectedTab.Name == "TussengerechtDiner")
            {
                btnList = menuItemService.MenuItemNaarButton(this.CategorieDiner, this.FLPDinerTussen);
                foreach (Button x in btnList)
                {
                    x.Click += new EventHandler(button_Click);
                }
            }
            else
            {
                btnList = menuItemService.MenuItemNaarButton(this.CategorieDiner, this.FLPDinerNa);
                foreach (Button x in btnList)
                {
                    x.Click += new EventHandler(button_Click);
                }
            }
        }

        private void CategorieDranken_SelectedIndexChanged(Object sender, EventArgs e)
        {
            List<Button> btnList = null;

            if (CategorieDranken.SelectedTab.Name == "Frisdrank")
            {
                btnList = menuItemService.MenuItemNaarButton(this.CategorieDranken, this.FLPDrankFris);
                foreach (Button x in btnList)
                {
                    x.Click += new EventHandler(button_Click);
                }
            }
            else if (CategorieDranken.SelectedTab.Name == "Bier")
            {
                btnList = menuItemService.MenuItemNaarButton(this.CategorieDranken, this.FLPDrankBier);
                foreach (Button x in btnList)
                {
                    x.Click += new EventHandler(button_Click);
                }
            }
            else if (CategorieDranken.SelectedTab.Name == "Wijn")
            {
                btnList = menuItemService.MenuItemNaarButton(this.CategorieDranken, this.FLPDrankWijn);
                foreach (Button x in btnList)
                {
                    x.Click += new EventHandler(button_Click);
                }
            }
            else if (CategorieDranken.SelectedTab.Name == "Gedistileerd")
            {
                btnList = menuItemService.MenuItemNaarButton(this.CategorieDranken, this.FLPDrankGedis);
                foreach (Button x in btnList)
                {
                    x.Click += new EventHandler(button_Click);
                }
            }
            else
            {
                btnList = menuItemService.MenuItemNaarButton(this.CategorieDranken, this.FLPDrankKoffthee);
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

            List<Model.MenuItem> checkVoorraad = menuItemService.GetVoorraad();
            string naamItemVoorraad = "";
            int aantalItemVoorraad = 0;

            foreach (ListviewBestellen x in listVoorDB)
            {
                foreach (Model.MenuItem y in checkVoorraad)
                {
                    if (x.MenuItemID == y.MenuItemID && y.Voorraad < x.Aantal)
                    {
                        naamItemVoorraad = y.Naam;
                        aantalItemVoorraad = y.Voorraad;
                        genoegOpVoorraad = false;
                        break;
                    }

                    y.Voorraad = y.Voorraad - x.Aantal;
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
                        bestellingService.MaakNieuweBestelling(medewerker, tafelNummer);
                        tafelService.TafelOpBezetZetten(medewerker.Inlognummer, tafelNummer);
                        bestellingID = bestellingService.GetBestellingID(medewerker, tafelNummer);
                        bestelItemService.VerwerkNieuweBestelling(bestellingID, listVoorDB);
                        menuItemService.UpdateVoorraad(listVoorDB);
                        menuItemService.ListVoorListview.Clear();
                    }
                    else
                    {
                        bestelItemService.VerwerkNieuweBestelling(bestellingID, listVoorDB);
                        menuItemService.UpdateVoorraad(listVoorDB);
                        menuItemService.ListVoorListview.Clear();
                    }

                    this.ListViewtje.Items.Clear();
                    this.Hide();
                    naarTafelOverzicht.CreateTafelOverzichtButtons();
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

        //Button om naar de afreken scherm te gaan
        private void btnNaarTafelAfrekenen_Click(object sender, EventArgs e)
        {
            HandheldAfrekenen afrekenen = new HandheldAfrekenen(bestellingID, medewerker, tafelNummer);
            this.Hide();
            afrekenen.Show();
        }

        //Aantal omhoog van geselecteerde item
        private void btnAantalOmhoog_Click(object sender, EventArgs e)
        {
            int aantal = int.Parse(this.ListViewtje.SelectedItems[0].SubItems[1].Text);
            int id = int.Parse(this.ListViewtje.SelectedItems[0].SubItems[4].Text);
            string opmerking = this.ListViewtje.SelectedItems[0].SubItems[2].Text;

            aantal++;

            foreach (ListviewBestellen x in listVoorDB)
            {
                if (id == x.MenuItemID && opmerking.Equals(x.Opmerking))
                {
                    x.Aantal = aantal;
                    break;
                }
            }

            this.ListViewtje.SelectedItems[0].SubItems[1].Text = aantal.ToString();
        }

        //Aantal omlaag van geselecteerde item
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
                if (id == x.MenuItemID && opmerking.Equals(x.Opmerking))
                {
                    x.Aantal = aantal;
                    break;
                }
            }

            this.ListViewtje.SelectedItems[0].SubItems[1].Text = aantal.ToString();
        }

        //De itemattributen worden uit de listview gehaald en gecheckt op aanwezigheid. Dan verwijderd.
        private void btnVerwijderItem_Click(object sender, EventArgs e)
        {
            int aantal = int.Parse(this.ListViewtje.SelectedItems[0].SubItems[1].Text);
            int id = int.Parse(this.ListViewtje.SelectedItems[0].SubItems[4].Text);
            string opmerking = this.ListViewtje.SelectedItems[0].SubItems[2].Text;

            foreach (ListviewBestellen x in listVoorDB)
            {
                if (id == x.MenuItemID && opmerking.Equals(x.Opmerking) && aantal == x.Aantal)
                {
                    listVoorDB.Remove(x);
                    break;
                }
            }

            this.ListViewtje.SelectedItems[0].Remove();
        }

        //Als list item geselecteerd wordt, dan wordt een event in gang gezet en gaan de buttons open
        private void ListViewtje_ItemSelectionChanged(Object sender, EventArgs e)
        {
            btnAantalOmhoog.Enabled = true;
            btnAantalOmlaag.Enabled = true;
            btnVerwijderItem.Enabled = true;
        }
    }
}
