using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Logica;
using DAL;

namespace UI
{
    public partial class HandheldAfrekenen : BasisHandheld
    {
        private int bestellingID;
        private Medewerker medewerker;
        private int tafelNummer;

        HandheldTafels naarTafelOverzicht = (HandheldTafels)Application.OpenForms["HandheldTafels"];

        BestelItemService bestellingItems = new BestelItemService();
        BestellingService bestelling = new BestellingService();

        public HandheldAfrekenen()
        {
            InitializeComponent();
            // Startpositie voor het scherm meegeven
            this.StartPosition = FormStartPosition.CenterScreen;
            // Eventhandler voor als het scherm wordt gesloten (bijv. door middel van kruisje)
            this.FormClosing += HandheldAfrekenen_FormClosing;

            bestellingItems.VulAfrekenListview(bestellingID, this.listAfreken);
            bestelling.GetTotaalPrijs(bestellingID, this.txt_totaal);
            bestelling.GetBTW(bestellingID, this.txtBTW);
        }

        public HandheldAfrekenen(int bestellingid, Medewerker medewerker, int tafelnr) : this()
        {
            this.bestellingID = bestellingid;
            this.medewerker = medewerker;
            this.tafelNummer = tafelnr;

            lblpnr.Text += medewerker.inlognummer.ToString();
            lbltnr.Text += tafelnr.ToString();
        }

        private void Btn_AfrekenenTerug_Click(object sender, EventArgs e)
        {
            Bestellen bestellen = (Bestellen)Application.OpenForms["Bestellen"];
            this.Hide();
            bestellen.Show();
        }

        private void Btn_Afrekenen_Click(object sender, EventArgs e)
        {
            

        }

        private void HandheldAfrekenen_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            HandheldLogin login = (HandheldLogin)Application.OpenForms["HandheldLogin"];
            Control[] txtInlognummer = login.Controls.Find("txtInlognummer", false);
            txtInlognummer[0].Text = "";
            login.Show();
        }
    }
}
