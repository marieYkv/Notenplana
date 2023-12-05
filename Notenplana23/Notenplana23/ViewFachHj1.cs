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
            ModelFachHj1 modelFachHj1 = new ModelFachHj1();
            FachHj1 NeuesFachHj1 = new FachHj1();
            NeuesFachHj1.Fachname = textBoxFachname.Text;
            NeuesFachHj1.Pruefungsfach = checkBoxPruefungsfach.Checked;
            modelFachHj1.speichern(NeuesFachHj1);
            MessageBox.Show("Ihr Fach wird gespeichert.");                 
        }

        private void buttonBearbeiten_Click(object sender, EventArgs e)
        {
            ViewFachBearbeitenHj1 viewFachBearbeitenHj1 = new ViewFachBearbeitenHj1();
            viewFachBearbeitenHj1.Show();

            this.Hide();
        }

        private void textBoxFachname_TextChanged(object sender, EventArgs e)
        {
            checkBoxPruefungsfach.Enabled = true;
        }

        private void checkBoxPruefungsfach_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
