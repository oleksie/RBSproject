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
    public partial class Bestellen : StyleGuide.BasisHandheldForm
    {
        public Bestellen()
        {
            InitializeComponent();
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

        private void Bestellen_Load(object sender, EventArgs e)
        {

        }
    }
}
