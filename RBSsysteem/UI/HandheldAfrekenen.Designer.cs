namespace UI
{
    partial class HandheldAfrekenen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.Btn_Afrekenen = new System.Windows.Forms.Button();
            this.rbPinnen = new System.Windows.Forms.RadioButton();
            this.rbCreditcard = new System.Windows.Forms.RadioButton();
            this.rbContant = new System.Windows.Forms.RadioButton();
            this.Btn_AfrekenenTerug = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbltnr = new System.Windows.Forms.Label();
            this.lblpnr = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_fooi = new System.Windows.Forms.TextBox();
            this.txt_klantBetaalt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_totaal = new System.Windows.Forms.TextBox();
            this.listAfreken = new System.Windows.Forms.ListView();
            this.columnNaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrijs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.txtBTW = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Afrekenen
            // 
            this.Btn_Afrekenen.Location = new System.Drawing.Point(555, 832);
            this.Btn_Afrekenen.Name = "Btn_Afrekenen";
            this.Btn_Afrekenen.Size = new System.Drawing.Size(128, 79);
            this.Btn_Afrekenen.TabIndex = 2;
            this.Btn_Afrekenen.Text = "Afrekenen";
            this.Btn_Afrekenen.UseVisualStyleBackColor = true;
            this.Btn_Afrekenen.Click += new System.EventHandler(this.Btn_Afrekenen_Click);
            // 
            // rbPinnen
            // 
            this.rbPinnen.AutoSize = true;
            this.rbPinnen.Location = new System.Drawing.Point(385, 853);
            this.rbPinnen.Name = "rbPinnen";
            this.rbPinnen.Size = new System.Drawing.Size(58, 17);
            this.rbPinnen.TabIndex = 3;
            this.rbPinnen.TabStop = true;
            this.rbPinnen.Text = "Pinnen";
            this.rbPinnen.UseVisualStyleBackColor = true;
            // 
            // rbCreditcard
            // 
            this.rbCreditcard.AutoSize = true;
            this.rbCreditcard.Location = new System.Drawing.Point(385, 824);
            this.rbCreditcard.Name = "rbCreditcard";
            this.rbCreditcard.Size = new System.Drawing.Size(73, 17);
            this.rbCreditcard.TabIndex = 4;
            this.rbCreditcard.TabStop = true;
            this.rbCreditcard.Text = "Creditcard";
            this.rbCreditcard.UseVisualStyleBackColor = true;
            // 
            // rbContant
            // 
            this.rbContant.AutoSize = true;
            this.rbContant.Location = new System.Drawing.Point(385, 882);
            this.rbContant.Name = "rbContant";
            this.rbContant.Size = new System.Drawing.Size(62, 17);
            this.rbContant.TabIndex = 5;
            this.rbContant.TabStop = true;
            this.rbContant.Text = "Contant";
            this.rbContant.UseVisualStyleBackColor = true;
            // 
            // Btn_AfrekenenTerug
            // 
            this.Btn_AfrekenenTerug.Location = new System.Drawing.Point(57, 824);
            this.Btn_AfrekenenTerug.Name = "Btn_AfrekenenTerug";
            this.Btn_AfrekenenTerug.Size = new System.Drawing.Size(128, 79);
            this.Btn_AfrekenenTerug.TabIndex = 7;
            this.Btn_AfrekenenTerug.Text = "Terug";
            this.Btn_AfrekenenTerug.UseVisualStyleBackColor = true;
            this.Btn_AfrekenenTerug.Click += new System.EventHandler(this.Btn_AfrekenenTerug_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbltnr);
            this.groupBox2.Controls.Add(this.lblpnr);
            this.groupBox2.ForeColor = System.Drawing.Color.Cornsilk;
            this.groupBox2.Location = new System.Drawing.Point(12, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(243, 76);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // lbltnr
            // 
            this.lbltnr.AutoSize = true;
            this.lbltnr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltnr.Location = new System.Drawing.Point(7, 39);
            this.lbltnr.Name = "lbltnr";
            this.lbltnr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbltnr.Size = new System.Drawing.Size(74, 13);
            this.lbltnr.TabIndex = 1;
            this.lbltnr.Text = "Tafelnummer: ";
            // 
            // lblpnr
            // 
            this.lblpnr.AutoSize = true;
            this.lblpnr.ForeColor = System.Drawing.Color.Black;
            this.lblpnr.Location = new System.Drawing.Point(6, 18);
            this.lblpnr.Name = "lblpnr";
            this.lblpnr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblpnr.Size = new System.Drawing.Size(102, 13);
            this.lblpnr.TabIndex = 0;
            this.lblpnr.Text = "Personeelsnummer: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_fooi);
            this.groupBox1.Controls.Add(this.txt_klantBetaalt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_totaal);
            this.groupBox1.Location = new System.Drawing.Point(434, 550);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 225);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // txt_fooi
            // 
            this.txt_fooi.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txt_fooi.Location = new System.Drawing.Point(106, 156);
            this.txt_fooi.Name = "txt_fooi";
            this.txt_fooi.ReadOnly = true;
            this.txt_fooi.Size = new System.Drawing.Size(137, 53);
            this.txt_fooi.TabIndex = 9;
            // 
            // txt_klantBetaalt
            // 
            this.txt_klantBetaalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txt_klantBetaalt.Location = new System.Drawing.Point(106, 88);
            this.txt_klantBetaalt.Name = "txt_klantBetaalt";
            this.txt_klantBetaalt.Size = new System.Drawing.Size(137, 53);
            this.txt_klantBetaalt.TabIndex = 8;
            this.txt_klantBetaalt.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fooi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Klant betaalt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Totaal   ";
            // 
            // txt_totaal
            // 
            this.txt_totaal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txt_totaal.Location = new System.Drawing.Point(106, 19);
            this.txt_totaal.Name = "txt_totaal";
            this.txt_totaal.ReadOnly = true;
            this.txt_totaal.Size = new System.Drawing.Size(137, 53);
            this.txt_totaal.TabIndex = 4;
            // 
            // listAfreken
            // 
            this.listAfreken.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNaam,
            this.columnAantal,
            this.columnPrijs});
            this.listAfreken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listAfreken.GridLines = true;
            this.listAfreken.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listAfreken.Location = new System.Drawing.Point(64, 117);
            this.listAfreken.Name = "listAfreken";
            this.listAfreken.Size = new System.Drawing.Size(619, 411);
            this.listAfreken.TabIndex = 11;
            this.listAfreken.UseCompatibleStateImageBehavior = false;
            this.listAfreken.View = System.Windows.Forms.View.Details;
            // 
            // columnNaam
            // 
            this.columnNaam.Text = "Naam";
            this.columnNaam.Width = 267;
            // 
            // columnAantal
            // 
            this.columnAantal.Text = "Aantal";
            this.columnAantal.Width = 149;
            // 
            // columnPrijs
            // 
            this.columnPrijs.Text = "Prijs";
            this.columnPrijs.Width = 194;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 588);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "BTW";
            // 
            // txtBTW
            // 
            this.txtBTW.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txtBTW.Location = new System.Drawing.Point(278, 569);
            this.txtBTW.Name = "txtBTW";
            this.txtBTW.ReadOnly = true;
            this.txtBTW.Size = new System.Drawing.Size(137, 53);
            this.txtBTW.TabIndex = 10;
            this.txtBTW.TextChanged += new System.EventHandler(this.txtBTW_TextChanged);
            // 
            // HandheldAfrekenen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 985);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listAfreken);
            this.Controls.Add(this.txtBTW);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Btn_AfrekenenTerug);
            this.Controls.Add(this.rbContant);
            this.Controls.Add(this.rbCreditcard);
            this.Controls.Add(this.rbPinnen);
            this.Controls.Add(this.Btn_Afrekenen);
            this.Name = "HandheldAfrekenen";
            this.Text = "Afrekenen";
            this.Controls.SetChildIndex(this.Btn_Afrekenen, 0);
            this.Controls.SetChildIndex(this.rbPinnen, 0);
            this.Controls.SetChildIndex(this.rbCreditcard, 0);
            this.Controls.SetChildIndex(this.rbContant, 0);
            this.Controls.SetChildIndex(this.Btn_AfrekenenTerug, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.txtBTW, 0);
            this.Controls.SetChildIndex(this.listAfreken, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Afrekenen;
        private System.Windows.Forms.RadioButton rbPinnen;
        private System.Windows.Forms.RadioButton rbCreditcard;
        private System.Windows.Forms.RadioButton rbContant;
        private System.Windows.Forms.Button Btn_AfrekenenTerug;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbltnr;
        private System.Windows.Forms.Label lblpnr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_fooi;
        private System.Windows.Forms.TextBox txt_klantBetaalt;
        private System.Windows.Forms.TextBox txt_totaal;
        private System.Windows.Forms.ListView listAfreken;
        private System.Windows.Forms.ColumnHeader columnNaam;
        private System.Windows.Forms.ColumnHeader columnAantal;
        private System.Windows.Forms.ColumnHeader columnPrijs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBTW;
    }
}