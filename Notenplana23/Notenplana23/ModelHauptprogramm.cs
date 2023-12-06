using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notenplana23
{
    internal class ModelHauptprogramm
    {
        private MySqlConnection conn;

        public ModelHauptprogramm() { }
        public void ausgebeFachHj1(FachHj1 fachHj1)
        {
            string myConnectionString = "server=127.0.0.1;pwd = root; database = Notenplana; ";//uid=erp;
            conn = new MySqlConnection(myConnectionString);
            MySqlCommand mycommand = conn.CreateCommand();
            string selectString = "SLECET * FROM FachHj1 WHERE='" + fachHj1.Fachname + "'AND WHERE='" + fachHj1.Pruefungsfach + "')";
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
        public void ausgebeNoteHj1(NoteHj1 noteHj1)
        {
            string myConnectionString = "server=127.0.0.1;pwd = root; database = Notenplana; ";//uid=erp;
            conn = new MySqlConnection(myConnectionString);
            MySqlCommand mycommand = conn.CreateCommand();
            string selectString = "SLECET * FROM NoteHj1 WHERE='" + noteHj1.Fachname + "'AND WHERE='" + noteHj1.Jahresnote + "'AND WHERE='" + noteHj1.Halbjahresnote + "')";
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
        public void ausgabe(NoteHj1 noteHj1) 
        {
            string textToShow = "lol";
            //LabelAusgabe //Fehlen labels lol
        } 
    }
}
