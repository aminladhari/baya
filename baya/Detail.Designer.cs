namespace baya
{
    partial class Detail
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.acceuilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionMarbreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionGranitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionMarbreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suiviCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toutesLesCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.détailsCommandeParClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(699, 400);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acceuilToolStripMenuItem,
            this.gestionMarbreToolStripMenuItem,
            this.suiviCommandeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(705, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // acceuilToolStripMenuItem
            // 
            this.acceuilToolStripMenuItem.Name = "acceuilToolStripMenuItem";
            this.acceuilToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.acceuilToolStripMenuItem.Text = "Acceuil";
            this.acceuilToolStripMenuItem.Click += new System.EventHandler(this.acceuilToolStripMenuItem_Click);
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
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(551, 87);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(171, 23);
            this.metroTextBox1.TabIndex = 15;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox1.TextChanged += new System.EventHandler(this.metroTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(451, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 111;
            this.label1.Text = "Nom Client :";
            // 
            // Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 547);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.MinimizeBox = false;
            this.Name = "Detail";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Détails commande";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acceuilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionMarbreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionGranitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestionMarbreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestionDesClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quiterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suiviCommandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toutesLesCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem détailsCommandeParClientToolStripMenuItem;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.Label label1;
    }
}