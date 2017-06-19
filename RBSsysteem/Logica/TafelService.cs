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
    public class TafelService
    {
        private TafelDAO tafelDAO = new TafelDAO();
        public TafelService()
        {

        }

        public List<Tafel> GetTafels()
        {
            List<Tafel> tafels = tafelDAO.GetTafels();

            return tafels;
        }

        public void TafelOpBezetZetten(int inlognummer, int tafelnr)
        {
            tafelDAO.TafelBezetInDB(inlognummer, tafelnr);
        }

        public void UpdateTafel(int tafelnr)
        {
            tafelDAO.UpdateTafel(tafelnr);
        }
    }
}
