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
        //private static string myConnectionString = "server=127.0.0.1;uid=root;pwd=Start1234;database=Notenplana;";
        //private static MySqlConnection conn = new MySqlConnection(myConnectionString);
        //private MySqlCommand mycommand;


        //public void select(string benutzername, string pwd)
        //{
        //    conn.CreateCommand();
        //    mycommand.CommandText = "INSERT INTO Profil Values (NULL," + benutzername + "','" + pwd + "')";
        //    mycommand.ExecuteNonQuery();
        //}
        private MySqlConnection conn;

        public void speichern(Profil benutzername, Profil passwort)
        {
            string myConnectionString = "server=127.0.0.1;uid = root; database = Notenplana; ";
            conn = new MySqlConnection(myConnectionString);
            MySqlCommand mycommand = conn.CreateCommand();
            string selectString = "INSERT INTO Profil (Benutzername, Passwort) Values ('" + benutzername.Benutzername + "','" + passwort.Passwort + "')";
            mycommand.CommandText = selectString;
            try
            { 
                conn.Open();//Problem
                mycommand.ExecuteNonQuery(); }
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
