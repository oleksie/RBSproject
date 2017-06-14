using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Model;

namespace Logica
{
    public class BarmanKok
    {

        BestellingItemDAO bestelitemconnect = new BestellingItemDAO();
        public List<ListViewItem> BestellinglistGerechten()
        {
            List<BestellingItem> currentbestelling = new List<BestellingItem>();
            List<Model.MenuItem> currentmenuitem = new List<Model.MenuItem>();
            List<ListViewItem> listview = new List<ListViewItem>();

            ListViewItem item = new ListViewItem();
            string[] arr = new string[6];
            currentbestelling = bestelitemconnect.GetAll();
            currentmenuitem = bestelitemconnect.GetNaamCategorie();
            for (int i = 0; i < currentbestelling.Count; i++)
            {
                if (currentmenuitem[i].CategorieID <= 7)
                {
                    arr[0] = Convert.ToString(currentbestelling[i].bestelitemID);
                    arr[1] = Convert.ToString(currentmenuitem[i].Naam);
                    arr[2] = Convert.ToString(currentbestelling[i].aantal);
                    arr[3] = Convert.ToString(currentbestelling[i].commentaar);
                    arr[4] = currentbestelling[i].status;
                    arr[5] = Convert.ToString(currentbestelling[i].tijdOpgenomen);
                    item = new ListViewItem(arr);
                    listview.Add(item);
                }
                
            }
            return listview;
        }
        public List<ListViewItem> BestellinglistDrank()
        {
            List<BestellingItem> currentbestelling = new List<BestellingItem>();
            List<Model.MenuItem> currentmenuitem = new List<Model.MenuItem>();
            List<ListViewItem> listview = new List<ListViewItem>();

            ListViewItem item = new ListViewItem();
            string[] arr = new string[6];
            currentbestelling = bestelitemconnect.GetAll();
            currentmenuitem = bestelitemconnect.GetNaamCategorie();
            
            for (int i = 0; i < currentbestelling.Count; i++)
            {
                if (currentmenuitem[i].CategorieID >= 8)
                {
                    arr[0] = Convert.ToString(currentbestelling[i].bestelitemID);
                    arr[1] = Convert.ToString(currentmenuitem[i].Naam);
                    arr[2] = Convert.ToString(currentbestelling[i].aantal);
                    arr[3] = Convert.ToString(currentbestelling[i].commentaar);
                    arr[4] = currentbestelling[i].status;
                    arr[5] = Convert.ToString(currentbestelling[i].tijdOpgenomen);
                    item = new ListViewItem(arr);
                    listview.Add(item);
                }
            }
            return listview;
        }
        public void Updatebestelitem(int bestelitemid)
        {
           bestelitemconnect.UpdateStatus(bestelitemid);
        }

    }
}
