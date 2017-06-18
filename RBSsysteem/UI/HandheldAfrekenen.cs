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
            
            listView1.GridLines = true;
           
            List<Afreken> lijst = new List<Afreken>();
            lijst = AfrekenService.GetAfreken();

          
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textBox2.Text =  - ;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
