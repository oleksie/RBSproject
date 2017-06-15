using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Logica
{
    public class BestellingService
    {
        public BestellingService()
        {

        }

        public List<Bestelling> GetBestelling()
        {
            BestellingDAO bestellingDAO = new BestellingDAO();
            List<Bestelling> bestellingen = bestellingDAO.GetBestelling();

            return bestellingen;
        }
    }
}
