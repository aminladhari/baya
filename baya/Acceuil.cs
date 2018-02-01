using MetroFramework;
using MetroFramework.Forms;
using Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
namespace baya
{
    public partial class Acceuil : MetroForm

    {
        string aa;
        string bb;
        Chargementfichier x = new Chargementfichier();
        Chargementfichier y = new Chargementfichier();
        Chargementfichier z = new Chargementfichier();
        Decimal somme;
       
        public Acceuil()
        {
            InitializeComponent();
            this.BorderStyle = MetroFormBorderStyle.FixedSingle;
            this.ShadowType = MetroFormShadowType.AeroShadow;

        }


        private void Acceuil_Load(object sender, EventArgs e)
        {
            //code numero facture
            Connexion.cnx.Close();
            Connexion.cnx.Open();
            Connexion.cmd.CommandText = "select * from commande order by id desc";
            // data reader pour lire 
            MySqlDataReader lire = Connexion.cmd.ExecuteReader();
            if (lire.Read() == true)
            {

                numfac.Text = (int.Parse(lire[0].ToString()) + 1).ToString();
            }
            else
            {
                numfac.Text = "1";

            }
            lire.Close();
            Connexion.cnx.Close();
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
            if (type.SelectedItem.ToString() == "Marbre")
            {
                chargementgrid();
            }
            else if (type.SelectedItem.ToString() == "Granit")
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
            System.Windows.Forms.Application.Exit();
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
            Marbre ac = new Marbre();
            ac.Show();
        }

        private void combo_epai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_epai.SelectedItem.ToString() == "2")
            {
                prix_produit.Text = aa;
            }
            else if (combo_epai.SelectedItem.ToString() == "3")
            {
                prix_produit.Text = bb;

            }
            else
            {
                MessageBox.Show("Veuillez choisir un épaisseur", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            aa= dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(); 
            bb= dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();


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
            if ((int.TryParse(txtbox_metrage.Text, out o)) || txtbox_metrage.Text == "" || libele.Text == "" || textBox1.Text == "" || cin.Text == "" || prix_produit.Text == "")
            {
                MessageBox.Show("vérifier les champs !!", "Alerte champs vides", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Champs métrage non valide, il doit étre numérique et contient une virgule ", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("vérifier Cordonnées clients ", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {


                    Connexion.cnx.Close();
                    Connexion.cnx.Open();
                    Connexion.cmd.CommandText = "insert into details(type,metrage,epaisseur,designation,quantite,prix,prix_tt,cin)values('" + type.Text.ToString() + "','" + txtbox_metrage.Text.ToString() + "','" + combo_epai.Text.ToString() + "','" + libele.Text.ToString() + "','" + textBox1.Text.ToString() + "','" + prix_produit.Text.ToString() + "','" + total_article.Text.ToString() + "','" + cin.Text.ToString() + "')";
                    Connexion.cmd.ExecuteNonQuery();
                    Connexion.cnx.Close();
                    Connexion.cnx.Open();
                    String npr = nom.Text.ToString() + " " + prenom.Text.ToString();
                    Connexion.cmd.CommandText = "insert into detail_commande(type,metrage,epaisseur,designation,quantite,prix,prix_tt,cin,nom_prenom)values('" + type.Text.ToString() + "','" + txtbox_metrage.Text.ToString() + "','" + combo_epai.Text.ToString() + "','" + libele.Text.ToString() + "','" + textBox1.Text.ToString() + "','" + prix_produit.Text.ToString() + "','" + total_article.Text.ToString() + "','" + cin.Text.ToString() + "','" + npr + "')";
                    Connexion.cmd.ExecuteNonQuery();

                    //chargement de datagridview
                    Connexion.cmd.CommandText = "Select * from details";
                    MySqlDataAdapter da = new MySqlDataAdapter(Connexion.cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "details");
                    System.Data.DataTable dt = new System.Data.DataTable();
                    dt = ds.Tables["details"];
                    dataGridView3.DataSource = dt;

                    txtbox_metrage.Text = "";
                    libele.Text = "";
                    prix_produit.Text = "";
                    total_article.Text = "";

                    MessageBox.Show("Produit Ajouté(e) avec succé", "Détails de la commande", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Connexion.cnx.Close();
                    btn_clc.Enabled = true;

                }
                catch (Exception p)
                {

                    MessageBox.Show("Echec de connexion à la base de donnée : " + "==>" + p.Message);
                }

                btn_clc.Enabled = true;
                button1.Enabled = true;
                btn_imprimer.Enabled = true;
                button1.Enabled = true;
                   
            }


        }

        private void qt_TextChanged(object sender, EventArgs e)
        {
            total_article.Text = (float.Parse(txtbox_metrage.Text.ToString()) * float.Parse(prix_produit.Text.ToString()) * float.Parse(textBox1.Text.ToString())).ToString("#.##");
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if(id_details.Text=="")
            {
                MessageBox.Show("Il faut ajouter une commande ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Connexion.cnx.Close();
                Connexion.cnx.Open();
                DialogResult reponse;
                reponse = MessageBox.Show("êtes_vous_sûr de supprimer l'article ?", "Confirmer la Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                //code si oui confirmer la suppression
                if (reponse == System.Windows.Forms.DialogResult.Yes)
                {
                    Connexion.cmd.CommandText = "delete from details   where id_dc='" + id_details.Text.ToString() + "'";
                    Connexion.cmd.ExecuteNonQuery();
                    txtbox_metrage.Text = "";
                    libele.Text = "";
                    prix_produit.Text = "";
                    total_article.Text = "";


                    chargementdetail();
                }
            }
           
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_details.Text = dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString();
        }


       
        private void btn_clc_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {

                somme += Convert.ToDecimal(dataGridView3.Rows[i].Cells[7].Value);

            }

            
            txt_montant_htva.Text =  somme.ToString();
            btn_clc.Enabled = false;
            button2.Enabled = true;

            button2.Enabled = true;
            btn_imprimer.Enabled = true;
            button1.Enabled = true;



        }

        private void tva_Click(object sender, EventArgs e)
        {

        }

        private void tva_TextChanged(object sender, EventArgs e)
        {
            float q = float.Parse(txt_montant_htva.Text.ToString());
            float w = q / 100;
            float wq = w * 18;
            txt_montant_tva.Text = wq.ToString();
            float wqq = wq + q;
            txt_montant_total.Text = wqq.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_montant_htva.Text = "";
            txt_montant_total.Text = "";
            txt_montant_tva.Text = "";
            btn_clc.Enabled = true;
            button2.Enabled = false;
            btn_imprimer.Enabled = false;
            button1.Enabled = false;
            somme = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (txt_montant_htva.Text == "" || txt_montant_total.Text == "" || txt_montant_tva.Text == "" || cin.Text == "")
            {
                MessageBox.Show("vérifier les champs !!", "Alerte champs vides", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                try
                {


                    Connexion.cnx.Close();
                    Connexion.cnx.Open();
                    String npr = nom.Text.ToString() + " " + prenom.Text.ToString();
                    Connexion.cmd.CommandText = "insert into commande(tva,totale_htva,totale_tva,totoale_ttc,date,nom_prenom,cin)values('" + tva.Text.ToString() + "','" + txt_montant_htva.Text.ToString() + "','" + txt_montant_tva.Text.ToString() + "','" + txt_montant_total.Text.ToString() + "','" + metroDateTime1.Text.ToString() + "','"+ npr +"','" + cin.Text.ToString() + "')";
                    Connexion.cmd.ExecuteNonQuery();

                   

                    txtbox_metrage.Text = "";
                    libele.Text = "";
                    prix_produit.Text = "";
                    total_article.Text = "";

                    MessageBox.Show("Commande enregistré", "Commande", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Connexion.cnx.Close();
                    btn_clc.Enabled = true;

                    Connexion.cnx.Open();
                    Connexion.cmd.CommandText = "delete from details   where cin='" + cin.Text.ToString() + "'";
                    Connexion.cmd.ExecuteNonQuery();
                    Connexion.cnx.Close();
                   
                    


                }
                catch (Exception p)
                {

                    MessageBox.Show("Echec de connexion à la base de donnée : " + "==>" + p.Message);
                }

                

            }
        }

        private void suiviCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void qt_Click(object sender, EventArgs e)
        {

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            total_article.Text = (float.Parse(txtbox_metrage.Text.ToString()) * float.Parse(prix_produit.Text.ToString()) * float.Parse(textBox1.Text.ToString())).ToString("#.##");
        }

        private void btn_imprimer_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();

            xla.Visible = true;
            Workbook wb = xla.Workbooks.Open("D:/baya/devis.xlsx");
            Worksheet ws = (Worksheet)xla.ActiveSheet;
            ws.Cells[8, 6] = numfac.Text.ToString();
            ws.Cells[10, 3] = metroDateTime1.Value.ToString();
            ws.Cells[11, 3] = cin.Text.ToString() + " - " + nom.Text.ToString() + " " + prenom.Text.ToString();
           

            for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
            {

               
                ws.Cells[i + 16, 1] = dataGridView3.Rows[i].Cells[1].Value.ToString();
                ws.Cells[i + 16, 2] = dataGridView3.Rows[i].Cells[4].Value.ToString();
                ws.Cells[i + 16, 3] = dataGridView3.Rows[i].Cells[2].Value.ToString()+"m²";
                ws.Cells[i + 16, 4] = dataGridView3.Rows[i].Cells[3].Value.ToString();
                ws.Cells[i + 16, 5] = dataGridView3.Rows[i].Cells[6].Value.ToString();
                ws.Cells[i + 16, 6] = dataGridView3.Rows[i].Cells[5].Value.ToString();
                ws.Cells[i + 16, 7] = float.Parse( dataGridView3.Rows[i].Cells[7].Value.ToString()).ToString("#.##") + "dt";



                //net a payer
               
                ws.Cells[30, 6] = float.Parse(txt_montant_htva.Text.ToString()).ToString("#.##");
                ws.Cells[31, 6] = float.Parse( txt_montant_tva.Text.ToString()).ToString("#.##");
                ws.Cells[32, 6] = float.Parse(txt_montant_total.Text.ToString()).ToString("#.##");

            }
            chargementdetail();
            // lancement de l'impression par default:
            ws.PrintOut(Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();

            xla.Visible = true;
            Workbook wb = xla.Workbooks.Open("D:/baya/facture.xlsx");
            Worksheet ws = (Worksheet)xla.ActiveSheet;
            ws.Cells[8, 6] = numfac.Text.ToString();
            ws.Cells[10, 3] = metroDateTime1.Value.ToString();
            ws.Cells[11, 3] = cin.Text.ToString() + " - " + nom.Text.ToString() + " " + prenom.Text.ToString();


            for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
            {


                ws.Cells[i + 16, 1] = dataGridView3.Rows[i].Cells[1].Value.ToString();
                ws.Cells[i + 16, 2] = dataGridView3.Rows[i].Cells[4].Value.ToString();
                ws.Cells[i + 16, 3] = dataGridView3.Rows[i].Cells[2].Value.ToString()+"m²";
                ws.Cells[i + 16, 4] = dataGridView3.Rows[i].Cells[3].Value.ToString();
                ws.Cells[i + 16, 5] = dataGridView3.Rows[i].Cells[6].Value.ToString();
                ws.Cells[i + 16, 6] = dataGridView3.Rows[i].Cells[5].Value.ToString();
                ws.Cells[i + 16, 7] = float.Parse(dataGridView3.Rows[i].Cells[7].Value.ToString()).ToString("#.##") + "dt";



                //net a payer

                ws.Cells[30, 5] = float.Parse(txt_montant_htva.Text.ToString()).ToString("#.##");
                ws.Cells[31, 5] = float.Parse(txt_montant_total.Text.ToString()).ToString("#.##");


            }
            chargementdetail();
            // lancement de l'impression par default:
            ws.PrintOut(Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        
    }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
