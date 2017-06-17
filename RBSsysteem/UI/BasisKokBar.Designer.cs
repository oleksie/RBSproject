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
            this.lv_KokBarman = new System.Windows.Forms.ListView();
            this.btn_Loguit = new System.Windows.Forms.Button();
            this.btn_inBereiding = new System.Windows.Forms.Button();
            this.btn_bereid = new System.Windows.Forms.Button();
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
            this.Lbl_Tijd.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Tijd.TabIndex = 1;
            this.Lbl_Tijd.Click += new System.EventHandler(this.Lbl_Tijd_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(925, 52);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(70, 26);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "label1";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lv_KokBarman
            // 
            this.lv_KokBarman.Location = new System.Drawing.Point(12, 92);
            this.lv_KokBarman.Name = "lv_KokBarman";
            this.lv_KokBarman.Size = new System.Drawing.Size(1330, 629);
            this.lv_KokBarman.TabIndex = 3;
            this.lv_KokBarman.UseCompatibleStateImageBehavior = false;
            this.lv_KokBarman.ItemActivate += new System.EventHandler(this.lv_KokBarman_ItemActivate);
            // 
            // btn_Loguit
            // 
            this.btn_Loguit.Location = new System.Drawing.Point(13, 13);
            this.btn_Loguit.Name = "btn_Loguit";
            this.btn_Loguit.Size = new System.Drawing.Size(90, 73);
            this.btn_Loguit.TabIndex = 4;
            this.btn_Loguit.Text = "Uitloggen";
            this.btn_Loguit.UseVisualStyleBackColor = true;
            this.btn_Loguit.Click += new System.EventHandler(this.btn_Loguit_Click);
            // 
            // btn_inBereiding
            // 
            this.btn_inBereiding.Location = new System.Drawing.Point(1186, 12);
            this.btn_inBereiding.Name = "btn_inBereiding";
            this.btn_inBereiding.Size = new System.Drawing.Size(75, 66);
            this.btn_inBereiding.TabIndex = 6;
            this.btn_inBereiding.Text = "In Bereiding";
            this.btn_inBereiding.UseVisualStyleBackColor = true;
            this.btn_inBereiding.Click += new System.EventHandler(this.btn_inBereiding_Click);
            // 
            // btn_bereid
            // 
            this.btn_bereid.Location = new System.Drawing.Point(1267, 12);
            this.btn_bereid.Name = "btn_bereid";
            this.btn_bereid.Size = new System.Drawing.Size(75, 66);
            this.btn_bereid.TabIndex = 7;
            this.btn_bereid.Text = "Bereid";
            this.btn_bereid.UseVisualStyleBackColor = true;
            this.btn_bereid.Click += new System.EventHandler(this.btn_bereid_Click);
            // 
            // BasisKokBar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.btn_bereid);
            this.Controls.Add(this.btn_inBereiding);
            this.Controls.Add(this.btn_Loguit);
            this.Controls.Add(this.lv_KokBarman);
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
        private System.Windows.Forms.ListView lv_KokBarman;
        private System.Windows.Forms.Button btn_Loguit;
        private System.Windows.Forms.Button btn_inBereiding;
        private System.Windows.Forms.Button btn_bereid;
    }
}