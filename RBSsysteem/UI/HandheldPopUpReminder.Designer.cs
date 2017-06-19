namespace UI
{
    partial class HandheldPopUpReminder
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
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_HandheldPopUpReminderTerug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tafel is opgenomen door een andere serveerder";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(134, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Reminder";
            // 
            // Btn_HandheldPopUpReminderTerug
            // 
            this.Btn_HandheldPopUpReminderTerug.Location = new System.Drawing.Point(68, 158);
            this.Btn_HandheldPopUpReminderTerug.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_HandheldPopUpReminderTerug.Name = "Btn_HandheldPopUpReminderTerug";
            this.Btn_HandheldPopUpReminderTerug.Size = new System.Drawing.Size(235, 80);
            this.Btn_HandheldPopUpReminderTerug.TabIndex = 5;
            this.Btn_HandheldPopUpReminderTerug.Text = "Terug";
            this.Btn_HandheldPopUpReminderTerug.UseVisualStyleBackColor = true;
            this.Btn_HandheldPopUpReminderTerug.Click += new System.EventHandler(this.Btn_HandheldPopUpReminderTerug_Click);
            // 
            // HandheldPopUpReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 274);
            this.Controls.Add(this.Btn_HandheldPopUpReminderTerug);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HandheldPopUpReminder";
            this.Text = "PopUpReminder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_HandheldPopUpReminderTerug;
    }
}