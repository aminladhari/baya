using System.ComponentModel;

namespace baya
{
    partial class Acceuil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acceuil));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.type = new MetroFramework.Controls.MetroComboBox();
            this.txtbox_metrage = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.libele = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.total_article = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.qt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.prix_produit = new MetroFramework.Controls.MetroTextBox();
            this.combo_epai = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionMarbreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionGranitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionMarbreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suiviCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rech_ref = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cin = new MetroFramework.Controls.MetroTextBox();
            this.off = new System.Windows.Forms.Button();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.adresse = new MetroFramework.Controls.MetroTextBox();
            this.nom = new MetroFramework.Controls.MetroTextBox();
            this.prenom = new MetroFramework.Controls.MetroTextBox();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox_opération = new System.Windows.Forms.GroupBox();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tva = new MetroFramework.Controls.MetroTextBox();
            this.btn_clc = new MetroFramework.Controls.MetroButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_montant_total = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_montant_tva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_montant_htva = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_imprimer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.id_details = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rech_ref)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox_opération.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(33, 36);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(43, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Type :";
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.ItemHeight = 23;
            this.type.Location = new System.Drawing.Point(82, 33);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(121, 29);
            this.type.TabIndex = 2;
            this.type.UseSelectable = true;
            this.type.SelectedIndexChanged += new System.EventHandler(this.type_SelectedIndexChanged);
            // 
            // txtbox_metrage
            // 
            // 
            // 
            // 
            this.txtbox_metrage.CustomButton.Image = null;
            this.txtbox_metrage.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtbox_metrage.CustomButton.Name = "";
            this.txtbox_metrage.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbox_metrage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbox_metrage.CustomButton.TabIndex = 1;
            this.txtbox_metrage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbox_metrage.CustomButton.UseSelectable = true;
            this.txtbox_metrage.CustomButton.Visible = false;
            this.txtbox_metrage.Lines = new string[0];
            this.txtbox_metrage.Location = new System.Drawing.Point(127, 42);
            this.txtbox_metrage.MaxLength = 32767;
            this.txtbox_metrage.Name = "txtbox_metrage";
            this.txtbox_metrage.PasswordChar = '\0';
            this.txtbox_metrage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbox_metrage.SelectedText = "";
            this.txtbox_metrage.SelectionLength = 0;
            this.txtbox_metrage.SelectionStart = 0;
            this.txtbox_metrage.ShortcutsEnabled = true;
            this.txtbox_metrage.Size = new System.Drawing.Size(121, 23);
            this.txtbox_metrage.TabIndex = 3;
            this.txtbox_metrage.UseSelectable = true;
            this.txtbox_metrage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbox_metrage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtbox_metrage.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 42);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(87, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Métrage m² :";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel11);
            this.groupBox1.Controls.Add(this.libele);
            this.groupBox1.Controls.Add(this.metroLabel10);
            this.groupBox1.Controls.Add(this.total_article);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.qt);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.prix_produit);
            this.groupBox1.Controls.Add(this.combo_epai);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.txtbox_metrage);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(29, 358);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 143);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cordonnées Commande";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(272, 33);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(84, 19);
            this.metroLabel11.TabIndex = 109;
            this.metroLabel11.Text = "Désignation :";
            // 
            // libele
            // 
            // 
            // 
            // 
            this.libele.CustomButton.Image = null;
            this.libele.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.libele.CustomButton.Name = "";
            this.libele.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.libele.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.libele.CustomButton.TabIndex = 1;
            this.libele.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.libele.CustomButton.UseSelectable = true;
            this.libele.CustomButton.Visible = false;
            this.libele.Enabled = false;
            this.libele.Lines = new string[0];
            this.libele.Location = new System.Drawing.Point(362, 33);
            this.libele.MaxLength = 32767;
            this.libele.Name = "libele";
            this.libele.PasswordChar = '\0';
            this.libele.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.libele.SelectedText = "";
            this.libele.SelectionLength = 0;
            this.libele.SelectionStart = 0;
            this.libele.ShortcutsEnabled = true;
            this.libele.Size = new System.Drawing.Size(121, 23);
            this.libele.TabIndex = 108;
            this.libele.UseSelectable = true;
            this.libele.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.libele.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(495, 95);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(115, 19);
            this.metroLabel10.TabIndex = 14;
            this.metroLabel10.Text = "Prix totale article :";
            // 
            // total_article
            // 
            // 
            // 
            // 
            this.total_article.CustomButton.Image = null;
            this.total_article.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.total_article.CustomButton.Name = "";
            this.total_article.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.total_article.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.total_article.CustomButton.TabIndex = 1;
            this.total_article.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.total_article.CustomButton.UseSelectable = true;
            this.total_article.CustomButton.Visible = false;
            this.total_article.Enabled = false;
            this.total_article.Lines = new string[0];
            this.total_article.Location = new System.Drawing.Point(618, 95);
            this.total_article.MaxLength = 32767;
            this.total_article.Name = "total_article";
            this.total_article.PasswordChar = '\0';
            this.total_article.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.total_article.SelectedText = "";
            this.total_article.SelectionLength = 0;
            this.total_article.SelectionStart = 0;
            this.total_article.ShortcutsEnabled = true;
            this.total_article.Size = new System.Drawing.Size(121, 23);
            this.total_article.TabIndex = 13;
            this.total_article.UseSelectable = true;
            this.total_article.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.total_article.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(272, 95);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(66, 19);
            this.metroLabel9.TabIndex = 12;
            this.metroLabel9.Text = "Quantité :";
            // 
            // qt
            // 
            // 
            // 
            // 
            this.qt.CustomButton.Image = null;
            this.qt.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.qt.CustomButton.Name = "";
            this.qt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.qt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.qt.CustomButton.TabIndex = 1;
            this.qt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.qt.CustomButton.UseSelectable = true;
            this.qt.CustomButton.Visible = false;
            this.qt.Lines = new string[] {
        "1"};
            this.qt.Location = new System.Drawing.Point(362, 95);
            this.qt.MaxLength = 32767;
            this.qt.Name = "qt";
            this.qt.PasswordChar = '\0';
            this.qt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.qt.SelectedText = "";
            this.qt.SelectionLength = 0;
            this.qt.SelectionStart = 0;
            this.qt.ShortcutsEnabled = true;
            this.qt.Size = new System.Drawing.Size(121, 23);
            this.qt.TabIndex = 11;
            this.qt.Text = "1";
            this.qt.UseSelectable = true;
            this.qt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.qt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.qt.TextChanged += new System.EventHandler(this.qt_TextChanged);
            this.qt.Click += new System.EventHandler(this.qt_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(495, 33);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(86, 19);
            this.metroLabel8.TabIndex = 10;
            this.metroLabel8.Text = "Prix 1 Métre :";
            // 
            // prix_produit
            // 
            // 
            // 
            // 
            this.prix_produit.CustomButton.Image = null;
            this.prix_produit.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.prix_produit.CustomButton.Name = "";
            this.prix_produit.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.prix_produit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.prix_produit.CustomButton.TabIndex = 1;
            this.prix_produit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.prix_produit.CustomButton.UseSelectable = true;
            this.prix_produit.CustomButton.Visible = false;
            this.prix_produit.Enabled = false;
            this.prix_produit.Lines = new string[0];
            this.prix_produit.Location = new System.Drawing.Point(618, 33);
            this.prix_produit.MaxLength = 32767;
            this.prix_produit.Name = "prix_produit";
            this.prix_produit.PasswordChar = '\0';
            this.prix_produit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.prix_produit.SelectedText = "";
            this.prix_produit.SelectionLength = 0;
            this.prix_produit.SelectionStart = 0;
            this.prix_produit.ShortcutsEnabled = true;
            this.prix_produit.Size = new System.Drawing.Size(121, 23);
            this.prix_produit.TabIndex = 9;
            this.prix_produit.UseSelectable = true;
            this.prix_produit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.prix_produit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // combo_epai
            // 
            this.combo_epai.FormattingEnabled = true;
            this.combo_epai.ItemHeight = 23;
            this.combo_epai.Location = new System.Drawing.Point(127, 85);
            this.combo_epai.Name = "combo_epai";
            this.combo_epai.Size = new System.Drawing.Size(121, 29);
            this.combo_epai.TabIndex = 8;
            this.combo_epai.UseSelectable = true;
            this.combo_epai.SelectedIndexChanged += new System.EventHandler(this.combo_epai_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 85);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(95, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Epaisseur Cm :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.type);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(29, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 239);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(392, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionMarbreToolStripMenuItem,
            this.suiviCommandeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(964, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionMarbreToolStripMenuItem
            // 
            this.gestionMarbreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionGranitToolStripMenuItem1,
            this.gestionMarbreToolStripMenuItem1,
            this.gestionDesClientsToolStripMenuItem,
            this.toolStripSeparator1,
            this.quiterToolStripMenuItem});
            this.gestionMarbreToolStripMenuItem.Name = "gestionMarbreToolStripMenuItem";
            this.gestionMarbreToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gestionMarbreToolStripMenuItem.Text = "Menu";
            this.gestionMarbreToolStripMenuItem.Click += new System.EventHandler(this.gestionMarbreToolStripMenuItem_Click);
            // 
            // gestionGranitToolStripMenuItem1
            // 
            this.gestionGranitToolStripMenuItem1.Name = "gestionGranitToolStripMenuItem1";
            this.gestionGranitToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.gestionGranitToolStripMenuItem1.Text = "Gestion Granit";
            this.gestionGranitToolStripMenuItem1.Click += new System.EventHandler(this.gestionGranitToolStripMenuItem1_Click);
            // 
            // gestionMarbreToolStripMenuItem1
            // 
            this.gestionMarbreToolStripMenuItem1.Name = "gestionMarbreToolStripMenuItem1";
            this.gestionMarbreToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.gestionMarbreToolStripMenuItem1.Text = "Gestion Marbre";
            this.gestionMarbreToolStripMenuItem1.Click += new System.EventHandler(this.gestionMarbreToolStripMenuItem1_Click);
            // 
            // gestionDesClientsToolStripMenuItem
            // 
            this.gestionDesClientsToolStripMenuItem.Name = "gestionDesClientsToolStripMenuItem";
            this.gestionDesClientsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.gestionDesClientsToolStripMenuItem.Text = "Gestion des clients";
            this.gestionDesClientsToolStripMenuItem.Click += new System.EventHandler(this.gestionDesClientsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // quiterToolStripMenuItem
            // 
            this.quiterToolStripMenuItem.Name = "quiterToolStripMenuItem";
            this.quiterToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.quiterToolStripMenuItem.Text = "Quiter";
            this.quiterToolStripMenuItem.Click += new System.EventHandler(this.quiterToolStripMenuItem_Click);
            // 
            // suiviCommandeToolStripMenuItem
            // 
            this.suiviCommandeToolStripMenuItem.Name = "suiviCommandeToolStripMenuItem";
            this.suiviCommandeToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.suiviCommandeToolStripMenuItem.Text = "Suivi Commande";
            this.suiviCommandeToolStripMenuItem.Click += new System.EventHandler(this.suiviCommandeToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rech_ref);
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Controls.Add(this.cin);
            this.groupBox3.Controls.Add(this.off);
            this.groupBox3.Controls.Add(this.metroLabel6);
            this.groupBox3.Controls.Add(this.metroLabel4);
            this.groupBox3.Controls.Add(this.metroLabel7);
            this.groupBox3.Controls.Add(this.metroLabel5);
            this.groupBox3.Controls.Add(this.adresse);
            this.groupBox3.Controls.Add(this.nom);
            this.groupBox3.Controls.Add(this.prenom);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox3.Location = new System.Drawing.Point(489, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(495, 239);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Client";
            // 
            // rech_ref
            // 
            this.rech_ref.Image = ((System.Drawing.Image)(resources.GetObject("rech_ref.Image")));
            this.rech_ref.Location = new System.Drawing.Point(41, 21);
            this.rech_ref.Name = "rech_ref";
            this.rech_ref.Size = new System.Drawing.Size(36, 30);
            this.rech_ref.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rech_ref.TabIndex = 109;
            this.rech_ref.TabStop = false;
            this.rech_ref.Click += new System.EventHandler(this.rech_ref_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(15, 60);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(454, 150);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.Visible = false;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // cin
            // 
            // 
            // 
            // 
            this.cin.CustomButton.Image = null;
            this.cin.CustomButton.Location = new System.Drawing.Point(95, 1);
            this.cin.CustomButton.Name = "";
            this.cin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cin.CustomButton.TabIndex = 1;
            this.cin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cin.CustomButton.UseSelectable = true;
            this.cin.CustomButton.Visible = false;
            this.cin.Enabled = false;
            this.cin.Lines = new string[0];
            this.cin.Location = new System.Drawing.Point(300, 151);
            this.cin.MaxLength = 32767;
            this.cin.Name = "cin";
            this.cin.PasswordChar = '\0';
            this.cin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cin.SelectedText = "";
            this.cin.SelectionLength = 0;
            this.cin.SelectionStart = 0;
            this.cin.ShortcutsEnabled = true;
            this.cin.Size = new System.Drawing.Size(117, 23);
            this.cin.TabIndex = 16;
            this.cin.UseSelectable = true;
            this.cin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // off
            // 
            this.off.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("off.BackgroundImage")));
            this.off.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.off.Location = new System.Drawing.Point(440, 21);
            this.off.Name = "off";
            this.off.Size = new System.Drawing.Size(27, 33);
            this.off.TabIndex = 109;
            this.off.UseVisualStyleBackColor = true;
            this.off.Visible = false;
            this.off.Click += new System.EventHandler(this.off_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(15, 151);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(62, 19);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "Adresse :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(15, 68);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(46, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Nom :";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(216, 151);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(35, 19);
            this.metroLabel7.TabIndex = 12;
            this.metroLabel7.Text = "Cin :";
            this.metroLabel7.Click += new System.EventHandler(this.metroLabel7_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(216, 68);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(63, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Prénom :";
            // 
            // adresse
            // 
            // 
            // 
            // 
            this.adresse.CustomButton.Image = null;
            this.adresse.CustomButton.Location = new System.Drawing.Point(95, 1);
            this.adresse.CustomButton.Name = "";
            this.adresse.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.adresse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.adresse.CustomButton.TabIndex = 1;
            this.adresse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.adresse.CustomButton.UseSelectable = true;
            this.adresse.CustomButton.Visible = false;
            this.adresse.Enabled = false;
            this.adresse.Lines = new string[0];
            this.adresse.Location = new System.Drawing.Point(77, 151);
            this.adresse.MaxLength = 32767;
            this.adresse.Name = "adresse";
            this.adresse.PasswordChar = '\0';
            this.adresse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.adresse.SelectedText = "";
            this.adresse.SelectionLength = 0;
            this.adresse.SelectionStart = 0;
            this.adresse.ShortcutsEnabled = true;
            this.adresse.Size = new System.Drawing.Size(117, 23);
            this.adresse.TabIndex = 15;
            this.adresse.UseSelectable = true;
            this.adresse.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.adresse.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // nom
            // 
            // 
            // 
            // 
            this.nom.CustomButton.Image = null;
            this.nom.CustomButton.Location = new System.Drawing.Point(95, 1);
            this.nom.CustomButton.Name = "";
            this.nom.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nom.CustomButton.TabIndex = 1;
            this.nom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nom.CustomButton.UseSelectable = true;
            this.nom.CustomButton.Visible = false;
            this.nom.Enabled = false;
            this.nom.Lines = new string[0];
            this.nom.Location = new System.Drawing.Point(77, 68);
            this.nom.MaxLength = 32767;
            this.nom.Name = "nom";
            this.nom.PasswordChar = '\0';
            this.nom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nom.SelectedText = "";
            this.nom.SelectionLength = 0;
            this.nom.SelectionStart = 0;
            this.nom.ShortcutsEnabled = true;
            this.nom.Size = new System.Drawing.Size(117, 23);
            this.nom.TabIndex = 13;
            this.nom.UseSelectable = true;
            this.nom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // prenom
            // 
            // 
            // 
            // 
            this.prenom.CustomButton.Image = null;
            this.prenom.CustomButton.Location = new System.Drawing.Point(95, 1);
            this.prenom.CustomButton.Name = "";
            this.prenom.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.prenom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.prenom.CustomButton.TabIndex = 1;
            this.prenom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.prenom.CustomButton.UseSelectable = true;
            this.prenom.CustomButton.Visible = false;
            this.prenom.Enabled = false;
            this.prenom.Lines = new string[0];
            this.prenom.Location = new System.Drawing.Point(300, 68);
            this.prenom.MaxLength = 32767;
            this.prenom.Name = "prenom";
            this.prenom.PasswordChar = '\0';
            this.prenom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.prenom.SelectedText = "";
            this.prenom.SelectionLength = 0;
            this.prenom.SelectionStart = 0;
            this.prenom.ShortcutsEnabled = true;
            this.prenom.Size = new System.Drawing.Size(117, 23);
            this.prenom.TabIndex = 14;
            this.prenom.UseSelectable = true;
            this.prenom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.prenom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(23, 17);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(215, 29);
            this.metroDateTime1.TabIndex = 9;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 19);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(573, 150);
            this.dataGridView3.TabIndex = 10;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView3);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox4.Location = new System.Drawing.Point(23, 544);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(585, 179);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Commande";
            // 
            // groupBox_opération
            // 
            this.groupBox_opération.BackColor = System.Drawing.Color.White;
            this.groupBox_opération.Controls.Add(this.btn_supprimer);
            this.groupBox_opération.Controls.Add(this.btn_ajouter);
            this.groupBox_opération.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_opération.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox_opération.Location = new System.Drawing.Point(614, 544);
            this.groupBox_opération.Name = "groupBox_opération";
            this.groupBox_opération.Size = new System.Drawing.Size(370, 179);
            this.groupBox_opération.TabIndex = 107;
            this.groupBox_opération.TabStop = false;
            this.groupBox_opération.Text = "Opération Article";
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.BackColor = System.Drawing.Color.White;
            this.btn_supprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_supprimer.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_supprimer.Image = ((System.Drawing.Image)(resources.GetObject("btn_supprimer.Image")));
            this.btn_supprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_supprimer.Location = new System.Drawing.Point(204, 56);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(121, 58);
            this.btn_supprimer.TabIndex = 42;
            this.btn_supprimer.Text = "         Annuler";
            this.btn_supprimer.UseVisualStyleBackColor = false;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.BackColor = System.Drawing.Color.White;
            this.btn_ajouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ajouter.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ajouter.Image = ((System.Drawing.Image)(resources.GetObject("btn_ajouter.Image")));
            this.btn_ajouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ajouter.Location = new System.Drawing.Point(31, 56);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(123, 58);
            this.btn_ajouter.TabIndex = 0;
            this.btn_ajouter.Text = "            Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = false;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.tva);
            this.groupBox5.Controls.Add(this.btn_clc);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.txt_montant_total);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.txt_montant_tva);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.txt_montant_htva);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox5.Location = new System.Drawing.Point(25, 729);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(583, 215);
            this.groupBox5.TabIndex = 108;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Total";
            // 
            // tva
            // 
            // 
            // 
            // 
            this.tva.CustomButton.Image = null;
            this.tva.CustomButton.Location = new System.Drawing.Point(13, 1);
            this.tva.CustomButton.Name = "";
            this.tva.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tva.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tva.CustomButton.TabIndex = 1;
            this.tva.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tva.CustomButton.UseSelectable = true;
            this.tva.CustomButton.Visible = false;
            this.tva.Lines = new string[] {
        "0"};
            this.tva.Location = new System.Drawing.Point(350, 25);
            this.tva.MaxLength = 32767;
            this.tva.Name = "tva";
            this.tva.PasswordChar = '\0';
            this.tva.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tva.SelectedText = "";
            this.tva.SelectionLength = 0;
            this.tva.SelectionStart = 0;
            this.tva.ShortcutsEnabled = true;
            this.tva.Size = new System.Drawing.Size(35, 23);
            this.tva.TabIndex = 80;
            this.tva.Text = "0";
            this.tva.UseSelectable = true;
            this.tva.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tva.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tva.TextChanged += new System.EventHandler(this.tva_TextChanged);
            this.tva.Click += new System.EventHandler(this.tva_Click);
            // 
            // btn_clc
            // 
            this.btn_clc.Location = new System.Drawing.Point(437, 73);
            this.btn_clc.Name = "btn_clc";
            this.btn_clc.Size = new System.Drawing.Size(104, 29);
            this.btn_clc.TabIndex = 79;
            this.btn_clc.Text = "Calculer";
            this.btn_clc.UseSelectable = true;
            this.btn_clc.Click += new System.EventHandler(this.btn_clc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(332, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 78;
            this.label3.Text = "*          %";
            // 
            // txt_montant_total
            // 
            this.txt_montant_total.Enabled = false;
            this.txt_montant_total.Location = new System.Drawing.Point(159, 110);
            this.txt_montant_total.Multiline = true;
            this.txt_montant_total.Name = "txt_montant_total";
            this.txt_montant_total.Size = new System.Drawing.Size(165, 27);
            this.txt_montant_total.TabIndex = 76;
            this.txt_montant_total.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(17, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 19);
            this.label12.TabIndex = 75;
            this.label12.Text = "Montant Total TTC :";
            // 
            // txt_montant_tva
            // 
            this.txt_montant_tva.Enabled = false;
            this.txt_montant_tva.Location = new System.Drawing.Point(163, 52);
            this.txt_montant_tva.Multiline = true;
            this.txt_montant_tva.Name = "txt_montant_tva";
            this.txt_montant_tva.Size = new System.Drawing.Size(161, 27);
            this.txt_montant_tva.TabIndex = 68;
            this.txt_montant_tva.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 19);
            this.label1.TabIndex = 67;
            this.label1.Text = "Montant  totale TVA :";
            // 
            // txt_montant_htva
            // 
            this.txt_montant_htva.Enabled = false;
            this.txt_montant_htva.Location = new System.Drawing.Point(162, 19);
            this.txt_montant_htva.Multiline = true;
            this.txt_montant_htva.Name = "txt_montant_htva";
            this.txt_montant_htva.Size = new System.Drawing.Size(162, 27);
            this.txt_montant_htva.TabIndex = 66;
            this.txt_montant_htva.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(17, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(147, 19);
            this.label18.TabIndex = 65;
            this.label18.Text = "Montant totale HTVA :";
            // 
            // btn_imprimer
            // 
            this.btn_imprimer.BackColor = System.Drawing.Color.White;
            this.btn_imprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_imprimer.Enabled = false;
            this.btn_imprimer.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_imprimer.Image = ((System.Drawing.Image)(resources.GetObject("btn_imprimer.Image")));
            this.btn_imprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_imprimer.Location = new System.Drawing.Point(58, 95);
            this.btn_imprimer.Name = "btn_imprimer";
            this.btn_imprimer.Size = new System.Drawing.Size(178, 55);
            this.btn_imprimer.TabIndex = 109;
            this.btn_imprimer.Text = "Imprimer Devis";
            this.btn_imprimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_imprimer.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(186, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 55);
            this.button1.TabIndex = 110;
            this.button1.Text = "  Imprimer Facture";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(6, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 53);
            this.button2.TabIndex = 111;
            this.button2.Text = "         Ennregistrer ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.White;
            this.groupBox6.Controls.Add(this.button3);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Controls.Add(this.btn_imprimer);
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox6.Location = new System.Drawing.Point(614, 729);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(370, 215);
            this.groupBox6.TabIndex = 112;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Opération Commande";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(204, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 53);
            this.button3.TabIndex = 112;
            this.button3.Text = "        Vider";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // id_details
            // 
            this.id_details.Enabled = false;
            this.id_details.Location = new System.Drawing.Point(29, 518);
            this.id_details.Name = "id_details";
            this.id_details.Size = new System.Drawing.Size(57, 20);
            this.id_details.TabIndex = 113;
            this.id_details.Visible = false;
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 949);
            this.Controls.Add(this.id_details);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox_opération);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Acceuil";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Acceuil";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Acceuil_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rech_ref)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox_opération.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox type;
        private MetroFramework.Controls.MetroTextBox txtbox_metrage;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox combo_epai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionMarbreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionGranitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestionDesClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quiterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionMarbreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem suiviCommandeToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MetroFramework.Controls.MetroTextBox adresse;
        private MetroFramework.Controls.MetroTextBox prenom;
        private MetroFramework.Controls.MetroTextBox nom;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox cin;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox_opération;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button off;
        private System.Windows.Forms.PictureBox rech_ref;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox libele;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox total_article;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox qt;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox prix_produit;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txt_montant_total;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_montant_tva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_montant_htva;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_imprimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox id_details;
        private MetroFramework.Controls.MetroButton btn_clc;
        private MetroFramework.Controls.MetroTextBox tva;
        private System.Windows.Forms.Button button3;
    }
}