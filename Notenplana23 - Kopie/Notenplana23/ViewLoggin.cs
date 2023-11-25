using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Notenplana23
{
    public partial class ViewLoggin : Form
    {
        public ViewLoggin()
        {
            InitializeComponent();
        }

        string myConnectionString = "server=127.0.0.1;uid=root;pwd=;database=Notenplana;";

        MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection(myConnectionString);


        private void buttonRegestrieren_Click(object sender, EventArgs e)
        {
            ViewRegestrierung viewRegestrierung = new ViewRegestrierung();
            viewRegestrierung.Show();

            this.Hide();
        }

        private void buttonLoggin_Click(object sender, EventArgs e)
        {
            MySqlCommand mycommand = conn.CreateCommand();
            mycommand.CommandText = "Select * From Profil wehere Benutzername='" + textBoxBenutzername + "' AND Passwort='" + textBoxPasswort + "'";
            conn.Open();

            ViewHauptprogramm viewHauptprogramm = new ViewHauptprogramm();
            viewHauptprogramm.Show();

            this.Hide();
            conn.Close();
        }
    }
}
