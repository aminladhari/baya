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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.type = new MetroFramework.Controls.MetroComboBox();
            this.txtbox_metrage = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(29, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(43, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Type :";
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.ItemHeight = 23;
            this.type.Location = new System.Drawing.Point(109, 58);
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
            this.txtbox_metrage.Location = new System.Drawing.Point(372, 64);
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
            this.metroLabel2.Location = new System.Drawing.Point(262, 64);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(87, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Métrage m² :";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combo_epai);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.type);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.txtbox_metrage);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(23, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 143);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cordonnées Commande";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // combo_epai
            // 
            this.combo_epai.FormattingEnabled = true;
            this.combo_epai.ItemHeight = 23;
            this.combo_epai.Location = new System.Drawing.Point(680, 54);
            this.combo_epai.Name = "combo_epai";
            this.combo_epai.Size = new System.Drawing.Size(121, 29);
            this.combo_epai.TabIndex = 8;
            this.combo_epai.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(561, 64);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(95, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Epaisseur Cm :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(126, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(656, 190);
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
            this.dataGridView1.Location = new System.Drawing.Point(56, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(584, 150);
            this.dataGridView1.TabIndex = 0;
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
            this.menuStrip1.Size = new System.Drawing.Size(931, 24);
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
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 652);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}