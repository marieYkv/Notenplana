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
    public partial class ViewFachHj1 : Form
    {
        public ViewFachHj1()
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
            ViewFachBearbeitenHj1 viewFFachBearbeitenHj1 = new ViewFachBearbeitenHj1();
            viewFachBearbeitenHj1.Show();

            this.Hide();
        }
    }
}
