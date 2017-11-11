using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baya
{
   class Connexion
    {
        public static MySqlConnection cnx = new MySqlConnection("server = localhost;" + "DataBase=marbre;" + "UID=root;"); //connexion entre C # et la base de donner

        public static MySqlCommand cmd = new MySqlCommand("", cnx);//les resuetes SQL
    }
}
