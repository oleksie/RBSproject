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
        TafelService tafel = new TafelService();

        public HandheldAfrekenen()
        {
            InitializeComponent();
            // Startpositie voor het scherm meegeven
            this.StartPosition = FormStartPosition.CenterScreen;
            // Eventhandler voor als het scherm wordt gesloten (bijv. door middel van kruisje)
            this.FormClosing += HandheldAfrekenen_FormClosing;

            txt_klantBetaalt.TextChanged += txt_klantBetaalt_TextChanged;

            
        }

        public HandheldAfrekenen(int bestellingid, Medewerker medewerker, int tafelnr) : this()
        {
            this.bestellingID = bestellingid;
            this.medewerker = medewerker;
            this.tafelNummer = tafelnr;

            lblpnr.Text += medewerker.Inlognummer.ToString();
            lbltnr.Text += tafelnr.ToString();

            bestellingItems.VulAfrekenListview(bestellingID, this.listAfreken);
            bestelling.GetTotaalPrijs(bestellingID, this.txt_totaal);
            bestelling.GetBTW(bestellingID, this.txtBTW);
        }

        private void Btn_AfrekenenTerug_Click(object sender, EventArgs e)
        {
            Bestellen bestellen = (Bestellen)Application.OpenForms["Bestellen"];
            this.Hide();
            bestellen.Show();
        }

        private void Btn_Afrekenen_Click(object sender, EventArgs e)
        {
            if (rbContant.Checked || rbCreditcard.Checked || rbPinnen.Checked && double.Parse(txt_klantBetaalt.Text) > 0)
            {
                if ((MessageBox.Show("Is de bestelling compleet?", "De bestelling wordt nu opgeslagen.",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                     MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                {

                    string betaalWijze = "";

                    if (rbContant.Checked)
                    {
                        betaalWijze = rbContant.Text;
                    }
                    else if (rbCreditcard.Checked)
                    {
                        betaalWijze = rbCreditcard.Text;
                    }
                    else
                    {
                        betaalWijze = rbPinnen.Text;
                    }

                    double fooi = double.Parse(this.txt_fooi.Text);
                    string betaald = "ja";
                    int tafelnr = tafelNummer;

                    tafel.UpdateTafel(tafelnr);
                    bestelling.UpdateBestelling(bestellingID, betaalWijze, fooi, betaald);

                    this.Hide();
                    naarTafelOverzicht.CreateTafelOverzichtButtons();
                    naarTafelOverzicht.Show();

                }
                
                
            }
            else
            {
                return;
            }

        }

        private void HandheldAfrekenen_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            HandheldLogin login = (HandheldLogin)Application.OpenForms["HandheldLogin"];
            Control[] txtInlognummer = login.Controls.Find("txtInlognummer", false);
            txtInlognummer[0].Text = "";
            login.Show();
        }

        private void txt_klantBetaalt_TextChanged(object sender, EventArgs e)
        {
            double klantbetaald = 0;
            double ingevoerdePrijs;

            if (double.TryParse(this.txt_klantBetaalt.Text, out ingevoerdePrijs))
            {
                klantbetaald = ingevoerdePrijs;
            }

            double totaalp = double.Parse(this.txt_totaal.Text);
            double fooid = klantbetaald - totaalp;
            this.txt_fooi.Text = fooid.ToString("0.00");
        }

        private void txtBTW_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_totaal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
