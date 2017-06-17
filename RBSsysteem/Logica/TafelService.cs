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
        public TafelService()
        {

        }

        public List<Tafel> GetTafels()
        {
            TafelDAO tafelDAO = new TafelDAO();
            List<Tafel> tafels = tafelDAO.GetTafels();

            return tafels;
        }

        public void TafelOpBezetZetten(int tafelnr)
        {
            TafelDAO tafelDAO = new TafelDAO();
            tafelDAO.TafelBezetInDB(tafelnr);
        }
    }
}
