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
        public HandheldAfrekenen()
        {
            InitializeComponent();
            // Startpositie voor het scherm meegeven
            this.StartPosition = FormStartPosition.CenterScreen;
            // Eventhandler voor als het scherm wordt gesloten (bijv. door middel van kruisje)
            this.FormClosing += HandheldAfrekenen_FormClosing;
            //ColumnHeader columnHeader1 = new ColumnHeader();
            //ColumnHeader columnHeader2 = new ColumnHeader();
            //ColumnHeader columnHeader3 = new ColumnHeader();
            //ColumnHeader columnHeader4 = new ColumnHeader();
            //columnHeader1.Text = "Naam";
            //columnHeader2.Text = "Aantal";
            //columnHeader3.Text = "Prijs";
            //columnHeader4.Text = "Wijzig";

            //this.listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            //this.listView1.Columns.AddRange(new ColumnHeader[] { columnHeader2 });
            //this.listView1.Columns.AddRange(new ColumnHeader[] { columnHeader3 });
            //this.listView1.Columns.AddRange(new ColumnHeader[] { columnHeader4 });
            //ListViewItem item1 = new ListViewItem("Something");
            //item1.SubItems.Add("dingern");
            //item1.SubItems.Add("SubItem1b");
            //ListViewItem item2 = new ListViewItem("something2");
            //item2.SubItems.Add("SubItem2a");
            //item2.SubItems.Add("SubItem2b");
            //ListViewItem item3 = new ListViewItem("something3");
            //item3.SubItems.Add("SubItem2a");
            //item3.SubItems.Add("SubItem2b");
            //ListViewItem item4 = new ListViewItem("something4");
            //item4.SubItems.Add("SubItem2a");
            //item4.SubItems.Add("SubItem2b");

            //listView1.Items.AddRange(new ListViewItem[] { item1, item2,item3,item4 });
            //this.listView1.View = View.Details;

            ////ListView listView1 = new ListView();
            ////listView1.View = View.Details;
            listView1.GridLines = true;
            //columnHeader1.Width = 156;
            //columnHeader2.Width = 156;
            //columnHeader3.Width = 156;
            //columnHeader4.Width = 156;
            //BestellingService bestellingService = new BestellingService();
            //List<Bestelling> lijs = bestellingService.GetBestelling();
            List<Afreken> lijst = new List<Afreken>();
            lijst = AfrekenService.GetAfreken();


            //Afreken afreken = new Afreken();
            
            listView1.View = View.Details;
            listView1.Columns.Add("Aantal", 156);
            listView1.Columns.Add("Naam", 156); 
            listView1.Columns.Add("Prijs", 156);
            listView1.Columns.Add("Wijziging", 154);
            ListViewItem leeg = new ListViewItem(" ");
            leeg.SubItems.Add(" ");
            leeg.SubItems.Add(" ");
            leeg.SubItems.Add(" ");
            listView1.Items.Add(leeg);
            foreach (Model.Afreken afreken in lijst)
            {

                ListViewItem item = new ListViewItem(afreken.Aantal.ToString());
                item.SubItems.Add(afreken.Naam);
                item.SubItems.Add(afreken.Prijs.ToString());
                listView1.Items.Add(item);
            }








            /*foreach (Bestelling bestelling in lijst)
            {

                ListViewItem item = new ListViewItem(bestelling.aantal.ToString());
                item.SubItems.Add(bestelling.naam);
                item.SubItems.Add(bestelling.prijs.ToString());
                item.SubItems.Add("wijzig").Tag = bestelling.tafelId;
                listView1.Items.Add(item);
            }*/

            //listView1.FullRowSelect = true;

            ////listView1.Columns.Add("iabsd");
            ////listView1.Columns.Add("asdfasd");
            ////listView1.Columns.Add("asdasda");

        }

        private void ListView1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Lvi_Load(object sender, EventArgs e)
        {

        }

        private void HandheldAfrekenen_Load(object sender, EventArgs e)
        {

        }

        private void Lbl_AfrekenenPersoonNr_Click(object sender, EventArgs e)
        {
          

   
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_AfrekenenTerug_Click(object sender, EventArgs e)
        {
            Bestellen bestellen = new UI.Bestellen();
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
