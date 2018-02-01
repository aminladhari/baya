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
    public partial class Chargement : MetroForm
    {
        public Chargement()
        {
            InitializeComponent();
            this.BorderStyle = MetroFormBorderStyle.FixedSingle;
            this.ShadowType = MetroFormShadowType.AeroShadow;
        }

        private void Chargement_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            metroProgressBar1.Increment(2);
            if (metroProgressBar1.Value == metroProgressBar1.Maximum)
            {

                timer1.Stop();
                this.Hide();
                Authentification ac = new Authentification();
                ac.Show();

            }
        }

        private void metroProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
