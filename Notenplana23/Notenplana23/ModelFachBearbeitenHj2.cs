using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notenplana23
{
    internal class ModelFachBearbeitenHj2
    {
        private static string myConnectionString = "server=127.0.0.1;uid=root;pwd=Start1234;database=Notenplana;";
        private static MySqlConnection conn = new MySqlConnection(myConnectionString);
        private MySqlCommand mycommand;


        public void select(string fach, string pruefungsfach)
        {
            conn.CreateCommand();
            mycommand.CommandText = "UPDATE FachHj2 WHERE Fach='" + fach + "' AND Pruefungsfach='" + pruefungsfach + "'";
            mycommand.ExecuteNonQuery();
        }
    }
}
