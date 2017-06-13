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
        public List<ListViewItem> Bestellinglist()
        {
            List<BestellingItem> current = new List<BestellingItem>();
            List<Model.MenuItem> currentnaam = new List<Model.MenuItem>();
            List<ListViewItem> listview = new List<ListViewItem>();

            ListViewItem item = new ListViewItem();
            string[] arr = new string[6];
            current = bestelitemconnect.GetAll();
            currentnaam = bestelitemconnect.GetNaam();
            for (int i = 0; i < current.Count; i++)
            {
                    arr[0] = Convert.ToString(current[i].bestelitemID);
                    arr[1] = Convert.ToString(currentnaam[i].Naam);
                    arr[2] = Convert.ToString(current[i].aantal);
                    arr[3] = Convert.ToString(current[i].commentaar);
                    arr[4] = current[i].status;
                    arr[5] = Convert.ToString(current[i].tijdOpgenomen);
                    item = new ListViewItem(arr);
                    listview.Add(item);
                
            }
            return listview;
        }
        public void Updatebestelitem(ListViewItem item)
        {
           string bestelitemid = Convert.ToString(item.GetSubItemAt(0, 0));
           bestelitemconnect.UpdateStatus(Convert.ToInt32(bestelitemid));
        }

    }
}
