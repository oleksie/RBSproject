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
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoginAccept_Click(object sender, EventArgs e)
        {
            int inlognummer = 0;
            try {
                inlognummer = int.Parse(txtInlognummer.Text);
                lblLoginError.Text = "";
            }
            catch
            {
                lblLoginError.Text = "Foutieve invoer, probeer opnieuw.";
            }

            if (inlognummer != 0)
            {
                try
                {
                    LoginService loginService = new LoginService();
                    Medewerker medewerker = loginService.LoginMedewerker(inlognummer);
                    

                    switch (medewerker.rol)
                    {
                        case (Rol) 1:
                            this.Hide();
                            HandheldTafels handheldTafels = new HandheldTafels(medewerker);
                            handheldTafels.Show();
                            break;
                        case (Rol)2:
                        case (Rol)3:
                            this.Hide();
                            BasisKokBar basisKokBar = new BasisKokBar(medewerker);
                            basisKokBar.Show();
                            break;
                        // rol 4 is voor eigenaar en die wordt niet geïmplementeerd
                        //case (Rol)4:
                        //    break;
                    }
                }
                catch // (Exception exc)
                {
                    lblLoginError.Text = "Inlognummer bestaat niet. \n";
                    //lblLoginError.Text += exc.Message;
                }
            }
        }
    }
}
