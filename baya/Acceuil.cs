using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
namespace baya
{
    public partial class Acceuil : MetroForm
        
    {
        Chargementfichier x = new Chargementfichier();
        Chargementfichier y = new Chargementfichier();
        Chargementfichier z = new Chargementfichier();
        public Acceuil()
        {
            InitializeComponent();
            this.BorderStyle = MetroFormBorderStyle.FixedSingle;
            this.ShadowType = MetroFormShadowType.AeroShadow;

        }
       

        private void Acceuil_Load(object sender, EventArgs e)
        {
            //x.ChargementComboBox("select valeur from tva",combo_tva);
            y.ChargementComboBox("select valeur from epaisseur", combo_epai);
            z.ChargementComboBox("select type from typemarbre", type);
            chargementclient();
            chargementdetail();


        }
        private void chargementgrid()
        {
            //chargement de datagridview

            Connexion.cmd.CommandText = "Select * from marbre ";
            MySqlDataAdapter da = new MySqlDataAdapter(Connexion.cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "marbre");
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = ds.Tables["marbre"];
           dataGridView1.DataSource = dt;
            Connexion.cnx.Close();

        }
        private void chargementclient()
        {
            //chargement de datagridview

            Connexion.cmd.CommandText = "Select nom,prenom,cin,adresse from client ";
            MySqlDataAdapter da = new MySqlDataAdapter(Connexion.cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "client");
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = ds.Tables["client"];
            dataGridView2.DataSource = dt;
            Connexion.cnx.Close();

        }
        private void chargementgrid2()
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
        private void chargementdetail()
        {
            //chargement de datagridview

            Connexion.cmd.CommandText = "Select * from details ";
            MySqlDataAdapter da = new MySqlDataAdapter(Connexion.cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "details");
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = ds.Tables["details"];
            dataGridView3.DataSource = dt;
            Connexion.cnx.Close();

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type.SelectedItem.ToString()=="Marbre")
            {
                chargementgrid();
            }
            else if (type.SelectedItem.ToString()== "Granit") 
            {
                chargementgrid2();

            }
            else
            {
                MessageBox.Show("Veuillez choisir un type", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gestionMarbreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gestionDesClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            client mp = new client();
            mp.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
            Granit ac = new Granit();
            ac.Show();
        }

        private void combo_epai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            nom.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            prenom.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            adresse.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            cin.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void rech_ref_Click(object sender, EventArgs e)
        {
            off.Visible = true;
            dataGridView2.Visible = true;
        }

        private void off_Click(object sender, EventArgs e)
        {
            off.Visible = false;
            dataGridView2.Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            libele.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            prix_produit.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
           
        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void txt_montant_ttc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            int o;
            if ((int.TryParse(txtbox_metrage.Text, out o)) || txtbox_metrage.Text == "" || libele.Text == "" || qt.Text == "" || cin.Text == "" || prix_produit.Text == "")
                { 
                    MessageBox.Show("vérifier les champs !!", "Alerte champs vides", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("Champs métrage non valide, il doit étre numérique ", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else
            {
                try
                {
                    

                    Connexion.cnx.Close();
                    Connexion.cnx.Open();
                    Connexion.cmd.CommandText = "insert into details(type,metrage,epaisseur,designation,quantite,prix,prix_tt,cin)values('" + type.Text.ToString() + "','" + txtbox_metrage.Text.ToString() + "','" + combo_epai.Text.ToString() + "','" + libele.Text.ToString() + "','" + qt.Text.ToString() + "','" + prix_produit.Text.ToString() + "','" + total_article.Text.ToString() + "','" + cin.Text.ToString() + "')";
                    Connexion.cmd.ExecuteNonQuery();

                    //chargement de datagridview
                    Connexion.cmd.CommandText = "Select * from details";
                    MySqlDataAdapter da = new MySqlDataAdapter(Connexion.cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "details");
                    DataTable dt = new DataTable();
                    dt = ds.Tables["details"];
                    dataGridView3.DataSource = dt;

                    txtbox_metrage.Text = "";
                    libele.Text = "";
                    prix_produit.Text = "";
                    total_article.Text = "";

                    MessageBox.Show("Produit Ajouté(e) avec succé", "Détails de la commande", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Connexion.cnx.Close();

                }
                catch (Exception p)
                {

                    MessageBox.Show("Echec de connexion à la base de donnée : " + "==>" + p.Message);
                }
            }
            

        }

        private void qt_TextChanged(object sender, EventArgs e)
        {
            total_article.Text = (float.Parse(txtbox_metrage.Text.ToString()) * float.Parse(prix_produit.Text.ToString()) * float.Parse(qt.Text.ToString())).ToString();
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {

        }
    }
}
