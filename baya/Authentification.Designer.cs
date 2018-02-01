namespace baya
{
    partial class Authentification
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtbox_login = new MetroFramework.Controls.MetroTextBox();
            this.txtbox_pwd = new MetroFramework.Controls.MetroTextBox();
            this.btn_cnx = new MetroFramework.Controls.MetroButton();
            this.btn_anu = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(55, 115);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(116, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nom d\'utilisateur :";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(55, 173);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(95, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Mot de passe :";
            // 
            // txtbox_login
            // 
            // 
            // 
            // 
            this.txtbox_login.CustomButton.Image = null;
            this.txtbox_login.CustomButton.Location = new System.Drawing.Point(220, 1);
            this.txtbox_login.CustomButton.Name = "";
            this.txtbox_login.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbox_login.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbox_login.CustomButton.TabIndex = 1;
            this.txtbox_login.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbox_login.CustomButton.UseSelectable = true;
            this.txtbox_login.CustomButton.Visible = false;
            this.txtbox_login.Lines = new string[0];
            this.txtbox_login.Location = new System.Drawing.Point(204, 111);
            this.txtbox_login.MaxLength = 32767;
            this.txtbox_login.Name = "txtbox_login";
            this.txtbox_login.PasswordChar = '\0';
            this.txtbox_login.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbox_login.SelectedText = "";
            this.txtbox_login.SelectionLength = 0;
            this.txtbox_login.SelectionStart = 0;
            this.txtbox_login.ShortcutsEnabled = true;
            this.txtbox_login.Size = new System.Drawing.Size(242, 23);
            this.txtbox_login.TabIndex = 2;
            this.txtbox_login.UseSelectable = true;
            this.txtbox_login.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbox_login.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtbox_pwd
            // 
            // 
            // 
            // 
            this.txtbox_pwd.CustomButton.Image = null;
            this.txtbox_pwd.CustomButton.Location = new System.Drawing.Point(220, 1);
            this.txtbox_pwd.CustomButton.Name = "";
            this.txtbox_pwd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbox_pwd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbox_pwd.CustomButton.TabIndex = 1;
            this.txtbox_pwd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbox_pwd.CustomButton.UseSelectable = true;
            this.txtbox_pwd.CustomButton.Visible = false;
            this.txtbox_pwd.Lines = new string[0];
            this.txtbox_pwd.Location = new System.Drawing.Point(204, 173);
            this.txtbox_pwd.MaxLength = 32767;
            this.txtbox_pwd.Name = "txtbox_pwd";
            this.txtbox_pwd.PasswordChar = '*';
            this.txtbox_pwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbox_pwd.SelectedText = "";
            this.txtbox_pwd.SelectionLength = 0;
            this.txtbox_pwd.SelectionStart = 0;
            this.txtbox_pwd.ShortcutsEnabled = true;
            this.txtbox_pwd.Size = new System.Drawing.Size(242, 23);
            this.txtbox_pwd.TabIndex = 3;
            this.txtbox_pwd.UseSelectable = true;
            this.txtbox_pwd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbox_pwd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_cnx
            // 
            this.btn_cnx.Location = new System.Drawing.Point(204, 236);
            this.btn_cnx.Name = "btn_cnx";
            this.btn_cnx.Size = new System.Drawing.Size(75, 23);
            this.btn_cnx.TabIndex = 4;
            this.btn_cnx.Text = "Connexion";
            this.btn_cnx.UseSelectable = true;
            this.btn_cnx.Click += new System.EventHandler(this.btn_cnx_Click);
            // 
            // btn_anu
            // 
            this.btn_anu.Location = new System.Drawing.Point(343, 236);
            this.btn_anu.Name = "btn_anu";
            this.btn_anu.Size = new System.Drawing.Size(75, 23);
            this.btn_anu.TabIndex = 5;
            this.btn_anu.Text = "Annuler";
            this.btn_anu.UseSelectable = true;
            this.btn_anu.Click += new System.EventHandler(this.btn_anu_Click);
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 292);
            this.Controls.Add(this.btn_anu);
            this.Controls.Add(this.btn_cnx);
            this.Controls.Add(this.txtbox_pwd);
            this.Controls.Add(this.txtbox_login);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Authentification";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Authentification";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Authentification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtbox_login;
        private MetroFramework.Controls.MetroTextBox txtbox_pwd;
        private MetroFramework.Controls.MetroButton btn_cnx;
        private MetroFramework.Controls.MetroButton btn_anu;
    }
}