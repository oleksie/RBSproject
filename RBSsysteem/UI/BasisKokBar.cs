﻿using System;
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
