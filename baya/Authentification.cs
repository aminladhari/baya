using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baya
{
    public partial class Authentification : MetroForm
    {
        public Authentification()
        {
            InitializeComponent();
        }

        private void Authentification_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btn_anu_Click(object sender, EventArgs e)
        {
            txtbox_login.Text = "";
            txtbox_pwd.Text = "";
        }

        private void btn_cnx_Click(object sender, EventArgs e)
        {
            //Connexion.cnx.Close();
            //Connexion.cmd.CommandTimeout = 60;
            try
            {

                Connexion.cnx.Open();
                Connexion.cmd.CommandText = "select * from utilisateur where login='" + txtbox_login.Text.ToString() + "' and  mdp='" + txtbox_pwd.Text.ToString() + "'";
                MySqlDataReader lire = Connexion.cmd.ExecuteReader();
                txtbox_login.BackColor = Color.White;
                txtbox_pwd.BackColor = Color.White;
                if ((txtbox_login.Text == "") || (txtbox_pwd.Text == ""))
                {



                    MessageBox.Show("Login ou mot de passe vide", "Champ(s) Vide", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtbox_login.BackColor = Color.Red;
                    txtbox_pwd.BackColor = Color.Red;

                }
                else
                {
                    if (lire.Read() == true)
                    {

                        Acceuil mp = new Acceuil();
                        mp.Show();
                        this.Hide();
                    }
                    else
                    {

                        txtbox_pwd.Focus();
                        txtbox_login.BackColor = Color.Red;
                        txtbox_pwd.BackColor = Color.Red;

                        MessageBox.Show("Erreur login ou mot de passe", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    txtbox_login.Text = "";
                    txtbox_pwd.Text = "";
                    txtbox_login.BackColor = Color.White;
                    txtbox_pwd.BackColor = Color.White;
                }


                Connexion.cnx.Close();
            }
            catch (Exception p)
            {

                MessageBox.Show("Echec de connexion à la base de donnée : " + "==>" + p.Message);


            }
        }
    }
}
