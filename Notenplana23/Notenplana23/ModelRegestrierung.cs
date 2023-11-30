using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notenplana23
{
    internal class ModelRegestrierung
    {
        private static string myConnectionString = "server=127.0.0.1;uid=root;pwd=Start1234;database=Notenplana;";
        private static MySqlConnection conn = new MySqlConnection(myConnectionString);
        private MySqlCommand mycommand;

        
        public void select(string benutzername, string pwd)
        {
            conn.CreateCommand();
            mycommand.CommandText = "INSERT INTO Profil Values (NULL," + benutzername + "','" + pwd + "')";
            mycommand.ExecuteNonQuery();
        }

        public void speichern(Profil benutzername, Profil passwort)
        {
            conn.CreateCommand();
            string myConnectionString = "server=127.0.0.1;uid=erp;pwd = 1234 *; database = hhbkchemicals; ";
            conn = new MySqlConnection(myConnectionString);
            MySqlCommand mycommand = conn.CreateCommand();
            string selectString = "INSERT INTO Profil Values (NULL," + benutzername.Benutzername + "','" + passwort.Passwort + "'";
            mycommand.CommandText = selectString;
            conn.Open();
            try
            { mycommand.ExecuteNonQuery(); }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
