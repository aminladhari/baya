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
    public partial class client : MetroForm
    {
        public client()
        {
            InitializeComponent();
        }

        private void client_Load(object sender, EventArgs e)
        {

        }

        private void acceuilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Acceuil ac = new Acceuil();
            ac.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }
    }
}
