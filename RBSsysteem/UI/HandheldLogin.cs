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
                lblLoginError.Text = "U heeft een foutieve input gegeven.";
            }

            if (inlognummer != 0)
            {
                try
                {
                    LoginService loginService = new LoginService();
                    Medewerker medewerker = loginService.LoginMedewerker(inlognummer);
                    lblLoginError.Text = medewerker.naam;
                    switch (medewerker.rol)
                    {
                        case (Rol) 1:
                            HandheldTafels handheldTafels = new HandheldTafels(medewerker);
                            handheldTafels.Show();
                            break;
                    }
                }
                catch
                {
                    lblLoginError.Text = "Inlognummer bestaat niet.";
                }
            }
        }
    }
}
