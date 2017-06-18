namespace UI
{
    partial class HandheldLogin
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
            this.LoginAccept = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLoginError = new System.Windows.Forms.Label();
            this.txtInlognummer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoginAccept
            // 
            this.LoginAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginAccept.Location = new System.Drawing.Point(235, 479);
            this.LoginAccept.Name = "LoginAccept";
            this.LoginAccept.Size = new System.Drawing.Size(273, 105);
            this.LoginAccept.TabIndex = 6;
            this.LoginAccept.Text = "Accept";
            this.LoginAccept.UseVisualStyleBackColor = true;
            this.LoginAccept.Click += new System.EventHandler(this.LoginAccept_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 54);
            this.label1.TabIndex = 5;
            this.label1.Text = "Uw nummer:";
            // 
            // lblLoginError
            // 
            this.lblLoginError.AutoSize = true;
            this.lblLoginError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginError.ForeColor = System.Drawing.Color.Red;
            this.lblLoginError.Location = new System.Drawing.Point(229, 385);
            this.lblLoginError.Name = "lblLoginError";
            this.lblLoginError.Size = new System.Drawing.Size(0, 25);
            this.lblLoginError.TabIndex = 7;
            // 
            // txtInlognummer
            // 
            this.txtInlognummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInlognummer.Location = new System.Drawing.Point(235, 282);
            this.txtInlognummer.Name = "txtInlognummer";
            this.txtInlognummer.Size = new System.Drawing.Size(273, 90);
            this.txtInlognummer.TabIndex = 8;
            // 
            // HandheldLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 977);
            this.Controls.Add(this.txtInlognummer);
            this.Controls.Add(this.lblLoginError);
            this.Controls.Add(this.LoginAccept);
            this.Controls.Add(this.label1);
            this.Name = "HandheldLogin";
            this.Text = "Loginscherm";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.LoginAccept, 0);
            this.Controls.SetChildIndex(this.lblLoginError, 0);
            this.Controls.SetChildIndex(this.txtInlognummer, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginAccept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLoginError;
        private System.Windows.Forms.TextBox txtInlognummer;
    }
}