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
            x.ChargementComboBox("select valeur from tva",combo_tva);
            y.ChargementComboBox("select valeur from epaisseur", combo_epai);
            z.ChargementComboBox("select type from typemarbre", type);
            chargementgrid();
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
            metroGrid1.DataSource = dt;
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

       
    }
}
