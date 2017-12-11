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
	public partial class client : MetroForm
	{
		public client()
		{
			InitializeComponent();
		}

		private void client_Load(object sender, EventArgs e)
		{
			chargementgrid();
		}
		private void chargementgrid()
		{
			//chargement de datagridview

			Connexion.cmd.CommandText = "Select * from client ";
			MySqlDataAdapter da = new MySqlDataAdapter(Connexion.cmd);
			DataSet ds = new DataSet();
			da.Fill(ds, "client");
			System.Data.DataTable dt = new System.Data.DataTable();
			dt = ds.Tables["client"];
			dataGridView1.DataSource = dt;
			Connexion.cnx.Close();

		}

		private void acceuilToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
			Acceuil ac = new Acceuil();
			ac.Show();
		}

		private void btn_update_Click(object sender, EventArgs e)
		{
			if ((metroTextBox1.Text == "") || (metroTextBox2.Text == "")|| (metroTextBox3.Text == "")|| (metroTextBox4.Text == ""))
			{
				MessageBox.Show("Veuillez remplir les champs", "Champ(s)vide", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			else
			{
				Connexion.cnx.Close();
				Connexion.cnx.Open();
				Connexion.cmd.CommandText = "update client set nom='" + metroTextBox1.Text.ToString() + "',prenom='" + metroTextBox2.Text.ToString() + "',cin='" + metroTextBox3.Text.ToString() + "',adresse='" + metroTextBox4.Text.ToString() + "' where id_client='" + id.Text.ToString() + "' ";
				Connexion.cmd.ExecuteNonQuery();
				MessageBox.Show("Client modifié(e) avec succé", "Modification Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
				chargementgrid();
				metroTextBox1.Text = "";
				metroTextBox2.Text = "";
				metroTextBox3.Text = "";
				metroTextBox4.Text = "";
			}

		}

		private void btn_add_Click(object sender, EventArgs e)
		{
			int o;
			if ((int.TryParse(metroTextBox3.Text, out o) == false)||(metroTextBox1.Text == "") || (metroTextBox2.Text == "") || (metroTextBox3.Text == "") || (metroTextBox4.Text == ""))
			{
				MessageBox.Show("Veuillez remplir les champs", "Champ(s)vide", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				MessageBox.Show("Champs non valide doit étre numérique", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Error);
				metroTextBox3.Text = "12345678";
				metroTextBox1.Focus();
				metroTextBox2.Focus();
				metroTextBox3.Focus();
				metroTextBox4.Focus();

				if ((metroTextBox1.Text == "") && (metroTextBox2.Text == "") && (metroTextBox3.Text == "") && (metroTextBox4.Text == ""))
				{

					metroTextBox1.Focus();
					metroTextBox2.Focus();
					metroTextBox3.Focus();
					metroTextBox4.Focus();


				}
			}
			else
			{


				// code pour lire le num cin et controler si client existe ou pas ?
				Connexion.cnx.Close();
				Connexion.cnx.Open();
				Connexion.cmd.CommandText = "select * from client where cin='" + metroTextBox3.Text.ToString() + "'";
				MySqlDataReader lire = Connexion.cmd.ExecuteReader();
				if (lire.Read() == true)
				{
					MessageBox.Show("Client deja existe", "Client", MessageBoxButtons.OK, MessageBoxIcon.Warning);


				}
				
				

				else
				{
					metroTextBox1.BackColor = Color.White;
					metroTextBox2.BackColor = Color.White;
					metroTextBox3.BackColor = Color.White;
					metroTextBox4.BackColor = Color.White;

					try
					{
						lire.Close();


						Connexion.cmd.CommandText = "insert into client(nom,prenom,cin,adresse)values('" + metroTextBox1.Text.ToString() + "','" + metroTextBox2.Text.ToString() + "','" + metroTextBox3.Text.ToString() + "','" + metroTextBox4.Text.ToString() + "')";
						Connexion.cmd.ExecuteNonQuery();



						//chargement de datagridview
						Connexion.cmd.CommandText = "Select * from client";
						MySqlDataAdapter da = new MySqlDataAdapter(Connexion.cmd);
						DataSet ds = new DataSet();
						da.Fill(ds, "client");
						DataTable dt = new DataTable();
						dt = ds.Tables["client"];
						dataGridView1.DataSource = dt;

						metroTextBox1.Text = "";
						metroTextBox2.Text = "";
						metroTextBox4.Text = "";
						metroTextBox3.Text = "";

						MessageBox.Show("Client Ajouté(e) avec succé", "Ajout Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
						Connexion.cnx.Close();

					}
					catch (Exception p)
					{

						MessageBox.Show("Echec de connexion à la base de donnée : " + "==>" + p.Message);
					}

				}
			} 
					 
		}

		private void quiterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			metroTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			metroTextBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			metroTextBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			metroTextBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
		}

		private void metroButton1_Click(object sender, EventArgs e)
		{
			metroTextBox1.Text = "";
			metroTextBox2.Text = "";
			metroTextBox3.Text = "";
			metroTextBox4.Text = "";
		}

		private void btn_delete_Click(object sender, EventArgs e)
		{
			if ((metroTextBox1.Text == "") || (metroTextBox2.Text == "") || (metroTextBox3.Text == "") || (metroTextBox4.Text == ""))
			{
				MessageBox.Show("Veuillez remplir les champs", "Champ(s)vide", MessageBoxButtons.OK, MessageBoxIcon.Stop);

				metroTextBox1.Focus();
				metroTextBox2.Focus();
				metroTextBox3.Focus();
				metroTextBox4.Focus();
				MessageBox.Show("Selectionner un client", "Champs vides", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			

			else
			{
				Connexion.cnx.Close();
				Connexion.cnx.Open();


				DialogResult reponse;
				reponse = MessageBox.Show("êtes_vous_sûr de supprimer le client ?", "Confirmer la Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
				//code si oui confirmer la suppression
				if (reponse == System.Windows.Forms.DialogResult.Yes)
				{
					Connexion.cmd.CommandText = "delete from client   where cin='" + metroTextBox3.Text.ToString() + "'";
					Connexion.cmd.ExecuteNonQuery();
					metroTextBox1.Text = "";
					metroTextBox2.Text = "";
					metroTextBox3.Text = "";
					metroTextBox4.Text = "";
					chargementgrid();
				}
			}
			
		}

		private void gestionMarbreToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.Hide();
			Marbre ac = new Marbre();
			ac.Show();
		}

		private void gestionGranitToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.Hide();
			Granit ac = new Granit();
			ac.Show();
		}

		private void metroTextBox3_Click(object sender, EventArgs e)
		{

		}

		private void metroTextBox3_TextChanged(object sender, EventArgs e)
		{
			
				// maximum 8 caractére
				metroTextBox3.MaxLength = 8;
			

			
			
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
	}
}
