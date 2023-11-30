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
        //private static string myConnectionString = "server=127.0.0.1;uid=root;pwd=Start1234;database=Notenplana;";
        //private static MySqlConnection conn = new MySqlConnection(myConnectionString);
        //private MySqlCommand mycommand;


        //public void select(int note, int halbjahresnote, int jahresnote)
        //{
        //    conn.CreateCommand();
        //    mycommand.CommandText = "UPDATE NoteHj2 WHERE Note='" + note + "' AND Halbjahresnote='" + halbjahresnote + "' AND Jahresnote='" + jahresnote + "'";
        //    mycommand.ExecuteNonQuery();
        //}
        private MySqlConnection conn;

        public void speichern1(NoteHj2 noteHj2)
        {
            string myConnectionString = "server=127.0.0.1;pwd = root; database = Notenplana; ";//uid=erp;
            conn = new MySqlConnection(myConnectionString);
            MySqlCommand mycommand = conn.CreateCommand();
            string selectString = "UPDATE NotejJ2 Values WHERE Note='" + noteHj2.Fachname + "' AND'" + noteHj2.Note + "'AND'" + noteHj2.Halbjahresnote + "'AND'" + noteHj2.Jahresnote + "')";
            mycommand.CommandText = selectString;
            try
            {
                conn.Open();//Problem
                mycommand.ExecuteNonQuery();
            }
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
