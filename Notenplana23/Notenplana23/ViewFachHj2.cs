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
    public partial class ViewFachHj2 : Form
    {
        public ViewFachHj2()
        {
            InitializeComponent();
        }

        private void buttonZurueck_Click(object sender, EventArgs e)
        {
            ViewHauptprogramm viewHauptprogramm = new ViewHauptprogramm();
            viewHauptprogramm.Show();

            this.Close();
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonBearbeiten_Click(object sender, EventArgs e)
        {
            ViewFachBearbeitenHj2 viewFFachBearbeitenHj2 = new ViewFachBearbeitenHj2();
            viewFachBearbeitenHj2.Show();

            this.Hide();
        }
    }
}
