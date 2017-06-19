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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bestellen));
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ListViewtje = new System.Windows.Forms.ListView();
            this.ListColomNaamItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListColomAantalItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListColomOpmerkingItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListColomPrijsItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListColomNaamID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.CategorieDranken = new System.Windows.Forms.TabControl();
            this.Frisdrank = new System.Windows.Forms.TabPage();
            this.FLPDrankFris = new System.Windows.Forms.FlowLayoutPanel();
            this.Bier = new System.Windows.Forms.TabPage();
            this.FLPDrankBier = new System.Windows.Forms.FlowLayoutPanel();
            this.Wijn = new System.Windows.Forms.TabPage();
            this.FLPDrankWijn = new System.Windows.Forms.FlowLayoutPanel();
            this.Gedistileerd = new System.Windows.Forms.TabPage();
            this.FLPDrankGedis = new System.Windows.Forms.FlowLayoutPanel();
            this.Koffiethee = new System.Windows.Forms.TabPage();
            this.FLPDrankKoffthee = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CategorieDiner = new System.Windows.Forms.TabControl();
            this.VoorgerechtDiner = new System.Windows.Forms.TabPage();
            this.FLPDinerVoor = new System.Windows.Forms.FlowLayoutPanel();
            this.TussengerechtDiner = new System.Windows.Forms.TabPage();
            this.FLPDinerTussen = new System.Windows.Forms.FlowLayoutPanel();
            this.HoofdgerechtDiner = new System.Windows.Forms.TabPage();
            this.FLPDinerHoofd = new System.Windows.Forms.FlowLayoutPanel();
            this.NagerechtDiner = new System.Windows.Forms.TabPage();
            this.FLPDinerNa = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CategorieLunch = new System.Windows.Forms.TabControl();
            this.VoorgerechtLunch = new System.Windows.Forms.TabPage();
            this.FLPLunchVoor = new System.Windows.Forms.FlowLayoutPanel();
            this.HoofdgerechtLunch = new System.Windows.Forms.TabPage();
            this.FLPLunchHoofd = new System.Windows.Forms.FlowLayoutPanel();
            this.NagerechtLunch = new System.Windows.Forms.TabPage();
            this.FLPLucnhNa = new System.Windows.Forms.FlowLayoutPanel();
            this.MenuKaart = new System.Windows.Forms.TabControl();
            this.btn_afrondenHuidig = new System.Windows.Forms.Button();
            this.lblTafelNummer = new System.Windows.Forms.Label();
            this.lblPersoneelsNummer = new System.Windows.Forms.Label();
            this.btnAantalOmhoog = new System.Windows.Forms.Button();
            this.btnAantalOmlaag = new System.Windows.Forms.Button();
            this.btnVerwijderItem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnVerwijderItem);
            this.panel1.Controls.Add(this.btnAantalOmlaag);
            this.panel1.Controls.Add(this.btnAantalOmhoog);
            this.panel1.Controls.Add(this.lblPersoneelsNummer);
            this.panel1.Controls.Add(this.lblTafelNummer);
            this.panel1.Controls.Add(this.btn_afrondenHuidig);
            this.panel1.Controls.Add(this.ListViewtje);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.MenuKaart);
            this.panel1.Controls.Add(this.button1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(237, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tafel afrekenen";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(87, 887);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 55);
            this.button4.TabIndex = 3;
            this.button4.Text = "Terug";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ListViewtje
            // 
            this.ListViewtje.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ListColomNaamItem,
            this.ListColomAantalItem,
            this.ListColomOpmerkingItem,
            this.ListColomPrijsItem,
            this.ListColomNaamID});
            this.ListViewtje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListViewtje.FullRowSelect = true;
            this.ListViewtje.Location = new System.Drawing.Point(87, 562);
            this.ListViewtje.MultiSelect = false;
            this.ListViewtje.Name = "ListViewtje";
            this.ListViewtje.Size = new System.Drawing.Size(488, 303);
            this.ListViewtje.TabIndex = 4;
            this.ListViewtje.TileSize = new System.Drawing.Size(1, 1);
            this.ListViewtje.UseCompatibleStateImageBehavior = false;
            this.ListViewtje.View = System.Windows.Forms.View.Details;
            // 
            // ListColomNaamItem
            // 
            this.ListColomNaamItem.Text = "Naam Item";
            this.ListColomNaamItem.Width = 117;
            // 
            // ListColomAantalItem
            // 
            this.ListColomAantalItem.Text = "Aantal";
            this.ListColomAantalItem.Width = 52;
            // 
            // ListColomOpmerkingItem
            // 
            this.ListColomOpmerkingItem.Text = "Opmerkingen";
            this.ListColomOpmerkingItem.Width = 212;
            // 
            // ListColomPrijsItem
            // 
            this.ListColomPrijsItem.Text = "Prijs";
            this.ListColomPrijsItem.Width = 59;
            // 
            // ListColomNaamID
            // 
            this.ListColomNaamID.Text = "id";
            this.ListColomNaamID.Width = 44;
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
            this.CategorieDranken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // FLPDrankFris
            // 
            this.FLPDrankFris.Location = new System.Drawing.Point(23, 18);
            this.FLPDrankFris.Name = "FLPDrankFris";
            this.FLPDrankFris.Size = new System.Drawing.Size(525, 253);
            this.FLPDrankFris.TabIndex = 4;
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
            // FLPDrankBier
            // 
            this.FLPDrankBier.Location = new System.Drawing.Point(23, 18);
            this.FLPDrankBier.Name = "FLPDrankBier";
            this.FLPDrankBier.Size = new System.Drawing.Size(525, 253);
            this.FLPDrankBier.TabIndex = 4;
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
            // FLPDrankWijn
            // 
            this.FLPDrankWijn.Location = new System.Drawing.Point(23, 18);
            this.FLPDrankWijn.Name = "FLPDrankWijn";
            this.FLPDrankWijn.Size = new System.Drawing.Size(525, 253);
            this.FLPDrankWijn.TabIndex = 4;
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
            // FLPDrankGedis
            // 
            this.FLPDrankGedis.Location = new System.Drawing.Point(23, 18);
            this.FLPDrankGedis.Name = "FLPDrankGedis";
            this.FLPDrankGedis.Size = new System.Drawing.Size(525, 253);
            this.FLPDrankGedis.TabIndex = 4;
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
            // FLPDrankKoffthee
            // 
            this.FLPDrankKoffthee.Location = new System.Drawing.Point(23, 18);
            this.FLPDrankKoffthee.Name = "FLPDrankKoffthee";
            this.FLPDrankKoffthee.Size = new System.Drawing.Size(525, 253);
            this.FLPDrankKoffthee.TabIndex = 4;
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
            this.CategorieDiner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // FLPDinerVoor
            // 
            this.FLPDinerVoor.Location = new System.Drawing.Point(23, 18);
            this.FLPDinerVoor.Name = "FLPDinerVoor";
            this.FLPDinerVoor.Size = new System.Drawing.Size(525, 253);
            this.FLPDinerVoor.TabIndex = 3;
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
            // FLPDinerTussen
            // 
            this.FLPDinerTussen.Location = new System.Drawing.Point(23, 18);
            this.FLPDinerTussen.Name = "FLPDinerTussen";
            this.FLPDinerTussen.Size = new System.Drawing.Size(525, 253);
            this.FLPDinerTussen.TabIndex = 3;
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
            // FLPDinerHoofd
            // 
            this.FLPDinerHoofd.Location = new System.Drawing.Point(23, 18);
            this.FLPDinerHoofd.Name = "FLPDinerHoofd";
            this.FLPDinerHoofd.Size = new System.Drawing.Size(525, 253);
            this.FLPDinerHoofd.TabIndex = 3;
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
            // FLPDinerNa
            // 
            this.FLPDinerNa.Location = new System.Drawing.Point(23, 18);
            this.FLPDinerNa.Name = "FLPDinerNa";
            this.FLPDinerNa.Size = new System.Drawing.Size(525, 253);
            this.FLPDinerNa.TabIndex = 3;
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
            this.CategorieLunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.FLPLunchVoor.Location = new System.Drawing.Point(23, 18);
            this.FLPLunchVoor.Name = "FLPLunchVoor";
            this.FLPLunchVoor.Size = new System.Drawing.Size(525, 253);
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
            this.FLPLunchHoofd.Location = new System.Drawing.Point(23, 18);
            this.FLPLunchHoofd.Name = "FLPLunchHoofd";
            this.FLPLunchHoofd.Size = new System.Drawing.Size(525, 253);
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
            this.FLPLucnhNa.Location = new System.Drawing.Point(23, 18);
            this.FLPLucnhNa.Name = "FLPLucnhNa";
            this.FLPLucnhNa.Size = new System.Drawing.Size(525, 253);
            this.FLPLucnhNa.TabIndex = 2;
            // 
            // MenuKaart
            // 
            this.MenuKaart.Controls.Add(this.tabPage1);
            this.MenuKaart.Controls.Add(this.tabPage2);
            this.MenuKaart.Controls.Add(this.tabPage3);
            this.MenuKaart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuKaart.ItemSize = new System.Drawing.Size(192, 50);
            this.MenuKaart.Location = new System.Drawing.Point(83, 152);
            this.MenuKaart.Name = "MenuKaart";
            this.MenuKaart.SelectedIndex = 0;
            this.MenuKaart.Size = new System.Drawing.Size(579, 399);
            this.MenuKaart.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MenuKaart.TabIndex = 1;
            // 
            // btn_afrondenHuidig
            // 
            this.btn_afrondenHuidig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_afrondenHuidig.Location = new System.Drawing.Point(478, 887);
            this.btn_afrondenHuidig.Name = "btn_afrondenHuidig";
            this.btn_afrondenHuidig.Size = new System.Drawing.Size(180, 55);
            this.btn_afrondenHuidig.TabIndex = 5;
            this.btn_afrondenHuidig.Text = "Afronden huidige bestelling";
            this.btn_afrondenHuidig.UseVisualStyleBackColor = true;
            this.btn_afrondenHuidig.Click += new System.EventHandler(this.btn_afrondenHuidig_Click);
            // 
            // lblTafelNummer
            // 
            this.lblTafelNummer.AutoSize = true;
            this.lblTafelNummer.Location = new System.Drawing.Point(28, 45);
            this.lblTafelNummer.Name = "lblTafelNummer";
            this.lblTafelNummer.Size = new System.Drawing.Size(74, 13);
            this.lblTafelNummer.TabIndex = 6;
            this.lblTafelNummer.Text = "Tafelnummer: ";
            // 
            // lblPersoneelsNummer
            // 
            this.lblPersoneelsNummer.AutoSize = true;
            this.lblPersoneelsNummer.Location = new System.Drawing.Point(30, 20);
            this.lblPersoneelsNummer.Name = "lblPersoneelsNummer";
            this.lblPersoneelsNummer.Size = new System.Drawing.Size(102, 13);
            this.lblPersoneelsNummer.TabIndex = 7;
            this.lblPersoneelsNummer.Text = "Personeelsnummer: ";
            // 
            // btnAantalOmhoog
            // 
            this.btnAantalOmhoog.Enabled = false;
            this.btnAantalOmhoog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAantalOmhoog.Location = new System.Drawing.Point(583, 607);
            this.btnAantalOmhoog.Name = "btnAantalOmhoog";
            this.btnAantalOmhoog.Size = new System.Drawing.Size(75, 55);
            this.btnAantalOmhoog.TabIndex = 8;
            this.btnAantalOmhoog.Text = "Omhoog";
            this.btnAantalOmhoog.UseVisualStyleBackColor = true;
            this.btnAantalOmhoog.Click += new System.EventHandler(this.btnAantalOmhoog_Click);
            // 
            // btnAantalOmlaag
            // 
            this.btnAantalOmlaag.Enabled = false;
            this.btnAantalOmlaag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAantalOmlaag.Location = new System.Drawing.Point(583, 686);
            this.btnAantalOmlaag.Name = "btnAantalOmlaag";
            this.btnAantalOmlaag.Size = new System.Drawing.Size(75, 55);
            this.btnAantalOmlaag.TabIndex = 9;
            this.btnAantalOmlaag.Text = "Omlaag";
            this.btnAantalOmlaag.UseVisualStyleBackColor = true;
            this.btnAantalOmlaag.Click += new System.EventHandler(this.btnAantalOmlaag_Click);
            // 
            // btnVerwijderItem
            // 
            this.btnVerwijderItem.Enabled = false;
            this.btnVerwijderItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerwijderItem.Location = new System.Drawing.Point(583, 764);
            this.btnVerwijderItem.Name = "btnVerwijderItem";
            this.btnVerwijderItem.Size = new System.Drawing.Size(75, 55);
            this.btnVerwijderItem.TabIndex = 10;
            this.btnVerwijderItem.Text = "Verwijder";
            this.btnVerwijderItem.UseVisualStyleBackColor = true;
            this.btnVerwijderItem.Click += new System.EventHandler(this.btnVerwijderItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(534, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 75);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Bestellen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 985);
            this.Name = "Bestellen";
            this.Text = "Kaart";
            this.Load += new System.EventHandler(this.Bestellen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColumnHeader ListColomNaamItem;
        private System.Windows.Forms.ColumnHeader ListColomAantalItem;
        private System.Windows.Forms.ColumnHeader ListColomOpmerkingItem;
        private System.Windows.Forms.ColumnHeader ListColomPrijsItem;
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
        private System.Windows.Forms.Button btn_afrondenHuidig;
        private System.Windows.Forms.ColumnHeader ListColomNaamID;
        public System.Windows.Forms.ListView ListViewtje;
        private System.Windows.Forms.Label lblTafelNummer;
        private System.Windows.Forms.Label lblPersoneelsNummer;
        private System.Windows.Forms.Button btnVerwijderItem;
        private System.Windows.Forms.Button btnAantalOmlaag;
        private System.Windows.Forms.Button btnAantalOmhoog;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}