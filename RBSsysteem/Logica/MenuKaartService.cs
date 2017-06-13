using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class MenuKaartService
    {
        public MenuKaartService()
        {

        }

        public void MenuKaartNaarListview(ListView list)
        {
            MenukaartDAO kaart = new MenukaartDAO();
            List<MenuKaart> menuKaartItems = kaart.GetMenuKaart();

            foreach (MenuKaart x in menuKaartItems)
            {
                ListViewItem menuItems = new ListViewItem(x.ID.ToString());
                menuItems.SubItems.Add(x.Naam);
                list.Items.Add(menuItems);
            }
        }
    }
}
