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
    public partial class HandheldLogin : BasisHandheld
    {
        public HandheldLogin()
        {
            InitializeComponent();
            // StartPositie van form instellen op CenterScreen
            this.StartPosition = FormStartPosition.CenterScreen;
            // Maximale lengte van txtInlognummer naar 4 limiteren
            txtInlognummer.MaxLength = 4;
        }

        private void LoginAccept_Click(object sender, EventArgs e)
        {
            int inlognummer = 0;

            // Controleer of input naar een integer kan worden geparsed, zo niet geef dan een melding
            try {
                inlognummer = int.Parse(txtInlognummer.Text);
                lblLoginError.Text = string.Empty;
            }
            catch
            {
                lblLoginError.Text = "Foutieve invoer, probeer opnieuw.";
            }

            // Als inlognummer naar een geldige integer waarde is veranderd is deze niet langer 0 en gebeurt
            // het volgende:
            if (inlognummer != 0)
            {
                try // Probeer een medewerker op te halen uit de database via LoginService
                {
                    LoginService loginService = new LoginService();
                    Medewerker medewerker = loginService.LoginMedewerker(inlognummer);

                    // Open aan de hand van de rol van de medewerker het bijbehorende scherm
                    switch (medewerker.Rol)
                    {
                        case (Rol) 1:
                            this.Hide();
                            HandheldTafels handheldTafels = new HandheldTafels(medewerker);
                            handheldTafels.Show();
                            break;
                        case (Rol)2:
                        case (Rol)3:
                            this.Hide();
                            KokBar basisKokBar = new KokBar(medewerker);
                            basisKokBar.Show();
                            break;
                        // rol 4 is voor eigenaar en die wordt niet geïmplementeerd
                        case (Rol)4:
                            lblLoginError.Text = "Eigenaar functionaliteit is \nnog niet geimplementeerd.";
                            break;
                    }
                }
                catch
                {
                    // Als bovenstaande code niet foutloos is afgerond betekend dit automatisch dat het inlognummer
                    // niet bestaat
                    lblLoginError.Text = "Inlognummer bestaat niet.";
                }
            }
        }
    }
}