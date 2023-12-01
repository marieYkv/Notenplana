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
            ModelFachHj2 modelFachHj2 = new ModelFachHj2();
            FachHj2 NeuesFachHj2 = new FachHj2();
            NeuesFachHj2.Fachname = textBoxFachname.Text;
            NeuesFachHj2.Pruefungsfach = checkBoxPruefungsfach.Checked;
            modelFachHj2.speichern(NeuesFachHj2);
        }

        private void buttonBearbeiten_Click(object sender, EventArgs e)
        {
            ViewFachBearbeitenHj2 viewFachBearbeitenHj2 = new ViewFachBearbeitenHj2();
            viewFachBearbeitenHj2.Show();

            this.Hide();
        }
    }
}
