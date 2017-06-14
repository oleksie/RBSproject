namespace UI
{
    partial class Bestellen
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
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ListViewtje = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.CategorieDranken = new System.Windows.Forms.TabControl();
            this.Frisdrank = new System.Windows.Forms.TabPage();
            this.Bier = new System.Windows.Forms.TabPage();
            this.Wijn = new System.Windows.Forms.TabPage();
            this.Gedistileerd = new System.Windows.Forms.TabPage();
            this.Koffiethee = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CategorieDiner = new System.Windows.Forms.TabControl();
            this.VoorgerechtDiner = new System.Windows.Forms.TabPage();
            this.TussengerechtDiner = new System.Windows.Forms.TabPage();
            this.HoofdgerechtDiner = new System.Windows.Forms.TabPage();
            this.NagerechtDiner = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CategorieLunch = new System.Windows.Forms.TabControl();
            this.VoorgerechtLunch = new System.Windows.Forms.TabPage();
            this.FLPLunchVoor = new System.Windows.Forms.FlowLayoutPanel();
            this.HoofdgerechtLunch = new System.Windows.Forms.TabPage();
            this.FLPLunchHoofd = new System.Windows.Forms.FlowLayoutPanel();
            this.NagerechtLunch = new System.Windows.Forms.TabPage();
            this.FLPLucnhNa = new System.Windows.Forms.FlowLayoutPanel();
            this.MenuKaart = new System.Windows.Forms.TabControl();
            this.FLPDinerVoor = new System.Windows.Forms.FlowLayoutPanel();
            this.FLPDinerTussen = new System.Windows.Forms.FlowLayoutPanel();
            this.FLPDinerHoofd = new System.Windows.Forms.FlowLayoutPanel();
            this.FLPDinerNa = new System.Windows.Forms.FlowLayoutPanel();
            this.FLPDrankFris = new System.Windows.Forms.FlowLayoutPanel();
            this.FLPDrankBier = new System.Windows.Forms.FlowLayoutPanel();
            this.FLPDrankWijn = new System.Windows.Forms.FlowLayoutPanel();
            this.FLPDrankGedis = new System.Windows.Forms.FlowLayoutPanel();
            this.FLPDrankKoffthee = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.CategorieDranken.SuspendLayout();
            this.Frisdrank.SuspendLayout();
            this.Bier.SuspendLayout();
            this.Wijn.SuspendLayout();
            this.Gedistileerd.SuspendLayout();
            this.Koffiethee.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.CategorieDiner.SuspendLayout();
            this.VoorgerechtDiner.SuspendLayout();
            this.TussengerechtDiner.SuspendLayout();
            this.HoofdgerechtDiner.SuspendLayout();
            this.NagerechtDiner.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.CategorieLunch.SuspendLayout();
            this.VoorgerechtLunch.SuspendLayout();
            this.HoofdgerechtLunch.SuspendLayout();
            this.NagerechtLunch.SuspendLayout();
            this.MenuKaart.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ListViewtje);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.MenuKaart);
            this.panel1.Controls.Add(this.button1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(42, 919);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ListViewtje
            // 
            this.ListViewtje.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.ListViewtje.Location = new System.Drawing.Point(87, 588);
            this.ListViewtje.Name = "ListViewtje";
            this.ListViewtje.Size = new System.Drawing.Size(571, 303);
            this.ListViewtje.TabIndex = 4;
            this.ListViewtje.TileSize = new System.Drawing.Size(1, 1);
            this.ListViewtje.UseCompatibleStateImageBehavior = false;
            this.ListViewtje.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Naam";
            this.columnHeader1.Width = 44;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "aantal";
            this.columnHeader2.Width = 42;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Opmerkingen";
            this.columnHeader3.Width = 81;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Width = 89;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.CategorieDranken);
            this.tabPage3.Location = new System.Drawing.Point(4, 54);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(571, 341);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Dranken";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // CategorieDranken
            // 
            this.CategorieDranken.Controls.Add(this.Frisdrank);
            this.CategorieDranken.Controls.Add(this.Bier);
            this.CategorieDranken.Controls.Add(this.Wijn);
            this.CategorieDranken.Controls.Add(this.Gedistileerd);
            this.CategorieDranken.Controls.Add(this.Koffiethee);
            this.CategorieDranken.ItemSize = new System.Drawing.Size(115, 50);
            this.CategorieDranken.Location = new System.Drawing.Point(-4, -4);
            this.CategorieDranken.Name = "CategorieDranken";
            this.CategorieDranken.SelectedIndex = 0;
            this.CategorieDranken.Size = new System.Drawing.Size(579, 348);
            this.CategorieDranken.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.CategorieDranken.TabIndex = 2;
            // 
            // Frisdrank
            // 
            this.Frisdrank.Controls.Add(this.FLPDrankFris);
            this.Frisdrank.Location = new System.Drawing.Point(4, 54);
            this.Frisdrank.Name = "Frisdrank";
            this.Frisdrank.Padding = new System.Windows.Forms.Padding(3);
            this.Frisdrank.Size = new System.Drawing.Size(571, 290);
            this.Frisdrank.TabIndex = 0;
            this.Frisdrank.Text = "Frisdrank";
            this.Frisdrank.UseVisualStyleBackColor = true;
            // 
            // Bier
            // 
            this.Bier.Controls.Add(this.FLPDrankBier);
            this.Bier.Location = new System.Drawing.Point(4, 54);
            this.Bier.Name = "Bier";
            this.Bier.Padding = new System.Windows.Forms.Padding(3);
            this.Bier.Size = new System.Drawing.Size(571, 290);
            this.Bier.TabIndex = 1;
            this.Bier.Text = "Bier";
            this.Bier.UseVisualStyleBackColor = true;
            // 
            // Wijn
            // 
            this.Wijn.Controls.Add(this.FLPDrankWijn);
            this.Wijn.Location = new System.Drawing.Point(4, 54);
            this.Wijn.Name = "Wijn";
            this.Wijn.Padding = new System.Windows.Forms.Padding(3);
            this.Wijn.Size = new System.Drawing.Size(571, 290);
            this.Wijn.TabIndex = 2;
            this.Wijn.Text = "Wijn";
            this.Wijn.UseVisualStyleBackColor = true;
            // 
            // Gedistileerd
            // 
            this.Gedistileerd.Controls.Add(this.FLPDrankGedis);
            this.Gedistileerd.Location = new System.Drawing.Point(4, 54);
            this.Gedistileerd.Name = "Gedistileerd";
            this.Gedistileerd.Padding = new System.Windows.Forms.Padding(3);
            this.Gedistileerd.Size = new System.Drawing.Size(571, 290);
            this.Gedistileerd.TabIndex = 3;
            this.Gedistileerd.Text = "Gedistileerd";
            this.Gedistileerd.UseVisualStyleBackColor = true;
            // 
            // Koffiethee
            // 
            this.Koffiethee.Controls.Add(this.FLPDrankKoffthee);
            this.Koffiethee.Location = new System.Drawing.Point(4, 54);
            this.Koffiethee.Name = "Koffiethee";
            this.Koffiethee.Padding = new System.Windows.Forms.Padding(3);
            this.Koffiethee.Size = new System.Drawing.Size(571, 290);
            this.Koffiethee.TabIndex = 4;
            this.Koffiethee.Text = "Koffie/Thee";
            this.Koffiethee.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CategorieDiner);
            this.tabPage2.Location = new System.Drawing.Point(4, 54);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(571, 341);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Diner";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CategorieDiner
            // 
            this.CategorieDiner.Controls.Add(this.VoorgerechtDiner);
            this.CategorieDiner.Controls.Add(this.TussengerechtDiner);
            this.CategorieDiner.Controls.Add(this.HoofdgerechtDiner);
            this.CategorieDiner.Controls.Add(this.NagerechtDiner);
            this.CategorieDiner.ItemSize = new System.Drawing.Size(144, 50);
            this.CategorieDiner.Location = new System.Drawing.Point(-4, -3);
            this.CategorieDiner.Name = "CategorieDiner";
            this.CategorieDiner.SelectedIndex = 0;
            this.CategorieDiner.Size = new System.Drawing.Size(579, 348);
            this.CategorieDiner.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.CategorieDiner.TabIndex = 1;
            // 
            // VoorgerechtDiner
            // 
            this.VoorgerechtDiner.Controls.Add(this.FLPDinerVoor);
            this.VoorgerechtDiner.Location = new System.Drawing.Point(4, 54);
            this.VoorgerechtDiner.Name = "VoorgerechtDiner";
            this.VoorgerechtDiner.Padding = new System.Windows.Forms.Padding(3);
            this.VoorgerechtDiner.Size = new System.Drawing.Size(571, 290);
            this.VoorgerechtDiner.TabIndex = 0;
            this.VoorgerechtDiner.Text = "Voorgerecht";
            this.VoorgerechtDiner.UseVisualStyleBackColor = true;
            // 
            // TussengerechtDiner
            // 
            this.TussengerechtDiner.Controls.Add(this.FLPDinerTussen);
            this.TussengerechtDiner.Location = new System.Drawing.Point(4, 54);
            this.TussengerechtDiner.Name = "TussengerechtDiner";
            this.TussengerechtDiner.Padding = new System.Windows.Forms.Padding(3);
            this.TussengerechtDiner.Size = new System.Drawing.Size(571, 290);
            this.TussengerechtDiner.TabIndex = 1;
            this.TussengerechtDiner.Text = "Tussengerecht";
            this.TussengerechtDiner.UseVisualStyleBackColor = true;
            // 
            // HoofdgerechtDiner
            // 
            this.HoofdgerechtDiner.Controls.Add(this.FLPDinerHoofd);
            this.HoofdgerechtDiner.Location = new System.Drawing.Point(4, 54);
            this.HoofdgerechtDiner.Name = "HoofdgerechtDiner";
            this.HoofdgerechtDiner.Padding = new System.Windows.Forms.Padding(3);
            this.HoofdgerechtDiner.Size = new System.Drawing.Size(571, 290);
            this.HoofdgerechtDiner.TabIndex = 2;
            this.HoofdgerechtDiner.Text = "Hoofdgerecht";
            this.HoofdgerechtDiner.UseVisualStyleBackColor = true;
            // 
            // NagerechtDiner
            // 
            this.NagerechtDiner.Controls.Add(this.FLPDinerNa);
            this.NagerechtDiner.Location = new System.Drawing.Point(4, 54);
            this.NagerechtDiner.Name = "NagerechtDiner";
            this.NagerechtDiner.Padding = new System.Windows.Forms.Padding(3);
            this.NagerechtDiner.Size = new System.Drawing.Size(571, 290);
            this.NagerechtDiner.TabIndex = 3;
            this.NagerechtDiner.Text = "Nagerecht";
            this.NagerechtDiner.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CategorieLunch);
            this.tabPage1.Location = new System.Drawing.Point(4, 54);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(571, 341);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lunch";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CategorieLunch
            // 
            this.CategorieLunch.Controls.Add(this.VoorgerechtLunch);
            this.CategorieLunch.Controls.Add(this.HoofdgerechtLunch);
            this.CategorieLunch.Controls.Add(this.NagerechtLunch);
            this.CategorieLunch.ItemSize = new System.Drawing.Size(192, 50);
            this.CategorieLunch.Location = new System.Drawing.Point(-4, -4);
            this.CategorieLunch.Name = "CategorieLunch";
            this.CategorieLunch.SelectedIndex = 0;
            this.CategorieLunch.Size = new System.Drawing.Size(579, 348);
            this.CategorieLunch.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.CategorieLunch.TabIndex = 3;
            // 
            // VoorgerechtLunch
            // 
            this.VoorgerechtLunch.Controls.Add(this.FLPLunchVoor);
            this.VoorgerechtLunch.Location = new System.Drawing.Point(4, 54);
            this.VoorgerechtLunch.Name = "VoorgerechtLunch";
            this.VoorgerechtLunch.Padding = new System.Windows.Forms.Padding(3);
            this.VoorgerechtLunch.Size = new System.Drawing.Size(571, 290);
            this.VoorgerechtLunch.TabIndex = 0;
            this.VoorgerechtLunch.Text = "Voorgerecht";
            this.VoorgerechtLunch.UseVisualStyleBackColor = true;
            // 
            // FLPLunchVoor
            // 
            this.FLPLunchVoor.Location = new System.Drawing.Point(53, 28);
            this.FLPLunchVoor.Name = "FLPLunchVoor";
            this.FLPLunchVoor.Size = new System.Drawing.Size(464, 235);
            this.FLPLunchVoor.TabIndex = 2;
            // 
            // HoofdgerechtLunch
            // 
            this.HoofdgerechtLunch.Controls.Add(this.FLPLunchHoofd);
            this.HoofdgerechtLunch.Location = new System.Drawing.Point(4, 54);
            this.HoofdgerechtLunch.Name = "HoofdgerechtLunch";
            this.HoofdgerechtLunch.Padding = new System.Windows.Forms.Padding(3);
            this.HoofdgerechtLunch.Size = new System.Drawing.Size(571, 290);
            this.HoofdgerechtLunch.TabIndex = 1;
            this.HoofdgerechtLunch.Text = "Hoofdgerecht";
            this.HoofdgerechtLunch.UseVisualStyleBackColor = true;
            // 
            // FLPLunchHoofd
            // 
            this.FLPLunchHoofd.Location = new System.Drawing.Point(53, 28);
            this.FLPLunchHoofd.Name = "FLPLunchHoofd";
            this.FLPLunchHoofd.Size = new System.Drawing.Size(464, 235);
            this.FLPLunchHoofd.TabIndex = 1;
            // 
            // NagerechtLunch
            // 
            this.NagerechtLunch.Controls.Add(this.FLPLucnhNa);
            this.NagerechtLunch.Location = new System.Drawing.Point(4, 54);
            this.NagerechtLunch.Name = "NagerechtLunch";
            this.NagerechtLunch.Padding = new System.Windows.Forms.Padding(3);
            this.NagerechtLunch.Size = new System.Drawing.Size(571, 290);
            this.NagerechtLunch.TabIndex = 2;
            this.NagerechtLunch.Text = "Nagerecht";
            this.NagerechtLunch.UseVisualStyleBackColor = true;
            // 
            // FLPLucnhNa
            // 
            this.FLPLucnhNa.Location = new System.Drawing.Point(53, 28);
            this.FLPLucnhNa.Name = "FLPLucnhNa";
            this.FLPLucnhNa.Size = new System.Drawing.Size(464, 235);
            this.FLPLucnhNa.TabIndex = 2;
            // 
            // MenuKaart
            // 
            this.MenuKaart.Controls.Add(this.tabPage1);
            this.MenuKaart.Controls.Add(this.tabPage2);
            this.MenuKaart.Controls.Add(this.tabPage3);
            this.MenuKaart.ItemSize = new System.Drawing.Size(192, 50);
            this.MenuKaart.Location = new System.Drawing.Point(83, 152);
            this.MenuKaart.Name = "MenuKaart";
            this.MenuKaart.SelectedIndex = 0;
            this.MenuKaart.Size = new System.Drawing.Size(579, 399);
            this.MenuKaart.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MenuKaart.TabIndex = 1;
            // 
            // FLPDinerVoor
            // 
            this.FLPDinerVoor.Location = new System.Drawing.Point(53, 28);
            this.FLPDinerVoor.Name = "FLPDinerVoor";
            this.FLPDinerVoor.Size = new System.Drawing.Size(464, 235);
            this.FLPDinerVoor.TabIndex = 3;
            // 
            // FLPDinerTussen
            // 
            this.FLPDinerTussen.Location = new System.Drawing.Point(53, 28);
            this.FLPDinerTussen.Name = "FLPDinerTussen";
            this.FLPDinerTussen.Size = new System.Drawing.Size(464, 235);
            this.FLPDinerTussen.TabIndex = 3;
            // 
            // FLPDinerHoofd
            // 
            this.FLPDinerHoofd.Location = new System.Drawing.Point(53, 28);
            this.FLPDinerHoofd.Name = "FLPDinerHoofd";
            this.FLPDinerHoofd.Size = new System.Drawing.Size(464, 235);
            this.FLPDinerHoofd.TabIndex = 3;
            // 
            // FLPDinerNa
            // 
            this.FLPDinerNa.Location = new System.Drawing.Point(53, 28);
            this.FLPDinerNa.Name = "FLPDinerNa";
            this.FLPDinerNa.Size = new System.Drawing.Size(464, 235);
            this.FLPDinerNa.TabIndex = 3;
            // 
            // FLPDrankFris
            // 
            this.FLPDrankFris.Location = new System.Drawing.Point(53, 28);
            this.FLPDrankFris.Name = "FLPDrankFris";
            this.FLPDrankFris.Size = new System.Drawing.Size(464, 235);
            this.FLPDrankFris.TabIndex = 4;
            // 
            // FLPDrankBier
            // 
            this.FLPDrankBier.Location = new System.Drawing.Point(53, 28);
            this.FLPDrankBier.Name = "FLPDrankBier";
            this.FLPDrankBier.Size = new System.Drawing.Size(464, 235);
            this.FLPDrankBier.TabIndex = 4;
            // 
            // FLPDrankWijn
            // 
            this.FLPDrankWijn.Location = new System.Drawing.Point(53, 28);
            this.FLPDrankWijn.Name = "FLPDrankWijn";
            this.FLPDrankWijn.Size = new System.Drawing.Size(464, 235);
            this.FLPDrankWijn.TabIndex = 4;
            // 
            // FLPDrankGedis
            // 
            this.FLPDrankGedis.Location = new System.Drawing.Point(53, 28);
            this.FLPDrankGedis.Name = "FLPDrankGedis";
            this.FLPDrankGedis.Size = new System.Drawing.Size(464, 235);
            this.FLPDrankGedis.TabIndex = 4;
            // 
            // FLPDrankKoffthee
            // 
            this.FLPDrankKoffthee.Location = new System.Drawing.Point(53, 28);
            this.FLPDrankKoffthee.Name = "FLPDrankKoffthee";
            this.FLPDrankKoffthee.Size = new System.Drawing.Size(464, 235);
            this.FLPDrankKoffthee.TabIndex = 4;
            // 
            // Bestellen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 985);
            this.Name = "Bestellen";
            this.Text = "Bestellen";
            this.panel1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.CategorieDranken.ResumeLayout(false);
            this.Frisdrank.ResumeLayout(false);
            this.Bier.ResumeLayout(false);
            this.Wijn.ResumeLayout(false);
            this.Gedistileerd.ResumeLayout(false);
            this.Koffiethee.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.CategorieDiner.ResumeLayout(false);
            this.VoorgerechtDiner.ResumeLayout(false);
            this.TussengerechtDiner.ResumeLayout(false);
            this.HoofdgerechtDiner.ResumeLayout(false);
            this.NagerechtDiner.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.CategorieLunch.ResumeLayout(false);
            this.VoorgerechtLunch.ResumeLayout(false);
            this.HoofdgerechtLunch.ResumeLayout(false);
            this.NagerechtLunch.ResumeLayout(false);
            this.MenuKaart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView ListViewtje;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TabControl MenuKaart;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl CategorieLunch;
        private System.Windows.Forms.TabPage VoorgerechtLunch;
        private System.Windows.Forms.TabPage HoofdgerechtLunch;
        private System.Windows.Forms.TabPage NagerechtLunch;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl CategorieDiner;
        private System.Windows.Forms.TabPage VoorgerechtDiner;
        private System.Windows.Forms.TabPage TussengerechtDiner;
        private System.Windows.Forms.TabPage HoofdgerechtDiner;
        private System.Windows.Forms.TabPage NagerechtDiner;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl CategorieDranken;
        private System.Windows.Forms.TabPage Frisdrank;
        private System.Windows.Forms.TabPage Bier;
        private System.Windows.Forms.TabPage Wijn;
        private System.Windows.Forms.TabPage Gedistileerd;
        private System.Windows.Forms.TabPage Koffiethee;
        private System.Windows.Forms.FlowLayoutPanel FLPLunchHoofd;
        private System.Windows.Forms.FlowLayoutPanel FLPLunchVoor;
        private System.Windows.Forms.FlowLayoutPanel FLPLucnhNa;
        private System.Windows.Forms.FlowLayoutPanel FLPDinerVoor;
        private System.Windows.Forms.FlowLayoutPanel FLPDinerTussen;
        private System.Windows.Forms.FlowLayoutPanel FLPDinerHoofd;
        private System.Windows.Forms.FlowLayoutPanel FLPDinerNa;
        private System.Windows.Forms.FlowLayoutPanel FLPDrankFris;
        private System.Windows.Forms.FlowLayoutPanel FLPDrankBier;
        private System.Windows.Forms.FlowLayoutPanel FLPDrankWijn;
        private System.Windows.Forms.FlowLayoutPanel FLPDrankGedis;
        private System.Windows.Forms.FlowLayoutPanel FLPDrankKoffthee;
    }
}