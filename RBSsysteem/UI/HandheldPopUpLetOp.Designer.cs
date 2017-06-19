namespace UI
{
    partial class HandheldPopUpLetOp
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
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_HandheldPopUpLetOPJa = new System.Windows.Forms.Button();
            this.Btn_HandheldPopUpLetOpNee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(143, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Let op!";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "De huidige bestelling is nog leeg";
            // 
            // Btn_HandheldPopUpLetOPJa
            // 
            this.Btn_HandheldPopUpLetOPJa.Location = new System.Drawing.Point(32, 189);
            this.Btn_HandheldPopUpLetOPJa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_HandheldPopUpLetOPJa.Name = "Btn_HandheldPopUpLetOPJa";
            this.Btn_HandheldPopUpLetOPJa.Size = new System.Drawing.Size(83, 52);
            this.Btn_HandheldPopUpLetOPJa.TabIndex = 10;
            this.Btn_HandheldPopUpLetOPJa.Text = "Ja";
            this.Btn_HandheldPopUpLetOPJa.UseVisualStyleBackColor = true;
            this.Btn_HandheldPopUpLetOPJa.Click += new System.EventHandler(this.Btn_HandheldPopUpBestelTerug_Click);
            // 
            // Btn_HandheldPopUpLetOpNee
            // 
            this.Btn_HandheldPopUpLetOpNee.Location = new System.Drawing.Point(250, 189);
            this.Btn_HandheldPopUpLetOpNee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_HandheldPopUpLetOpNee.Name = "Btn_HandheldPopUpLetOpNee";
            this.Btn_HandheldPopUpLetOpNee.Size = new System.Drawing.Size(83, 52);
            this.Btn_HandheldPopUpLetOpNee.TabIndex = 9;
            this.Btn_HandheldPopUpLetOpNee.Text = "Nee";
            this.Btn_HandheldPopUpLetOpNee.UseVisualStyleBackColor = true;
            this.Btn_HandheldPopUpLetOpNee.Click += new System.EventHandler(this.Btn_HandheldPopUpBestelOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Weet u het zeker?";
            // 
            // HandheldPopUpLetOp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 274);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_HandheldPopUpLetOPJa);
            this.Controls.Add(this.Btn_HandheldPopUpLetOpNee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HandheldPopUpLetOp";
            this.Text = "PopUpLetOp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_HandheldPopUpLetOPJa;
        private System.Windows.Forms.Button Btn_HandheldPopUpLetOpNee;
        private System.Windows.Forms.Label label1;
    }
}