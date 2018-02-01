namespace baya
{
    partial class Granit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Granit));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionMarbreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acceuilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gestionGranitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionMarbreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suiviCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toutesLesCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.détailsCommandeParClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btn_delete = new MetroFramework.Controls.MetroButton();
            this.btn_update = new MetroFramework.Controls.MetroButton();
            this.btn_add = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(871, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionMarbreToolStripMenuItem
            // 
            this.gestionMarbreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acceuilToolStripMenuItem,
            this.toolStripSeparator2,
            this.gestionGranitToolStripMenuItem1,
            this.gestionMarbreToolStripMenuItem1,
            this.gestionDesClientsToolStripMenuItem,
            this.toolStripSeparator1,
            this.quiterToolStripMenuItem});
            this.gestionMarbreToolStripMenuItem.Name = "gestionMarbreToolStripMenuItem";
            this.gestionMarbreToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gestionMarbreToolStripMenuItem.Text = "Menu";
            // 
            // acceuilToolStripMenuItem
            // 
            this.acceuilToolStripMenuItem.Name = "acceuilToolStripMenuItem";
            this.acceuilToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.acceuilToolStripMenuItem.Text = "Acceuil";
            this.acceuilToolStripMenuItem.Click += new System.EventHandler(this.acceuilToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(169, 6);
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
            this.suiviCommandeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toutesLesCommandesToolStripMenuItem,
            this.détailsCommandeParClientToolStripMenuItem});
            this.suiviCommandeToolStripMenuItem.Name = "suiviCommandeToolStripMenuItem";
            this.suiviCommandeToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.suiviCommandeToolStripMenuItem.Text = "Suivi ";
            // 
            // toutesLesCommandesToolStripMenuItem
            // 
            this.toutesLesCommandesToolStripMenuItem.Name = "toutesLesCommandesToolStripMenuItem";
            this.toutesLesCommandesToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.toutesLesCommandesToolStripMenuItem.Text = "Toutes les commandes";
            this.toutesLesCommandesToolStripMenuItem.Click += new System.EventHandler(this.toutesLesCommandesToolStripMenuItem_Click);
            // 
            // détailsCommandeParClientToolStripMenuItem
            // 
            this.détailsCommandeParClientToolStripMenuItem.Name = "détailsCommandeParClientToolStripMenuItem";
            this.détailsCommandeParClientToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.détailsCommandeParClientToolStripMenuItem.Text = "Détails commande par client";
            this.détailsCommandeParClientToolStripMenuItem.Click += new System.EventHandler(this.détailsCommandeParClientToolStripMenuItem_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(541, 222);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(119, 23);
            this.metroButton1.TabIndex = 22;
            this.metroButton1.Text = "Vider les champs";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_delete.BackgroundImage")));
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_delete.Location = new System.Drawing.Point(662, 135);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 58);
            this.btn_delete.TabIndex = 21;
            this.btn_delete.Text = "Supprimer";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_delete.UseSelectable = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click_1);
            // 
            // btn_update
            // 
            this.btn_update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_update.BackgroundImage")));
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_update.Location = new System.Drawing.Point(568, 135);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 58);
            this.btn_update.TabIndex = 20;
            this.btn_update.Text = "Modifier";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_update.UseSelectable = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click_1);
            // 
            // btn_add
            // 
            this.btn_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_add.BackgroundImage")));
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_add.Location = new System.Drawing.Point(470, 135);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 58);
            this.btn_add.TabIndex = 19;
            this.btn_add.Text = "Ajouter";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_add.UseSelectable = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_1);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(60, 183);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 19);
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "Prix 2Cm :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(60, 139);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 19);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "Désignation :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(707, 309);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(220, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(170, 179);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(242, 23);
            this.metroTextBox2.TabIndex = 15;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox2.TextChanged += new System.EventHandler(this.metroTextBox2_TextChanged);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(220, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(170, 135);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(242, 23);
            this.metroTextBox1.TabIndex = 14;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(170, 99);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(53, 20);
            this.id.TabIndex = 23;
            this.id.Visible = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(60, 226);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(70, 19);
            this.metroLabel3.TabIndex = 25;
            this.metroLabel3.Text = "Prix 3Cm :";
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(220, 1);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.Lines = new string[0];
            this.metroTextBox3.Location = new System.Drawing.Point(170, 222);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(242, 23);
            this.metroTextBox3.TabIndex = 24;
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Granit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 613);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroTextBox3);
            this.Controls.Add(this.id);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Granit";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Granit";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Granit_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionMarbreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionGranitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestionMarbreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quiterToolStripMenuItem;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btn_delete;
        private MetroFramework.Controls.MetroButton btn_update;
        private MetroFramework.Controls.MetroButton btn_add;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.ToolStripMenuItem gestionDesClientsToolStripMenuItem;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.ToolStripMenuItem suiviCommandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toutesLesCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem détailsCommandeParClientToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private System.Windows.Forms.ToolStripMenuItem acceuilToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}