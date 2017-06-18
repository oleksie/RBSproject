using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class HandheldPopUpStatus : Form
    {
        public HandheldPopUpStatus()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            lvBestelItemsStatus.View = View.Details;
            lvBestelItemsStatus.GridLines = true;
            lvBestelItemsStatus.FullRowSelect = true;

            lvBestelItemsStatus.Columns.Add("Tafel", 40);
            lvBestelItemsStatus.Columns.Add("Item", 100);
            lvBestelItemsStatus.Columns.Add("Status", 50);
            lvBestelItemsStatus.Columns.Add("Tijd verstreken sinds gereedmelding", 150);


        }

        private void Btn_HandheldPopUpStatusOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
