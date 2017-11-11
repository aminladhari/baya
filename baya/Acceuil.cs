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
    public partial class Acceuil : MetroForm
        
    {
        Chargementfichier x = new Chargementfichier();
        Chargementfichier y = new Chargementfichier();
        Chargementfichier z = new Chargementfichier();
        public Acceuil()
        {
            InitializeComponent();
            
        }
       

        private void Acceuil_Load(object sender, EventArgs e)
        {
            x.ChargementComboBox("select valeur from tva",combo_tva);
            y.ChargementComboBox("select valeur from epaisseur", combo_epai);
            z.ChargementComboBox("select type from typemarbre", type);
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
