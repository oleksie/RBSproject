namespace UI
{
    partial class HandheldPopUpStatus
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
            this.lvBestelItemsStatus = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_HandheldPopUpStatusOk
            // 
            this.Btn_HandheldPopUpStatusOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_HandheldPopUpStatusOk.Location = new System.Drawing.Point(306, 205);
            this.Btn_HandheldPopUpStatusOk.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_HandheldPopUpStatusOk.Name = "Btn_HandheldPopUpStatusOk";
            this.Btn_HandheldPopUpStatusOk.Size = new System.Drawing.Size(120, 50);
            this.Btn_HandheldPopUpStatusOk.TabIndex = 10;
            this.Btn_HandheldPopUpStatusOk.Text = "Sluiten";
            this.Btn_HandheldPopUpStatusOk.UseVisualStyleBackColor = true;
            // 
            // lvBestelItemsStatus
            // 
            this.lvBestelItemsStatus.Location = new System.Drawing.Point(12, 45);
            this.lvBestelItemsStatus.Name = "lvBestelItemsStatus";
            this.lvBestelItemsStatus.Size = new System.Drawing.Size(460, 248);
            this.lvBestelItemsStatus.TabIndex = 11;
            this.lvBestelItemsStatus.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "De volgende bestelde items zijn gereed:";
            // 
            // btnSluiten
            // 
            this.btnSluiten.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSluiten.Location = new System.Drawing.Point(140, 300);
            this.btnSluiten.Name = "btnSluiten";
            this.btnSluiten.Size = new System.Drawing.Size(200, 50);
            this.btnSluiten.TabIndex = 13;
            this.btnSluiten.Text = "Sluiten";
            this.btnSluiten.UseVisualStyleBackColor = true;
            this.btnSluiten.Click += new System.EventHandler(this.btnSluiten_Click);
            // 
            // HandheldPopUpStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.btnSluiten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvBestelItemsStatus);
            this.Controls.Add(this.Btn_HandheldPopUpStatusOk);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HandheldPopUpStatus";
            this.Text = "HanheldPopUpStatus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_HandheldPopUpStatusOk;
        private System.Windows.Forms.ListView lvBestelItemsStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSluiten;
    }
}