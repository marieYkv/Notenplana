using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notenplana23
{
    internal class ModelNoteHj1
    {
        private static string myConnectionString = "server=127.0.0.1;uid=root;pwd=Start1234;database=Notenplana;";
        private static MySqlConnection conn = new MySqlConnection(myConnectionString);
        private MySqlCommand mycommand;


        public void select(int note, int halbjahresnote, int jahresnote)
        {
            conn.CreateCommand();
            mycommand.CommandText = "INSERT INTO NoteHj1 Values (NULL," + note + "','" + halbjahresnote + "','" + jahresnote + "')";
            mycommand.ExecuteNonQuery();
        }
    }
}
