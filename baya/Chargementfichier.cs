using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baya
{
    class Chargementfichier
    {
        public void ChargementComboBox(string requete, ComboBox combo)
        {
            combo.Items.Clear();
            Connexion.cnx.Open();
            Connexion.cmd.CommandText = requete;
            MySqlDataReader lire = Connexion.cmd.ExecuteReader();
            while (lire.Read())
            {
                combo.Items.Add(lire[0].ToString());
            }
            Connexion.cnx.Close();
        }
        public void RecupereNomComboBox(string requete, TextBox t)
        {
            Connexion.cnx.Open();
            Connexion.cmd.CommandText = requete;
            MySqlDataReader lire = Connexion.cmd.ExecuteReader();

            if (lire.Read())
            {
                t.Text = lire[0].ToString();
            }
            Connexion.cnx.Close();
        }
    }
}

