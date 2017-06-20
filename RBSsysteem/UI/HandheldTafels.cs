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
        private TafelService tafelService = new TafelService();

        public HandheldTafels(Medewerker medewerker)
        {
            InitializeComponent();
            // Startpositie voor het scherm meegeven
            this.StartPosition = FormStartPosition.CenterScreen;
            // Eventhandler voor als het scherm wordt gesloten (bijv. door middel van klikken op kruisje)
            this.FormClosing += HandheldTafels_FormClosing;

            // Tafels list en medewerker object vullen
            this.medewerker = medewerker;

            // Inlognummer toevoegen aan text property van lblPersoneelsNummer
            lblPersooneelsNummer.Text += medewerker.Inlognummer;

            // Maak tafel buttons aan met de CreateTafelButtons methode
            CreateTafelOverzichtButtons();
        }

        #region Eventhandlers
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

        private void StatusButton_Click(object sender, EventArgs e)
        {
            // Cast het sender object als een Button
            Button clickedStatusButton = (sender as Button);
            // Lees de Tag property van de Button uit en schrijf deze weg als int
            // Waarde hiervan is altijd int want is 'hardcoded' in een dynamische loop
            int statusButtonTafelId = (int) clickedStatusButton.Tag;
            Tafel tafel = tafels[statusButtonTafelId - 1]; // -1 omdat list index begint bij 0 maar tafelnummers bij 1
            
            // Controleer of en door wie een tafel bezet is
            if (tafel.Status == "bezet" && tafel.BezetDoor != medewerker.Inlognummer)
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

        private void Btn_TafelsLoguit_Click(object sender, EventArgs e)
        {
            // sluit huidig formulier
            this.Close();
        }

        private void HandheldTafels_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            // Haal het nog op de achtergrond draaiende Login scherm op en toon deze na de tekst in txtInlognummer
            // te vervangen met een empty string
            HandheldLogin login = (HandheldLogin)Application.OpenForms["HandheldLogin"];
            // Zoek alle controls met de naam txtInlognummer en schrijf deze weg in een Control array
            Control[] txtInlognummer = login.Controls.Find("txtInlognummer", false);
            // Er is maar één Control met die naam dus index 0 is de juiste
            txtInlognummer[0].Text = string.Empty;
            // Toon loginscherm
            login.Show();
        }
        #endregion

        #region Overige methods
        public void CreateTafelOverzichtButtons()
        {
            // Haal alle controls weg uit het pabel
            pnlTafelOverzicht.Controls.Clear();
            // Tafels uit de database ophalen via tafelService
            tafels = tafelService.GetTafels();
            // Zet iterator op 1 voor padding doeleinden
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

                // Button opmaak
                tafelButton.Text = tafel.Id.ToString();
                tafelButton.Font = new Font("Microsoft Sans Serif", 20);

                // Eventhandler voor als er op een tafelButton geklikt wordt
                tafelButton.Click += TafelButton_Click;

                // statusButtons aanmaken
                Button statusButton = new Button();
                statusButton.Size = new Size(20, 20);
                statusButton.Enabled = true;
                statusButton.Text = "!";
                statusButton.Tag = tafel.Id;
                statusButton.Click += StatusButton_Click;

                // Geef een margin op basis van of de statusButton even of oneven is
                if (i % 2 != 0)
                    statusButton.Margin = new Padding(0, 45, 20, 0);
                else
                    statusButton.Margin = new Padding(0, 45, 0, 0);

                pnlTafelOverzicht.Controls.Add(tafelButton);
                pnlTafelOverzicht.Controls.Add(statusButton);

                i++;
            }
        }
        #endregion
    }
}