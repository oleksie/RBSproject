namespace UI
{
    partial class HandheldPopUpBestel
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
            this.Btn_HandheldPopUpBestelUp = new System.Windows.Forms.Button();
            this.Btn_HandheldPopUpBetselDown = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_HandheldPopUpBetselAantal = new System.Windows.Forms.TextBox();
            this.Btn_HandheldPopUpBestelOk = new System.Windows.Forms.Button();
            this.Btn_HandheldPopUpBestelTerug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_HandheldPopUpBestelUp
            // 
            this.Btn_HandheldPopUpBestelUp.Location = new System.Drawing.Point(207, 57);
            this.Btn_HandheldPopUpBestelUp.Name = "Btn_HandheldPopUpBestelUp";
            this.Btn_HandheldPopUpBestelUp.Size = new System.Drawing.Size(69, 64);
            this.Btn_HandheldPopUpBestelUp.TabIndex = 0;
            this.Btn_HandheldPopUpBestelUp.Text = "Up";
            this.Btn_HandheldPopUpBestelUp.UseVisualStyleBackColor = true;
            // 
            // Btn_HandheldPopUpBetselDown
            // 
            this.Btn_HandheldPopUpBetselDown.Location = new System.Drawing.Point(376, 57);
            this.Btn_HandheldPopUpBetselDown.Name = "Btn_HandheldPopUpBetselDown";
            this.Btn_HandheldPopUpBetselDown.Size = new System.Drawing.Size(69, 64);
            this.Btn_HandheldPopUpBetselDown.TabIndex = 1;
            this.Btn_HandheldPopUpBetselDown.Text = "Down";
            this.Btn_HandheldPopUpBetselDown.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(207, 149);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(238, 96);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aantal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Opmerkingen";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Txt_HandheldPopUpBetselAantal
            // 
            this.Txt_HandheldPopUpBetselAantal.Location = new System.Drawing.Point(117, 78);
            this.Txt_HandheldPopUpBetselAantal.Name = "Txt_HandheldPopUpBetselAantal";
            this.Txt_HandheldPopUpBetselAantal.Size = new System.Drawing.Size(37, 22);
            this.Txt_HandheldPopUpBetselAantal.TabIndex = 5;
            // 
            // Btn_HandheldPopUpBestelOk
            // 
            this.Btn_HandheldPopUpBestelOk.Location = new System.Drawing.Point(334, 261);
            this.Btn_HandheldPopUpBestelOk.Name = "Btn_HandheldPopUpBestelOk";
            this.Btn_HandheldPopUpBestelOk.Size = new System.Drawing.Size(111, 64);
            this.Btn_HandheldPopUpBestelOk.TabIndex = 7;
            this.Btn_HandheldPopUpBestelOk.Text = "Ok";
            this.Btn_HandheldPopUpBestelOk.UseVisualStyleBackColor = true;
            // 
            // Btn_HandheldPopUpBestelTerug
            // 
            this.Btn_HandheldPopUpBestelTerug.Location = new System.Drawing.Point(43, 261);
            this.Btn_HandheldPopUpBestelTerug.Name = "Btn_HandheldPopUpBestelTerug";
            this.Btn_HandheldPopUpBestelTerug.Size = new System.Drawing.Size(111, 64);
            this.Btn_HandheldPopUpBestelTerug.TabIndex = 8;
            this.Btn_HandheldPopUpBestelTerug.Text = "Terug";
            this.Btn_HandheldPopUpBestelTerug.UseVisualStyleBackColor = true;
            // 
            // HandheldPopUpBestel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 337);
            this.Controls.Add(this.Btn_HandheldPopUpBestelTerug);
            this.Controls.Add(this.Btn_HandheldPopUpBestelOk);
            this.Controls.Add(this.Txt_HandheldPopUpBetselAantal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Btn_HandheldPopUpBetselDown);
            this.Controls.Add(this.Btn_HandheldPopUpBestelUp);
            this.Name = "HandheldPopUpBestel";
            this.Text = "HandheldPopUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_HandheldPopUpBestelUp;
        private System.Windows.Forms.Button Btn_HandheldPopUpBetselDown;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_HandheldPopUpBetselAantal;
        private System.Windows.Forms.Button Btn_HandheldPopUpBestelOk;
        private System.Windows.Forms.Button Btn_HandheldPopUpBestelTerug;
    }
}