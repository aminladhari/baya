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
    public partial class Commande : MetroForm
    {
        public Commande()
        {
            InitializeComponent();
        }

        private void Commande_Load(object sender, EventArgs e)
        {
            chargementgrid();
        }

              private void chargementgrid()
        {
            //chargement de datagridview

            Connexion.cmd.CommandText = "Select nom_premnom,cin,totale_htva,tva,totale_tva,totoale_ttc,date from commande ";
            MySqlDataAdapter da = new MySqlDataAdapter(Connexion.cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "commande");
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = ds.Tables["commande"];
            dataGridView2.DataSource = dt;
            Connexion.cnx.Close();

        }

        private void acceuilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Acceuil ac = new Acceuil();
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
    }
    
}
