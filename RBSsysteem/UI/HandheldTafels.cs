using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace UI
{
    public partial class HandheldTafels : BasisHandheld
    {
        
        public HandheldTafels()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tafel1_Click(object sender, EventArgs e)
        {

        }

        private void roundButton7_Click(object sender, EventArgs e)
        {

        }

        private void roundButton8_Click(object sender, EventArgs e)
        {

        }

        private void roundButton9_Click(object sender, EventArgs e)
        {

        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void roundButton9_Click_1(object sender, EventArgs e)
        {

        }

        private void HandheldTafels_Load(object sender, EventArgs e)
        {

        }

        private void roundButton6_Click(object sender, EventArgs e)
        {

        }

        private void roundButton10_Click(object sender, EventArgs e)
        {

        }

        private void roundButton3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Btn_TafelsLoguit_Click(object sender, EventArgs e)
        {

        }
    }
    public class RoundButton : Button
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
        }
    }
    
}

