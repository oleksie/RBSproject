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
        
        public HandheldTafels(Medewerker m, List<Tafel> tafels)
        {
            
            InitializeComponent();
            Medewerker medewerker = m;
            lblPersoonlijkNummer.Text += medewerker.inlognummer;
            int i = 1;

            foreach (Tafel tafel in tafels)
            {
                RoundButton tafelButton = new RoundButton();
                tafelButton.Tag = tafel.tafelId;
                switch (tafel.status)
                {
                    case "vrij":
                        tafelButton.BackColor = Color.Green;
                        break;
                    case "bezet":
                        tafelButton.BackColor = Color.Red;
                        break;
                }

                if (i % 2 != 0)
                {
                    tafelButton.Margin = new Padding(0, 0, 70, 0);
                }

                tafelButton.Click += TafelButton_Click;

                flowLayoutPanel1.Controls.Add(tafelButton);
                i++;
            }
        }

        private void TafelButton_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //int clickedTafelId = sender;
            //Bestellen bestellen = new Bestellen(clickedTafelId);
            //bestellen.Show();
        }

        private void HandheldTafels_Load(object sender, EventArgs e)
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
            
        }

        private void HandheldTafels_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            HandheldLogin login = (HandheldLogin)Application.OpenForms["HandheldLogin"];
            login.Show();
        }
    }
}