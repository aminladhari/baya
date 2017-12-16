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
    public partial class Granit : MetroForm
    {
        public Granit()
        {
            InitializeComponent();
        }

        private void Granit_Load(object sender, EventArgs e)
        {
            chargementgrid();
        }
        private void chargementgrid()
        {
            //chargement de datagridview

            Connexion.cmd.CommandText = "Select * from granit ";
            MySqlDataAdapter da = new MySqlDataAdapter(Connexion.cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "granit");
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = ds.Tables["granit"];
            dataGridView1.DataSource = dt;
            Connexion.cnx.Close();

        }

        private void acceuilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Acceuil ac = new Acceuil();
            ac.Show();
        }

        private void quiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gestionGranitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Granit ac = new Granit();
            ac.Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text = "";
            metroTextBox2.Text = "";
            metroTextBox3.Text = "";
        }

        private void gestionDesClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            client ac = new client();
            ac.Show();
        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            int o;
            if ((metroTextBox1.Text == "") || (metroTextBox2.Text == "")||(metroTextBox3.Text=="")|| (int.TryParse(metroTextBox2.Text, out o) == false))
            {
                MessageBox.Show("Veuillez remplir les champs", "Champ(s)vide", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                MessageBox.Show("Champs non valide doit étre numérique", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                metroTextBox2.Text = "11111";
                metroTextBox3.Text = "11111";
                metroTextBox1.Focus();
                metroTextBox2.Focus();
                metroTextBox3.Focus();

                if ((metroTextBox1.Text == "") && (metroTextBox2.Text == "")&&(metroTextBox3.Text == "") )
                {

                    metroTextBox1.Focus();
                    metroTextBox2.Focus();
                    metroTextBox3.Focus();



                }
            }
            else
            {


                // code pour lire le num cin et controler si client existe ou pas ?
                Connexion.cnx.Close();
                Connexion.cnx.Open();
                Connexion.cmd.CommandText = "select * from granit where designation='" + metroTextBox1.Text.ToString() + "'";
                MySqlDataReader lire = Connexion.cmd.ExecuteReader();
                if (lire.Read() == true)
                {
                    MessageBox.Show("Produit deja existe", " type de Granit", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }

                else
                {
                    metroTextBox1.BackColor = Color.White;
                    metroTextBox2.BackColor = Color.White;
                    

                    try
                    {
                        lire.Close();


                        Connexion.cmd.CommandText = "insert into granit(designation,prix_2cm,prix_3cm)values('" + metroTextBox1.Text.ToString() + "','" + metroTextBox2.Text.ToString() + "','" + metroTextBox3.Text.ToString() + "')";
                        Connexion.cmd.ExecuteNonQuery();



                        //chargement de datagridview
                        Connexion.cmd.CommandText = "Select * from granit";
                        MySqlDataAdapter da = new MySqlDataAdapter(Connexion.cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "granit");
                        DataTable dt = new DataTable();
                        dt = ds.Tables["granit"];
                        dataGridView1.DataSource = dt;

                        metroTextBox1.Text = "";
                        metroTextBox2.Text = "";
                        metroTextBox3.Text = "";


                        MessageBox.Show("Type Ajouté(e) avec succé", "Ajout produit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Connexion.cnx.Close();

                    }
                    catch (Exception p)
                    {

                        MessageBox.Show("Echec de connexion à la base de donnée : " + "==>" + p.Message);
                    }

                }
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            metroTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            metroTextBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            metroTextBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            if ((metroTextBox1.Text == "") || (metroTextBox2.Text == "") || (metroTextBox3.Text == ""))
            {
                MessageBox.Show("Veuillez remplir les champs", "Champ(s)vide", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                Connexion.cnx.Close();
                Connexion.cnx.Open();
                Connexion.cmd.CommandText = "update granit set designation ='" + metroTextBox1.Text.ToString() + "',prix_2cm='" + metroTextBox2.Text.ToString() + "',prix_3cm='"+metroTextBox3.Text.ToString()+"' where idgranit ='" + id.Text.ToString() + "' ";
                Connexion.cmd.ExecuteNonQuery();
                MessageBox.Show("Type modifié(e) avec succé", "Modification produit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                chargementgrid();
                metroTextBox1.Text = "";
                metroTextBox2.Text = "";
                metroTextBox3.Text = "";

            }
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            if ((metroTextBox1.Text == "") || (metroTextBox2.Text == "") || (metroTextBox3.Text == ""))
            {
                MessageBox.Show("Veuillez remplir les champs", "Champ(s)vide", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                metroTextBox1.Focus();
                metroTextBox2.Focus();
                metroTextBox3.Focus();

                MessageBox.Show("Selectionner un produit", "Champs vides", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


            else
            {
                Connexion.cnx.Close();
                Connexion.cnx.Open();


                DialogResult reponse;
                reponse = MessageBox.Show("êtes_vous_sûr de supprimer le produit ?", "Confirmer la Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                //code si oui confirmer la suppression
                if (reponse == System.Windows.Forms.DialogResult.Yes)
                {
                    Connexion.cmd.CommandText = "delete from granit   where idgranit='" + id.Text.ToString() + "'";
                    Connexion.cmd.ExecuteNonQuery();
                    metroTextBox1.Text = "";
                    metroTextBox2.Text = "";
                    metroTextBox3.Text = "";
                    id.Text = "";
              
                    chargementgrid();
                }
            }
        }

        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void gestionMarbreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Marbre ac = new Marbre();
            ac.Show();
        }

        private void suiviCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Commande ac = new Commande();
            ac.Show();
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
    }
}
