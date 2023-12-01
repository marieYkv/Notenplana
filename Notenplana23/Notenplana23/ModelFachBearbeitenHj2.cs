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
        //private static string myConnectionString = "server=127.0.0.1;uid=root;pwd=Start1234;database=Notenplana;";
        //private static MySqlConnection conn = new MySqlConnection(myConnectionString);
        //private MySqlCommand mycommand;


        //public void select(string fach, string pruefungsfach)
        //{
        //    conn.CreateCommand();
        //    mycommand.CommandText = "UPDATE FachHj2 WHERE Fach='" + fach + "' AND Pruefungsfach='" + pruefungsfach + "'";
        //    mycommand.ExecuteNonQuery();
        //}
        private MySqlConnection conn;
        public void speichern3(NoteHj1 noteHj1)
        {
            string myConnectionString = "server=127.0.0.1;pwd = root; database = Notenplana; ";//uid=erp;
            conn = new MySqlConnection(myConnectionString);
            MySqlCommand mycommand = conn.CreateCommand();
            string selectString = "UPDATE NoteHJ1 Values WHERE Note='" + noteHj1.Fachname + "' AND'" + noteHj1.Note + "'AND'" + noteHj1.Halbjahresnote + "'AND'" + noteHj1.Jahresnote + "')";
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
        public void loeschen(NoteHj1 noteHj1)
        {
            string myConnectionString = "server=127.0.0.1;pwd = root; database = Notenplana; ";//uid=erp;
            conn = new MySqlConnection(myConnectionString);
            MySqlCommand mycommand = conn.CreateCommand();
            string selectString = "DELETE NoteBearbeitenHJ2 Values WHERE Note='" + noteHj1.Fachname + "' AND'" + noteHj1.Note + "'AND'" + noteHj1.Halbjahresnote + "'AND'" + noteHj1.Jahresnote + "')";
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
