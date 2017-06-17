using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Model;

namespace UI
{
    public partial class BasisKokBar : Form
    {
        BarmanKok BarKok = new BarmanKok();
        private Medewerker medewerker;
        private string filter;
        public BasisKokBar(Medewerker m)
        {
            List<ListViewItem> bestellinglist = new List<ListViewItem>();
            medewerker = m;
            filter = "in bereiding";
            InitializeComponent();
            lv_KokBarman.View = View.Details;
            lv_KokBarman.GridLines = true;
            lv_KokBarman.FullRowSelect = true;
            lv_KokBarman.CheckBoxes = true;

            lv_KokBarman.Columns.Add("Check", 20);
            lv_KokBarman.Columns.Add("Menu", 200);
            lv_KokBarman.Columns.Add("Aantal", 100);
            lv_KokBarman.Columns.Add("Commentaar", 200);
            lv_KokBarman.Columns.Add("Status", 100);
            lv_KokBarman.Columns.Add("Tijd Opgenomen", 100);
            lv_KokBarman.Columns.Add("Tafel", 100);
            if (medewerker.rol == Rol.Kok)
            { bestellinglist = BarKok.BestellinglistGerechten(filter); }
            else if (medewerker.rol == Rol.Barman)
            { bestellinglist = BarKok.BestellinglistDrank(filter); }
            for (int i = 0; i < bestellinglist.Count; i++)
            {
                lv_KokBarman.Items.Add(bestellinglist[i]);
            }

        }

        private void Lbl_Tijd_Click(object sender, EventArgs e)
        {

        }

        private void BasisKokBar_Load(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToShortTimeString();
        }

        private void lv_KokBarman_ItemActivate(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lv_KokBarman.SelectedItems)
            {
                int lastdeleteditem = Convert.ToInt32(item.SubItems[0].Text);
                BarKok.Updatebestelitem(lastdeleteditem);
                item.Remove();
            }
        }

        private void btn_Loguit_Click(object sender, EventArgs e)
        {
            Form form = lv_KokBarman.FindForm();
            form.Close();
            HandheldLogin login = (HandheldLogin)Application.OpenForms["HandheldLogin"];
            login.Show();
        }

        private void btn_inBereiding_Click(object sender, EventArgs e)
        {
            filter = "in bereiding";
            List<ListViewItem> bestellinglist = new List<ListViewItem>();
            lv_KokBarman.Items.Clear();
            if (medewerker.rol == Rol.Kok)
            { bestellinglist = BarKok.BestellinglistGerechten(filter); }
            else if (medewerker.rol == Rol.Barman)
            { bestellinglist = BarKok.BestellinglistDrank(filter); }
            for (int i = 0; i < bestellinglist.Count; i++)
            {
                lv_KokBarman.Items.Add(bestellinglist[i]);
            }
        }

        private void btn_bereid_Click(object sender, EventArgs e)
        {
            filter = "bereid";
            List<ListViewItem> bestellinglist = new List<ListViewItem>();
            lv_KokBarman.Items.Clear();
            if (medewerker.rol == Rol.Kok)
            { bestellinglist = BarKok.BestellinglistGerechten(filter); }
            else if (medewerker.rol == Rol.Barman)
            { bestellinglist = BarKok.BestellinglistDrank(filter); }
            for (int i = 0; i < bestellinglist.Count; i++)
            {
                lv_KokBarman.Items.Add(bestellinglist[i]);
            }
        }
    }
}