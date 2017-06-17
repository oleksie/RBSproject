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
        BestellingDAO bestellingconnect = new BestellingDAO();
        MenuItemDAO menuitemconnect = new MenuItemDAO();
        public List<ListViewItem> BestellinglistGerechten(string filter)
        {
            List<BestellingItem> currentbestelling = new List<BestellingItem>();
            List<Model.MenuItem> currentmenuitem = new List<Model.MenuItem>();
            List<Bestelling> currentbestelingtafel = new List<Bestelling>();
            List<ListViewItem> listview = new List<ListViewItem>();

            ListViewItem item = new ListViewItem();
            string[] arr = new string[7];
            currentbestelling = bestelitemconnect.GetAll();
            currentmenuitem = menuitemconnect.GetNaamCategorie();
            currentbestelingtafel = bestellingconnect.GetTafel();
            for (int i = 0; i < currentbestelling.Count; i++)
            {
                if (currentmenuitem[i].CategorieID <= 7)
                {
                    if (filter == "bereid" && currentbestelling[i].status == "bereid")
                    {
                        arr[0] = Convert.ToString(currentbestelling[i].bestelitemID);
                        arr[1] = Convert.ToString(currentmenuitem[i].Naam);
                        arr[2] = Convert.ToString(currentbestelling[i].aantal);
                        arr[3] = Convert.ToString(currentbestelling[i].commentaar);
                        arr[4] = currentbestelling[i].status;
                        arr[5] = Convert.ToString(currentbestelling[i].tijdOpgenomen);
                        arr[6] = Convert.ToString(currentbestelingtafel[i].tafelId);
                        item = new ListViewItem(arr);
                        listview.Add(item);
                    }
                    else if (filter == "in bereiding" && currentbestelling[i].status == "in bereiding")
                    {
                        arr[0] = Convert.ToString(currentbestelling[i].bestelitemID);
                        arr[1] = Convert.ToString(currentmenuitem[i].Naam);
                        arr[2] = Convert.ToString(currentbestelling[i].aantal);
                        arr[3] = Convert.ToString(currentbestelling[i].commentaar);
                        arr[4] = currentbestelling[i].status;
                        arr[5] = Convert.ToString(currentbestelling[i].tijdOpgenomen);
                        arr[6] = Convert.ToString(currentbestelingtafel[i].tafelId);
                        item = new ListViewItem(arr);
                        listview.Add(item);
                    }
                }

            }
            return listview;
        }
        public List<ListViewItem> BestellinglistDrank(string filter)
        {
            List<BestellingItem> currentbestelling = new List<BestellingItem>();
            List<Model.MenuItem> currentmenuitem = new List<Model.MenuItem>();
            List<Bestelling> currentbestelingtafel = new List<Bestelling>();
            List<ListViewItem> listview = new List<ListViewItem>();

            ListViewItem item = new ListViewItem();
            string[] arr = new string[7];
            currentbestelling = bestelitemconnect.GetAll();
            currentmenuitem = bestelitemconnect.GetNaamCategorie();
            currentbestelingtafel = bestellingconnect.GetTafel();
            for (int i = 0; i < currentbestelling.Count; i++)
            {
                if (currentmenuitem[i].CategorieID >= 8)
                {
                    if (filter == "bereid" && currentbestelling[i].status == "bereid")
                    {
                        arr[0] = Convert.ToString(currentbestelling[i].bestelitemID);
                        arr[1] = Convert.ToString(currentmenuitem[i].Naam);
                        arr[2] = Convert.ToString(currentbestelling[i].aantal);
                        arr[3] = Convert.ToString(currentbestelling[i].commentaar);
                        arr[4] = currentbestelling[i].status;
                        arr[5] = Convert.ToString(currentbestelling[i].tijdOpgenomen);
                        arr[6] = Convert.ToString(currentbestelingtafel[i].tafelId);
                        item = new ListViewItem(arr);
                        listview.Add(item);
                    }
                    else if (filter == "in bereiding" && currentbestelling[i].status == "in bereiding")
                    {
                        arr[0] = Convert.ToString(currentbestelling[i].bestelitemID);
                        arr[1] = Convert.ToString(currentmenuitem[i].Naam);
                        arr[2] = Convert.ToString(currentbestelling[i].aantal);
                        arr[3] = Convert.ToString(currentbestelling[i].commentaar);
                        arr[4] = currentbestelling[i].status;
                        arr[5] = Convert.ToString(currentbestelling[i].tijdOpgenomen);
                        arr[6] = Convert.ToString(currentbestelingtafel[i].tafelId);
                        item = new ListViewItem(arr);
                        listview.Add(item);
                    }
                }
            }
            return listview;
        }
        public void Updatebestelitem(int bestelitemid)
        {
            bestelitemconnect.UpdateStatus(bestelitemid);
        }

        public void Undobestelitem(int bestelitemid)
        {
            bestelitemconnect.UndoStatus(bestelitemid);
        }
    }
}

