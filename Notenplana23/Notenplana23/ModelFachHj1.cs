using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notenplana23
{
    internal class ModelFachHj1
    {
        //private static string myConnectionString = "server=127.0.0.1;uid=root;pwd=Start1234;database=Notenplana;";
        //private static MySqlConnection conn = new MySqlConnection(myConnectionString);
        //private MySqlCommand mycommand;


        //public void select(string fach, bool pruefungsfach)
        //{
        //    conn.CreateCommand();
        //    mycommand.CommandText = "INSERT INTO FachHj1 Values (NULL," + fach + "','" + pruefungsfach + "')";
        //    mycommand.ExecuteNonQuery();
        //}
        private MySqlConnection conn;

        public void speichern(FachHj1 fachHj1)
        {
            string myConnectionString = "server=127.0.0.1;pwd = root; database = Notenplana; ";//uid=erp;
            conn = new MySqlConnection(myConnectionString);
            MySqlCommand mycommand = conn.CreateCommand();
            string selectString = "INSERT INTO FachHj1 Values (NULL,'" + fachHj1.Fachname + "','" + fachHj1.Pruefungsfach + "')";
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
