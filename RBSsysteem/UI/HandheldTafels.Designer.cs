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
            this.lblPersoonlijkNummer = new System.Windows.Forms.Label();
            this.Btn_TafelsLoguit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            this.FormClosing += HandheldTafels_FormClosing;
            // 
            // lblPersoonlijkNummer
            // 
            this.lblPersoonlijkNummer.AutoSize = true;
            this.lblPersoonlijkNummer.Location = new System.Drawing.Point(12, 12);
            this.lblPersoonlijkNummer.Name = "lblPersoonlijkNummer";
            this.lblPersoonlijkNummer.Size = new System.Drawing.Size(104, 13);
            this.lblPersoonlijkNummer.TabIndex = 23;
            this.lblPersoonlijkNummer.Text = "Persoonlijk nummer: ";
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(288, 266);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(280, 520);
            this.flowLayoutPanel1.TabIndex = 25;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // HandheldTafels
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(750, 977);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Btn_TafelsLoguit);
            this.Controls.Add(this.lblPersoonlijkNummer);
            this.DoubleBuffered = true;
            this.Name = "HandheldTafels";
            this.Text = "HandheldTafels";
            this.Load += new System.EventHandler(this.HandheldTafels_Load);
            this.Controls.SetChildIndex(this.lblPersoonlijkNummer, 0);
            this.Controls.SetChildIndex(this.Btn_TafelsLoguit, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPersoonlijkNummer;
        private System.Windows.Forms.Button Btn_TafelsLoguit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}