namespace baya
{
    partial class Commande
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(9, 98);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(966, 479);
            this.dataGridView2.TabIndex = 1;
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
            this.menuStrip1.Size = new System.Drawing.Size(958, 24);
            this.menuStrip1.TabIndex = 15;
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
            // Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 615);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Commande";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Commande";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Commande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionMarbreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionGranitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestionMarbreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestionDesClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quiterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suiviCommandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toutesLesCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem détailsCommandeParClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acceuilToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}