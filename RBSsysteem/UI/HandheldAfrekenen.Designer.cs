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
            this.Btn_Afrekenen = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.Btn_AfrekenenTerug = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Lbl_TafelNr = new System.Windows.Forms.Label();
            this.Lbl_PersoonlijkNr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox2.SuspendLayout();
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
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(385, 853);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Pinnen";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(385, 824);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Creditcard";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(385, 882);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(62, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Contant";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // Btn_AfrekenenTerug
            // 
            this.Btn_AfrekenenTerug.Location = new System.Drawing.Point(57, 824);
            this.Btn_AfrekenenTerug.Name = "Btn_AfrekenenTerug";
            this.Btn_AfrekenenTerug.Size = new System.Drawing.Size(128, 79);
            this.Btn_AfrekenenTerug.TabIndex = 7;
            this.Btn_AfrekenenTerug.Text = "Terug";
            this.Btn_AfrekenenTerug.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Lbl_TafelNr);
            this.groupBox2.Controls.Add(this.Lbl_PersoonlijkNr);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.Cornsilk;
            this.groupBox2.Location = new System.Drawing.Point(12, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(243, 76);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // Lbl_TafelNr
            // 
            this.Lbl_TafelNr.AutoSize = true;
            this.Lbl_TafelNr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_TafelNr.Location = new System.Drawing.Point(104, 39);
            this.Lbl_TafelNr.Name = "Lbl_TafelNr";
            this.Lbl_TafelNr.Size = new System.Drawing.Size(35, 13);
            this.Lbl_TafelNr.TabIndex = 3;
            this.Lbl_TafelNr.Text = "label4";
            // 
            // Lbl_PersoonlijkNr
            // 
            this.Lbl_PersoonlijkNr.AutoSize = true;
            this.Lbl_PersoonlijkNr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_PersoonlijkNr.Location = new System.Drawing.Point(141, 18);
            this.Lbl_PersoonlijkNr.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_PersoonlijkNr.Name = "Lbl_PersoonlijkNr";
            this.Lbl_PersoonlijkNr.Size = new System.Drawing.Size(35, 13);
            this.Lbl_PersoonlijkNr.TabIndex = 2;
            this.Lbl_PersoonlijkNr.Text = "label3";
            this.Lbl_PersoonlijkNr.Click += new System.EventHandler(this.Lbl_AfrekenenPersoonNr_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(7, 39);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tafel nummer : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " : Persoonlijk nummer";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(57, 148);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(626, 503);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // HandheldAfrekenen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 1053);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Btn_AfrekenenTerug);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Btn_Afrekenen);
            this.Name = "HandheldAfrekenen";
            this.Text = "HandheldAfrekenen";
            this.Load += new System.EventHandler(this.HandheldAfrekenen_Load);
            this.Controls.SetChildIndex(this.Btn_Afrekenen, 0);
            this.Controls.SetChildIndex(this.radioButton1, 0);
            this.Controls.SetChildIndex(this.radioButton2, 0);
            this.Controls.SetChildIndex(this.radioButton3, 0);
            this.Controls.SetChildIndex(this.Btn_AfrekenenTerug, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.listView1, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Afrekenen;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button Btn_AfrekenenTerug;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Lbl_TafelNr;
        private System.Windows.Forms.Label Lbl_PersoonlijkNr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
    }
}