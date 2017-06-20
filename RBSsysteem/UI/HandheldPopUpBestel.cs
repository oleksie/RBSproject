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
        private int aantal = 1;
        private string opmerking = "";
        private bool ok = true;

        public HandheldPopUpBestel()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public int Aantal
        {
            get { return aantal;  }
        }

        public string Opmerking
        {
            get { return opmerking; }
        }

        public bool Ok
        {
            get { return ok; }
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
            HandheldBestellen bestelscherm = new HandheldBestellen();
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
