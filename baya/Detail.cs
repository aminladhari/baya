﻿using MetroFramework.Forms;
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
    public partial class Detail : MetroForm
    {
        public Detail()
        {
            InitializeComponent();
        }

        private void Detail_Load(object sender, EventArgs e)
        {
            chargementgrid();
        }
        private void chargementgrid()
        {
            //chargement de datagridview
            Connexion.cnx.Close();
            Connexion.cnx.Open();
            Connexion.cmd.CommandText = "Select * from detail_commande ";
            MySqlDataAdapter da = new MySqlDataAdapter(Connexion.cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "detail_commande");
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = ds.Tables["detail_commande"];
            dataGridView1.DataSource = dt;
            Connexion.cnx.Close();

        }

        private void toutesLesCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Commande ac = new Commande();
            ac.Show();

        }

        private void détailsCommandeParClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Detail ac = new Detail();
            ac.Show();
        }

        private void gestionGranitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Granit ac = new Granit();
            ac.Show();
        }

        private void gestionMarbreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Marbre ac = new Marbre();
            ac.Show();
        }

        private void gestionDesClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            client ac = new client();
            ac.Show();
        }

        private void quiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acceuilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Acceuil ac = new Acceuil();
            ac.Show();
        }

        private void rech_ref_Click(object sender, EventArgs e)
        {
           
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            Connexion.cnx.Close();
            Connexion.cnx.Open();
            Connexion.cmd.CommandText = "select * from detail_commande where nom_prenom LIKE '%' '" + metroTextBox1.Text + "' '%' ";
            MySqlDataReader lire = Connexion.cmd.ExecuteReader();
            if (lire.Read() == true)
            {
                Connexion.cnx.Close();
                Connexion.cnx.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(Connexion.cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "detail_commande");
                System.Data.DataTable dt = new System.Data.DataTable();
                dt = ds.Tables["detail_commande"];
                dataGridView1.DataSource = dt;
                Connexion.cnx.Close();
            }
            else
            {
                MessageBox.Show("Vérifier le nom du client sa n'existe pas", "Détails de la commande", MessageBoxButtons.OK, MessageBoxIcon.Information);
                chargementgrid();
            }

        }

        private void acceuilToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Acceuil ac = new Acceuil();
            ac.Show();
        }
    }
}
