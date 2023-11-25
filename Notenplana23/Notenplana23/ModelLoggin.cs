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
        private MySqlConnection conn;

        string myConnectionString = "server=127.0.0.1;uid=root;pwd=Start1234;database=Notenplana;";


        conn = new MySqlConnection(myConnectionString);

        MySqlCommand mycommand = conn.CreateCommand();
        mycommand.CommandText = "SELECT * FROM Profil WHERE Benutzername='" + textBoxBenutzername.Text + "' AND Passwort='" + textBoxPasswort.Text + "'";

    }
}
