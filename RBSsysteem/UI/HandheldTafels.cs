using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Model;

namespace UI
{
    public partial class HandheldTafels : BasisHandheld
    {
        
        public HandheldTafels(Medewerker m)
        {
            Medewerker medewerker = m;
            InitializeComponent();
            lblPersoonlijkNummer.Text += medewerker.inlognummer;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tafel1_Click(object sender, EventArgs e)
        {

        }

        private void roundButton7_Click(object sender, EventArgs e)
        {

        }

        private void roundButton8_Click(object sender, EventArgs e)
        {

        }

        private void roundButton9_Click(object sender, EventArgs e)
        {

        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void roundButton9_Click_1(object sender, EventArgs e)
        {

        }

        private void HandheldTafels_Load(object sender, EventArgs e)
        {

        }

        private void roundButton6_Click(object sender, EventArgs e)
        {

        }

        private void roundButton10_Click(object sender, EventArgs e)
        {

        }

        private void roundButton3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        
        private void Btn_TafelsLoguit_Click(object sender, EventArgs e)
        {
            // vul login met huidig geopend (maar verborgen) login form
            HandheldLogin login = (HandheldLogin) Application.OpenForms["HandheldLogin"];
            login.Show();
            // sluit huidig formulier
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            RoundButton testButton = new RoundButton();
            
            flowLayoutPanel1.Controls.Add(testButton);
        }
    }
}