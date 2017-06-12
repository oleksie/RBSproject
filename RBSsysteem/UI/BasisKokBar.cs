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
    public partial class BasisKokBar : Form
    {
        public BasisKokBar()
        {
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
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void Lbl_Tijd_Click(object sender, EventArgs e)
        {
         
        }

        private void BasisKokBar_Load(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
