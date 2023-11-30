using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notenplana23
{
    internal class ModelNoteHj1
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

        public void speichern1(NoteHj1 noteHj1)
        {
            string myConnectionString = "server=127.0.0.1;pwd = root; database = Notenplana; ";//uid=erp;
            conn = new MySqlConnection(myConnectionString);
            MySqlCommand mycommand = conn.CreateCommand();
            string selectString = "INSERT INTO NoteHj1 Values (NULL,'" + noteHj1.Fachname + "','" + noteHj1.Note + "','" + noteHj1.Halbjahresnote + "','" + noteHj1.Jahresnote + "')";
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
