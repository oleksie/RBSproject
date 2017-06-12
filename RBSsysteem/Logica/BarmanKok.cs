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
        public List<ListViewItem> Bestellinglist()
        {
            BestellingItemDAO bestelitemconnect = new BestellingItemDAO();
            List<BestellingItem> current = new List<BestellingItem>();
            List<ListViewItem> listview = new List<ListViewItem>();

            ListViewItem item = new ListViewItem();
            string[] arr = new string[6];
            current = bestelitemconnect.GetAll();
            for (int i = 0; i < current.Count; i++)
            {
                arr[0] = null;
                arr[1] = Convert.ToString(current[i].menuitem.Naam);
                arr[2] = Convert.ToString(current[i].aantal);
                arr[3] = Convert.ToString(current[i].commentaar);
                arr[4] = current[i].status;
                arr[5] = Convert.ToString(current[i].tijdOpgenomen);
                item = new ListViewItem(arr);
                listview.Add(item);
            }
            return listview;
        }
    }
}
