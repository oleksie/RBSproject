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
    public partial class HandheldPopUpStatus : Form
    {
        private int tafelId;

        public HandheldPopUpStatus(int statusButtonTafelId)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            tafelId = statusButtonTafelId;

            lvBestelItemsStatus.View = View.Details;
            lvBestelItemsStatus.GridLines = true;
            lvBestelItemsStatus.FullRowSelect = true;
            lvBestelItemsStatus.Font = new Font("Microsoft Sans Serif", 14);
            lvBestelItemsStatus.Columns.Add("Tafel", 55);
            lvBestelItemsStatus.Columns.Add("Item naam", 265);
            lvBestelItemsStatus.Columns.Add("Verstreken tijd", 135);

            foreach (BestellingItem bereidBestelItem in getBestellingItemsForListview())
            {
                ListViewItem lviStatus = new ListViewItem(statusButtonTafelId.ToString());
                lviStatus.SubItems.Add(bereidBestelItem.naam);

                // Tijd berekenen tussen opname van de bestelling en nu en tonen in minuten
                DateTime nu = DateTime.Now;
                TimeSpan tijdVerstreken = nu - bereidBestelItem.tijdOpgenomen;
                lviStatus.SubItems.Add(tijdVerstreken.Minutes.ToString());

                lvBestelItemsStatus.Items.Add(lviStatus);
            }

        }
        

        private List<BestellingItem> getBestellingItemsForListview()
        {
            // Bestelling service aanmaken en alle bestellingen ophalen
            BestellingService bestellingService = new BestellingService();
            List<Bestelling> bestellingen = bestellingService.GetAlleBestellingen();

            // Bestel item service aanmaken en alle bestellingItems ophalen
            BestelItemService bestelItemService = new BestelItemService();
            List<BestellingItem> bestellingItems = bestelItemService.GetAllBestellingItems();

            // List aanmaken waaraan de bestellingItems met status Bereid komen te staan
            List<BestellingItem> bereidBestellingItems = new List<BestellingItem>();

            // Loop door alle bestellingen heen
            foreach (Bestelling bestelling in bestellingen)
            {
                if(bestelling.Betaald == "nee")
                {
                    foreach (BestellingItem bestelItem in bestellingItems)
                    {
                        if (
                            bestelItem.bestellingID == bestelling.Id &&
                            bestelItem.status == "bereid" &&
                            bestelling.TafelId == tafelId
                            )
                        {
                            bereidBestellingItems.Add(bestelItem);
                        }
                    }
                }
            }

            return bereidBestellingItems;
        }

        private void btnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
