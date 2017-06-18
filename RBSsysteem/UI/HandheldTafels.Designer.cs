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
            // HandheldTafels
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(750, 977);
            this.Controls.Add(this.pnlTafelOverzicht);
            this.Controls.Add(this.Btn_TafelsLoguit);
            this.Controls.Add(this.lblPersooneelsNummer);
            this.DoubleBuffered = true;
            this.Name = "HandheldTafels";
            this.Text = "HandheldTafels";
            this.Controls.SetChildIndex(this.lblPersooneelsNummer, 0);
            this.Controls.SetChildIndex(this.Btn_TafelsLoguit, 0);
            this.Controls.SetChildIndex(this.pnlTafelOverzicht, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void HandheldTafels_FormClosing1(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label lblPersooneelsNummer;
        private System.Windows.Forms.Button Btn_TafelsLoguit;
        private System.Windows.Forms.FlowLayoutPanel pnlTafelOverzicht;
    }
}