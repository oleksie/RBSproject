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
        private Medewerker medewerker;
        public List<Tafel> tafels;
        public HandheldTafels()
        {

        }

        public HandheldTafels(Medewerker medewerker, List<Tafel> tafels)
        {
            InitializeComponent();
            // Startpositie voor het scherm meegeven
            this.StartPosition = FormStartPosition.CenterScreen;
            // Eventhandler voor als het scherm wordt gesloten (bijv. door middel van kruisje)
            this.FormClosing += HandheldTafels_FormClosing;

            // Tafels list en medewerker object vullen
            this.tafels = tafels;
            this.medewerker = medewerker;

            lblPersooneelsNummer.Text += medewerker.inlognummer;

            // Maak tafel buttons aan met de CreateTafelButtons methode, krijgt List<Tafel> tafels mee als parameter
            CreateTafelButtons(tafels);
        }

        private void TafelButton_Click(object sender, EventArgs e)
        {
            RoundButton clickedRoundButton = (sender as RoundButton);
            int clickedTafelId = (int)clickedRoundButton.Tag;
            Tafel tafel = tafels[clickedTafelId - 1];
            
            if(tafel.status == "bezet")
            {
                if(tafel.bezetDoor != medewerker.inlognummer)
                {
                    HandheldPopUpReminder popUp = new HandheldPopUpReminder();
                    popUp.Show();
                }
                else
                {
                    this.Hide();
                    Bestellen bestellen = new Bestellen(medewerker, clickedTafelId);
                    bestellen.Show();
                }
            }
            else
            {
                this.Hide();
                Bestellen bestellen = new Bestellen(medewerker, clickedTafelId);
                bestellen.Show();
            }
        }
        
        private void Btn_TafelsLoguit_Click(object sender, EventArgs e)
        {
            // sluit huidig formulier
            this.Close();
        }

        private void HandheldTafels_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            HandheldLogin login = (HandheldLogin)Application.OpenForms["HandheldLogin"];
            Control[] txtInlognummer = login.Controls.Find("txtInlognummer", false);
            txtInlognummer[0].Text = "";
            login.Show();
        }

        public void CreateTafelButtons(List<Tafel> tafels)
        {
            pnlTafelOverzicht.Controls.Clear();
            int i = 1;
            // Tafel buttons aanmaken en opmaken
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
                        if (tafel.bezetDoor == medewerker.inlognummer)
                            tafelButton.BackColor = Color.Orange;
                        else
                            tafelButton.BackColor = Color.Red;
                        break;
                }

                if (i % 2 != 0)
                {
                    tafelButton.Margin = new Padding(0, 0, 70, 0);
                }

                tafelButton.Text = tafel.tafelId.ToString();
                tafelButton.Font = new Font("Microsoft Sans Serif", 20);
                tafelButton.Click += TafelButton_Click;

                pnlTafelOverzicht.Controls.Add(tafelButton);
                i++;
            }
        }
    }
}