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

namespace UI
{
    public partial class Bestellen : StyleGuide.BasisHandheldForm
    {
        public Bestellen()
        {
            InitializeComponent();

            BestellingService hee = new BestellingService();
            hee.MenuItemNaarListView(this.ListViewtje);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dot Net Perls is awesome.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HandheldLogin hee = new HandheldLogin();
            hee.Show();
            this.Hide();
        }

        private void Lunch_Voorgerecht_Steak_Click(object sender, EventArgs e)
        {
            BestellingService hee = new BestellingService();
            hee.MenuKaartNaarListview(ListViewtje);
        }
    }
}
