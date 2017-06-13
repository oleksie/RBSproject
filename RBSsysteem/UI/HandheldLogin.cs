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
                LoginService loginService = new LoginService();
                Medewerker medewerker = loginService.LoginMedewerker(inlognummer);

                if (medewerker.medewerkerId > 0)
                    lblLoginError.Text = "Yay";
                else
                    lblLoginError.Text = "Nay";
            }
        }
    }
}
