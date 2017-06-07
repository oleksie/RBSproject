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
            this.label2.Location = new System.Drawing.Point(22, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tafel word opgenomen door een andere serveerder";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(178, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Reminder";
            // 
            // Btn_HandheldPopUpReminderTerug
            // 
            this.Btn_HandheldPopUpReminderTerug.Location = new System.Drawing.Point(91, 195);
            this.Btn_HandheldPopUpReminderTerug.Name = "Btn_HandheldPopUpReminderTerug";
            this.Btn_HandheldPopUpReminderTerug.Size = new System.Drawing.Size(313, 98);
            this.Btn_HandheldPopUpReminderTerug.TabIndex = 5;
            this.Btn_HandheldPopUpReminderTerug.Text = "Terug";
            this.Btn_HandheldPopUpReminderTerug.UseVisualStyleBackColor = true;
            // 
            // HandheldPopUpReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 337);
            this.Controls.Add(this.Btn_HandheldPopUpReminderTerug);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Name = "HandheldPopUpReminder";
            this.Text = "HandheldPopUpReminder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_HandheldPopUpReminderTerug;
    }
}