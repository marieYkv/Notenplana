﻿using MySql.Data.MySqlClient;
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
        
        private MySqlConnection conn;

        public void speichern1(NoteHj1 noteHj1)
        {
            string myConnectionString = "server=127.0.0.1;uid = root; database = Notenplana; ";
            conn = new MySqlConnection(myConnectionString);
            MySqlCommand mycommand = conn.CreateCommand();// In der Datenbank ist keine spalte fachname in note unbedingt einfügen !!
            string selectString = "INSERT INTO NoteHj1 (Fachname, Note, Haljahresnote, Jahresnote) Values (NULL,'" + noteHj1.Fachname + "','" + noteHj1.Note + "','" + noteHj1.Halbjahresnote + "','" + noteHj1.Jahresnote + "')";
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
