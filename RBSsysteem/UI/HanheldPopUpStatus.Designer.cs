namespace UI
{
    partial class HanheldPopUpStatus
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
            this.Btn_HandheldPopUpStatusOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_HandheldPopUpStatusOk
            // 
            this.Btn_HandheldPopUpStatusOk.Location = new System.Drawing.Point(192, 220);
            this.Btn_HandheldPopUpStatusOk.Name = "Btn_HandheldPopUpStatusOk";
            this.Btn_HandheldPopUpStatusOk.Size = new System.Drawing.Size(111, 64);
            this.Btn_HandheldPopUpStatusOk.TabIndex = 10;
            this.Btn_HandheldPopUpStatusOk.Text = "Ok";
            this.Btn_HandheldPopUpStatusOk.UseVisualStyleBackColor = true;
            // 
            // HanheldPopUpStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 337);
            this.Controls.Add(this.Btn_HandheldPopUpStatusOk);
            this.Name = "HanheldPopUpStatus";
            this.Text = "HanheldPopUpStatus";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_HandheldPopUpStatusOk;
    }
}