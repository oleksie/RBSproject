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
using Logica;

namespace UI
{
    public partial class HandheldTafels : BasisHandheld
    {
        private Medewerker medewerker;
        private List<Tafel> tafels;

        public HandheldTafels(Medewerker medewerker)
        {
            InitializeComponent();
            // Startpositie voor het scherm meegeven
            this.StartPosition = FormStartPosition.CenterScreen;
            // Eventhandler voor als het scherm wordt gesloten (bijv. door middel van kruisje)
            this.FormClosing += HandheldTafels_FormClosing;

            // Tafels list en medewerker object vullen
            this.medewerker = medewerker;

            lblPersooneelsNummer.Text += medewerker.Inlognummer;

            // Maak tafel buttons aan met de CreateTafelButtons methode, krijgt List<Tafel> tafels mee als parameter
            CreateTafelButtons();
        }

        private void TafelButton_Click(object sender, EventArgs e)
        {
            // Zet de geklikte button in een RoundButton object
            RoundButton clickedRoundButton = (sender as RoundButton);
            int clickedTafelId = (int) clickedRoundButton.Tag;
            Tafel tafel = tafels[clickedTafelId - 1]; // -1 omdat list index begint bij 0 maar tafelnummers bij 1
            
            // Controleer of en door wie een tafel bezet is
            if(tafel.Status == "bezet")
            {
                if(tafel.BezetDoor != medewerker.Inlognummer)
                {
                    HandheldPopUpReminder popUp = new HandheldPopUpReminder();
                    popUp.Show();
                }
                else
                {
                    this.Hide();
                    HandheldBestellen bestellen = new HandheldBestellen(medewerker, clickedTafelId);
                    bestellen.Show();
                }
            }
            else
            {
                this.Hide();
                HandheldBestellen bestellen = new HandheldBestellen(medewerker, clickedTafelId);
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

        public void CreateTafelButtons()
        {
            pnlTafelOverzicht.Controls.Clear();

            TafelService tafelService = new TafelService();
            tafels = tafelService.GetTafels();

            int i = 1;
            // Tafel buttons aanmaken en opmaken
            foreach (Tafel tafel in tafels)
            {
                RoundButton tafelButton = new RoundButton();
                tafelButton.Tag = tafel.Id;
                switch (tafel.Status)
                {
                    case "vrij":
                        tafelButton.BackColor = Color.Green;
                        break;
                    case "bezet":
                        if (tafel.BezetDoor == medewerker.Inlognummer)
                            tafelButton.BackColor = Color.Orange;
                        else
                            tafelButton.BackColor = Color.Red;
                        break;
                }

                // Statusbuttons aanmaken
                Button statusButton = new Button();
                statusButton.Size = new Size(20, 20);
                statusButton.Enabled = true;
                statusButton.Text = "!";
                statusButton.Tag = tafel.Id;
                statusButton.Click += StatusButton_Click;

                // Geef een margin van 70 pixels aan de rechter zijde aan alle tafels met een oneven nummer
                if (i % 2 != 0)
                    statusButton.Margin = new Padding(0, 45, 20, 0);
                else
                    statusButton.Margin = new Padding(0, 45, 0, 0);

                // Button opmaak
                tafelButton.Text = tafel.Id.ToString();
                tafelButton.Font = new Font("Microsoft Sans Serif", 20);

                // Eventhandler voor als er op een button geklikt wordt
                tafelButton.Click += TafelButton_Click;

                pnlTafelOverzicht.Controls.Add(tafelButton);
                pnlTafelOverzicht.Controls.Add(statusButton);

                i++;
            }
        }

        private void StatusButton_Click(object sender, EventArgs e)
        {
            Button clickedStatusButton = (sender as Button);
            int statusButtonTafelId = (int) clickedStatusButton.Tag;
            Tafel tafel = tafels[statusButtonTafelId - 1]; // -1 omdat list index begint bij 0 maar tafelnummers bij 1
            
            // Controleer of en door wie een tafel bezet is
            if (tafel.Status == "bezet")
            {
                if (tafel.BezetDoor != medewerker.Inlognummer)
                {
                    HandheldPopUpReminder popUp = new HandheldPopUpReminder();
                    popUp.Show();
                }
                else
                {
                    HandheldPopUpStatus popUpStatus = new HandheldPopUpStatus(statusButtonTafelId);
                    popUpStatus.Show();
                }
            }
            else
            {
                HandheldPopUpStatus popUpStatus = new HandheldPopUpStatus(statusButtonTafelId);
                popUpStatus.Show();
            }
        }
    }
}