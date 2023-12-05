using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notenplana23
{
    public partial class ViewProfil : Form
    {
        public ViewProfil()
        {
            InitializeComponent();
        }

        private void buttonZurueck_Click(object sender, EventArgs e)
        {
            ViewHauptprogramm viewHauptprogramm = new ViewHauptprogramm();
            viewHauptprogramm.Show();

            this.Close();
        }

        private void buttonBearbeiten_Click(object sender, EventArgs e)
        {
            ViewProfiBearbeiten viewProfilBearbeiten= new ViewProfiBearbeiten();
            viewProfilBearbeiten.Show();
            this.Close();
        }

        private void buttonAbmelden_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sie werden nun Abgemeldet.");
            ViewLoggin viewLoggin = new ViewLoggin();
            viewLoggin.Show();
            this.Close();
        }
    }
}
