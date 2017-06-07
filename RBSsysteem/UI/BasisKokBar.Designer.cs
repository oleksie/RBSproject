namespace UI
{
    partial class BasisKokBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasisKokBar));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_Tijd = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1611, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 107);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Lbl_Tijd
            // 
            this.Lbl_Tijd.AutoSize = true;
            this.Lbl_Tijd.Location = new System.Drawing.Point(1065, 125);
            this.Lbl_Tijd.Name = "Lbl_Tijd";
            this.Lbl_Tijd.Size = new System.Drawing.Size(0, 17);
            this.Lbl_Tijd.TabIndex = 1;
            this.Lbl_Tijd.Click += new System.EventHandler(this.Lbl_Tijd_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(960, 52);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(93, 32);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "label1";
            // 
            // BasisKokBar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Lbl_Tijd);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BasisKokBar";
            this.Text = "BasisKokBar";
            this.Load += new System.EventHandler(this.BasisKokBar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lbl_Tijd;
        private System.Windows.Forms.Label Label1;
    }
}