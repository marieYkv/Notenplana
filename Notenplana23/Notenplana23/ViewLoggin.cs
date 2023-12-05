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
        private ModelLoggin modelLoggin;
        public ViewLoggin()
        {
            InitializeComponent();
        }


        private void buttonRegestrieren_Click(object sender, EventArgs e)
        {
            ViewRegestrierung viewRegestrierung = new ViewRegestrierung();
            viewRegestrierung.Show();

            this.Hide();
        }

        private void buttonLoggin_Click(object sender, EventArgs e)
        {
            ViewHauptprogramm viewHauptprogramm = new ViewHauptprogramm();
            viewHauptprogramm.Show();

            this.Hide();
            MessageBox.Show("Sie sind nun eingeloggt.");
        }
    }
}
