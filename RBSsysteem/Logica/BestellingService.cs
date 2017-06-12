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
    public class BestellingService
    {
        public BestellingService()
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

        public void CategorieItemNaarListview(ListView list)
        {
            CategorieDAO categorie = new CategorieDAO();
            List<Categorie> categorieItems = categorie.GetCategorie();

            foreach (Categorie x in categorieItems)
            {
                ListViewItem CategoriesItems = new ListViewItem(x.ID.ToString());
                CategoriesItems.SubItems.Add(x.MenuKaartID.ToString());
                CategoriesItems.SubItems.Add(x.Naam);
                list.Items.Add(CategoriesItems);
            }
        }

        public void MenuItemNaarListView(ListView list)
        {
            MenuItemDAO menuItem = new MenuItemDAO();
            List<Model.MenuItem> menuItems = menuItem.GetMenuItems();

            foreach (Model.MenuItem x in menuItems)
            {
                ListViewItem MenuItems = new ListViewItem(x.ID.ToString());
                MenuItems.SubItems.Add(x.CategorieID.ToString());
                MenuItems.SubItems.Add(x.Voorraad.ToString());
                MenuItems.SubItems.Add(x.Naam);
                MenuItems.SubItems.Add(x.Prijs.ToString());
                MenuItems.SubItems.Add(x.Omschrijving);
                list.Items.Add(MenuItems);
            }
        }
    }
}
