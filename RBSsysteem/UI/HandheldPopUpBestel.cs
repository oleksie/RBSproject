using Logica;
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
    public partial class HandheldPopUpBestel : Form
    {
        public int aantal = 1;
        public string opmerking = "";
        public bool ok = true;
        public HandheldPopUpBestel()
        {
            InitializeComponent();
            //this.Btn_HandheldPopUpBestelTerug.Click += Btn_HandheldPopUpBestelTerug_Click;
            //this.Btn_HandheldPopUpBestelOk.Click += Btn_HandheldPopUpBestelOk_Click;
            //this.Btn_HandheldPopUpBestelUp.Click += Btn_HandheldPopUpBestelUp_Click;
            //this.Btn_HandheldPopUpBetselDown.Click += Btn_HandheldPopUpBetselDown_Click;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        public void Btn_HandheldPopUpBestelUp_Click(object sender, EventArgs e)
        {
            int aantalint = int.Parse(this.Txt_HandheldPopUpBetselAantal.Text);
            aantalint++;
            this.Txt_HandheldPopUpBetselAantal.Text = aantalint.ToString();
        }

        private void Btn_HandheldPopUpBetselDown_Click(object sender, EventArgs e)
        {
            int aantalint = int.Parse(this.Txt_HandheldPopUpBetselAantal.Text);

            if (aantalint > 1)
            {
                aantalint--;
                this.Txt_HandheldPopUpBetselAantal.Text = aantalint.ToString();
            }
            
        }

        private void Btn_HandheldPopUpBestelTerug_Click(object sender, EventArgs e)
        {
            ok = false;
            Bestellen bestelscherm = new Bestellen();
            this.Close();
        }

        private void Btn_HandheldPopUpBestelOk_Click(object sender, EventArgs e)
        {
            ok = true;
            aantal = int.Parse(this.Txt_HandheldPopUpBetselAantal.Text);
            opmerking = this.txt_opmerkingen.Text;
            this.Close();
        }
    }
}
