using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Notenplana23
{
    public class ModelLoggin
    {
        private static string myConnectionString = "server=127.0.0.1;uid=root;database=Notenplana;";// vor dantenbank pwd=Start1234
        private static MySqlConnection conn = new MySqlConnection(myConnectionString);
        private MySqlCommand mycommand;

        public void select(string benutzername, string pwd)
        {
            conn.CreateCommand();
            mycommand.CommandText = "SELECT * FROM Profil WHERE Benutzername='" + benutzername + "' AND Passwort='" + pwd + "'";
        }
    }
}
