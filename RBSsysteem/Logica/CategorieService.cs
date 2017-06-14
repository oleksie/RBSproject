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
    public class CategorieService
    {
        public CategorieService()
        {

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
    }
}
