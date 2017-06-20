namespace UI
{
    partial class HandheldTafels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HandheldTafels));
            this.lblPersooneelsNummer = new System.Windows.Forms.Label();
            this.Btn_TafelsLoguit = new System.Windows.Forms.Button();
            this.pnlTafelOverzicht = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPersooneelsNummer
            // 
            this.lblPersooneelsNummer.AutoSize = true;
            this.lblPersooneelsNummer.Location = new System.Drawing.Point(12, 12);
            this.lblPersooneelsNummer.Name = "lblPersooneelsNummer";
            this.lblPersooneelsNummer.Size = new System.Drawing.Size(108, 13);
            this.lblPersooneelsNummer.TabIndex = 23;
            this.lblPersooneelsNummer.Text = "Persooneelsnummer: ";
            // 
            // Btn_TafelsLoguit
            // 
            this.Btn_TafelsLoguit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TafelsLoguit.Location = new System.Drawing.Point(83, 863);
            this.Btn_TafelsLoguit.Name = "Btn_TafelsLoguit";
            this.Btn_TafelsLoguit.Size = new System.Drawing.Size(128, 79);
            this.Btn_TafelsLoguit.TabIndex = 24;
            this.Btn_TafelsLoguit.Text = "Loguit";
            this.Btn_TafelsLoguit.UseVisualStyleBackColor = true;
            this.Btn_TafelsLoguit.Click += new System.EventHandler(this.Btn_TafelsLoguit_Click);
            // 
            // pnlTafelOverzicht
            // 
            this.pnlTafelOverzicht.Location = new System.Drawing.Point(288, 266);
            this.pnlTafelOverzicht.Name = "pnlTafelOverzicht";
            this.pnlTafelOverzicht.Size = new System.Drawing.Size(280, 542);
            this.pnlTafelOverzicht.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(236, 828);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 137);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Legenda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "= Tafel is vrij";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "= Tafel is bezet door uzelf";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "= Tafel is bezet door iemand anders";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(10, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "          ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(10, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "          ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "          ";
            // 
            // HandheldTafels
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(752, 985);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlTafelOverzicht);
            this.Controls.Add(this.Btn_TafelsLoguit);
            this.Controls.Add(this.lblPersooneelsNummer);
            this.DoubleBuffered = true;
            this.Name = "HandheldTafels";
            this.Text = "Tafels";
            this.Controls.SetChildIndex(this.lblPersooneelsNummer, 0);
            this.Controls.SetChildIndex(this.Btn_TafelsLoguit, 0);
            this.Controls.SetChildIndex(this.pnlTafelOverzicht, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPersooneelsNummer;
        private System.Windows.Forms.Button Btn_TafelsLoguit;
        private System.Windows.Forms.FlowLayoutPanel pnlTafelOverzicht;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}