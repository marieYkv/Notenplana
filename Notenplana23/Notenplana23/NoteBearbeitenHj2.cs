using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notenplana23
{
    internal class NoteBearbeitenHj2
    {
        private static string myConnectionString = "server=127.0.0.1;uid=root;pwd=Start1234;database=Notenplana;";
        private static MySqlConnection conn = new MySqlConnection(myConnectionString);
        private MySqlCommand mycommand;


        public void select(int note, int halbjahresnote, int jahresnote)
        {
            conn.CreateCommand();
            mycommand.CommandText = "UPDATE NoteHj2 WHERE Note='" + note + "' AND Halbjahresnote='" + halbjahresnote + "' AND Jahresnote='" + jahresnote + "'";
            mycommand.ExecuteNonQuery();
        }
    }
}
