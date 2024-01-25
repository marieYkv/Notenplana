using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notenplana23
{
    internal class ModelNoteHj2
    {
        //private static string myConnectionString = "server=127.0.0.1;uid=root;pwd=Start1234;database=Notenplana;";
        //private static MySqlConnection conn = new MySqlConnection(myConnectionString);
        //private MySqlCommand mycommand;


        //public void select(int note, int halbjahresnote, int jahresnote)
        //{
        //    conn.CreateCommand();
        //    mycommand.CommandText = "INSERT INTO NoteHj1 Values (NULL," + note + "','" + halbjahresnote + "','" + jahresnote + "')";
        //    mycommand.ExecuteNonQuery();
        //}
        private MySqlConnection conn;

        public void speichern(NoteHj2 noteHj2)
        {
            string myConnectionString = "server=127.0.0.1;uid = root; database = Notenplana; ";
            conn = new MySqlConnection(myConnectionString);
            MySqlCommand mycommand = conn.CreateCommand();// In der Datenbank ist keine spalte fachname in note unbedingt einfügen !!
            string selectString = "INSERT INTO NoteHj2 (Fachname, Note, Haljahresnote, Jahresnote) Values (NULL,'" + noteHj2.Fachname + "','" + noteHj2.Note + "','" + noteHj2.Halbjahresnote + "','" + noteHj2.Jahresnote + "')";
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
