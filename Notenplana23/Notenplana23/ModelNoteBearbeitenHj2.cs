using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notenplana23
{
    internal class ModelNoteBearbeitenHj2
    {
        //private static string myConnectionString = "server=127.0.0.1;uid=root;pwd=Start1234;database=Notenplana;";

        private MySqlConnection conn;

        public void speichern1(NoteHj1 noteHj1)
        {
            string myConnectionString = "server=127.0.0.1;uid = root; database = Notenplana; ";
            conn = new MySqlConnection(myConnectionString);
            MySqlCommand mycommand = conn.CreateCommand();
            string selectString = "UPDATE NoteHj2 Values (Fachname, Note, Haljahresnote, Jahresnote) WHERE Note='" + noteHj1.Fachname + "' AND'" + noteHj1.Note + "'AND'" + noteHj1.Halbjahresnote + "'AND'" + noteHj1.Jahresnote + "')";
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
        public void loeschen(NoteBearbeitenHj2 noteBearbeitenHj2)
        {
            string myConnectionString = "server=127.0.0.1;uid = root; database = Notenplana; ";
            conn = new MySqlConnection(myConnectionString);
            MySqlCommand mycommand = conn.CreateCommand();
            string selectString = "DELETE NoteBearbeitenHJ2 Values WHERE Note='" + noteBearbeitenHj2.Fachname + "' AND'" + noteBearbeitenHj2.Note + "'AND'" + noteBearbeitenHj2.Halbjahresnote + "'AND'" + noteBearbeitenHj2.Jahresnote + "')";
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
