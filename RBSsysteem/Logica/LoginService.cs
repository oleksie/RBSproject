using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Model;

namespace Logica
{
    public class LoginService
    {
        public LoginService()
        {

        }

        public Medewerker LoginMedewerker(int inlognummer)
        {
            MedewerkerDAO medewerkerDAO = new MedewerkerDAO();
            Medewerker medewerker = medewerkerDAO.GetMedewerker(inlognummer);

            return medewerker;
        }
    }
}
