using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class BestellingService
    {
        public static ListViewItem ItemNaarListview()
        {
            ListViewItem li = new ListViewItem("steak tartaar");
            li.SubItems.Add("3");
            li.SubItems.Add("Geen");

            return li;
        }
    }
}
