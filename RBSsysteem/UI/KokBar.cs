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
    public partial class KokBar : Form
    {
        //dit zijn de private variables die ik nodig heb in deze form
        private BarmanKokServices BarKok = new BarmanKokServices();
        private Medewerker medewerker;
        private string filter;
        private List<ListViewItem> bestellinglist = new List<ListViewItem>();

        public KokBar(Medewerker m)
        {
            //instellen basis waarden
            medewerker = m;
            filter = "besteld";
            InitializeComponent();

            // Startpositie voor het scherm meegeven
            this.StartPosition = FormStartPosition.CenterScreen;

            // Eventhandler voor als het scherm wordt gesloten (bijv. door middel van kruisje)
            this.FormClosing += BasisKokBar_FormClosing;

            //instellingen listform
            lv_KokBarman.View = View.Details;
            lv_KokBarman.GridLines = true;
            lv_KokBarman.FullRowSelect = true;
            lv_KokBarman.CheckBoxes = true;
            lv_KokBarman.Font = new Font("Arial", 20);
            lv_KokBarman.BackColor = Color.LightGreen;

            //instellingen btn's
            btn_bereid.Font = new Font("Arial", 15);
            btn_inBereiding.Font = new Font("Arial", 15);
            btn_Loguit.Font = new Font("Arial", 15);

            //voor de leuk ff lbl vullen met rol
            lbl_medewerkerInfo.Font = new Font("Arial", 20);
            lbl_medewerkerInfo.Text = Convert.ToString(medewerker.Rol);

            //toevoegen colums
            lv_KokBarman.Columns.Add("Check", 20);
            lv_KokBarman.Columns.Add("Menu", 400);
            lv_KokBarman.Columns.Add("Aantal", 100);
            lv_KokBarman.Columns.Add("Commentaar", 345);
            lv_KokBarman.Columns.Add("Status", 100);
            lv_KokBarman.Columns.Add("Tijd Opgenomen", 300);
            lv_KokBarman.Columns.Add("Tafel", 90);

            //selecteert bestelling list op basis van rol
            bestellinglist = BuildListViewItemList(filter);

            // vult listview
            for (int i = 0; i < bestellinglist.Count; i++)
            {
                lv_KokBarman.Items.Add(bestellinglist[i]);
            }

        }

        private List<ListViewItem> BuildListViewItemList(string filter)
        {
            //verplaatst naar correcte plek
            List<BestellingItem> currentbestelling = new List<BestellingItem>();
            List<Model.MenuItem> currentmenuitem = new List<Model.MenuItem>();
            List<Bestelling> currentbestellingtafel = new List<Bestelling>();

            ListViewItem item = new ListViewItem();
            string[] arr = new string[7];

            bestellinglist.Clear();
            currentbestelling = BarKok.BestellingItemList();
            currentmenuitem = BarKok.MenuItemList();
            currentbestellingtafel = BarKok.BestellingList();
            //filter verhaal is flink korter nu rol en categorie if zijn samengevoegd in boolean kok
            for (int i = 0; i < currentbestelling.Count; i++)
            {
                bool kok = BarKok.kok(medewerker, currentmenuitem[i]);

                if (kok & filter == currentbestelling[i].Status)
                {
                    arr = BarKok.bestellingArray(currentbestelling[i], currentmenuitem[i], currentbestellingtafel[i]);
                    item = new ListViewItem(arr);
                    bestellinglist.Add(item);

                }
                if (!kok & filter == currentbestelling[i].Status)
                {
                    arr = BarKok.bestellingArray(currentbestelling[i], currentmenuitem[i], currentbestellingtafel[i]);
                    item = new ListViewItem(arr);
                    bestellinglist.Add(item);

                }
            }
            return bestellinglist;
        }

        private void BasisKokBar_Load(object sender, EventArgs e)
        {
            ////klok start
            Label1.Text = DateTime.Now.ToShortTimeString();

            ////start een timer van 10 seconden waarna de list refresh wordt
            Timer timer = new Timer();
            timer.Interval = (10 * 1000); // 10 secs
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ////////de refresh van list (+tijd refresh)
            Label1.Text = DateTime.Now.ToShortTimeString();
            lv_KokBarman.Items.Clear();
            bestellinglist = BuildListViewItemList(filter);
            for (int i = 0; i < bestellinglist.Count; i++)
            {
                lv_KokBarman.Items.Add(bestellinglist[i]);
            }
        }


        private void Lbl_Tijd_Click(object sender, EventArgs e)
        {
            //refresh klok
            Label1.Text = DateTime.Now.ToShortTimeString();
        }



        private void lv_KokBarman_ItemActivate(object sender, EventArgs e)
        {
            //verander status(last deleted item is artefact-naam van een geschrapte undo button)
            foreach (ListViewItem item in lv_KokBarman.SelectedItems)
            {
                int lastdeleteditem = Convert.ToInt32(item.SubItems[0].Text);
                string deletedItemStatus = Convert.ToString(item.SubItems[4].Text);
                BarKok.Updatebestelitem(lastdeleteditem, deletedItemStatus);
                item.Remove();
            }
        }

        private void btn_Loguit_Click(object sender, EventArgs e)
        {
            //loguit
            Form form = lv_KokBarman.FindForm();
            form.Close();
            HandheldLogin login = (HandheldLogin)Application.OpenForms["HandheldLogin"];
            login.Show();
        }

        private void btn_inBereiding_Click(object sender, EventArgs e)
        {
            //zet kleur terug
            lv_KokBarman.BackColor = Color.LightGreen;

            //zet de filter en geeft deze mee aan de bestellinglist(geeft list op basis van filter) en vult daatna de listview weer
            filter = "besteld";
            List<ListViewItem> bestellinglist = new List<ListViewItem>();
            lv_KokBarman.Items.Clear();
            bestellinglist = BuildListViewItemList(filter);

            for (int i = 0; i < bestellinglist.Count; i++)
            {
                lv_KokBarman.Items.Add(bestellinglist[i]);
            }
        }

        private void btn_bereid_Click(object sender, EventArgs e)
        {
            //zet kleur voor bereid
            lv_KokBarman.BackColor = Color.Tomato;

            //zie methode hierboven
            filter = "bereid";
            List<ListViewItem> bestellinglist = new List<ListViewItem>();
            lv_KokBarman.Items.Clear();
            bestellinglist = BuildListViewItemList(filter);

            for (int i = 0; i < bestellinglist.Count; i++)
            {
                lv_KokBarman.Items.Add(bestellinglist[i]);
            }
        }

        private void BasisKokBar_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            //zorgt dat login terugkomt na sluiten
            HandheldLogin login = (HandheldLogin)Application.OpenForms["HandheldLogin"];
            Control[] txtInlognummer = login.Controls.Find("txtInlognummer", false);
            txtInlognummer[0].Text = "";
            login.Show();
        }
    }
}