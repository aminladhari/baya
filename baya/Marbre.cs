using MetroFramework.Forms;
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
    public partial class Marbre : MetroForm
    {
        public Marbre()
        {
            InitializeComponent();
        }

        private void Marbre_Load(object sender, EventArgs e)
        {

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
            this.Close();
        }
    }
}
