﻿namespace UI
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
            this.SuspendLayout();
            // 
            // Btn_HandheldPopUpStatusOk
            // 
            this.Btn_HandheldPopUpStatusOk.Location = new System.Drawing.Point(144, 179);
            this.Btn_HandheldPopUpStatusOk.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_HandheldPopUpStatusOk.Name = "Btn_HandheldPopUpStatusOk";
            this.Btn_HandheldPopUpStatusOk.Size = new System.Drawing.Size(83, 52);
            this.Btn_HandheldPopUpStatusOk.TabIndex = 10;
            this.Btn_HandheldPopUpStatusOk.Text = "Ok";
            this.Btn_HandheldPopUpStatusOk.UseVisualStyleBackColor = true;
            this.Btn_HandheldPopUpStatusOk.Click += new System.EventHandler(this.Btn_HandheldPopUpStatusOk_Click);
            // 
            // lvBestelItemsStatus
            // 
            this.lvBestelItemsStatus.Location = new System.Drawing.Point(12, 45);
            this.lvBestelItemsStatus.Name = "lvBestelItemsStatus";
            this.lvBestelItemsStatus.Size = new System.Drawing.Size(346, 129);
            this.lvBestelItemsStatus.TabIndex = 11;
            this.lvBestelItemsStatus.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "De volgende bestelde items zijn gereed:";
            // 
            // HandheldPopUpStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 274);
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
    }
}