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
    public partial class ViewNoteHj1 : Form
    {

        public ViewNoteHj1()
        {
            InitializeComponent();

        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            ModelNoteHj1 modelNoteHj1 = new ModelNoteHj1();
            NoteHj1 NeueNoteHj1 = new NoteHj1();
            NeueNoteHj1.Fachname = comboBoxFachname.Text;
            NeueNoteHj1.Note = textBoxNote1.Text;
            NeueNoteHj1.Note = textBoxNote2.Text;
            NeueNoteHj1.Note = textBoxNote3.Text;
            modelNoteHj1.speichern1(NeueNoteHj1);
            textBoxNote1.Enabled = false;
            textBoxNote2 .Enabled = false;
            textBoxNote3.Enabled = false;
            MessageBox.Show("Ihre Note wurde gespeichert.");
        }

        private void buttonZurueck_Click(object sender, EventArgs e)
        {
            ViewHauptprogramm viewHauptprogramm = new ViewHauptprogramm();
            viewHauptprogramm.Show();

            this.Close();
        }

        private void buttonBearbeiten_Click(object sender, EventArgs e)
        {
            ViewNoteBearbeitenHj1 viewNoteBearbeitenHj1 = new ViewNoteBearbeitenHj1();
            viewNoteBearbeitenHj1.Show();
            this.Close();
        }

        private void comboBoxFachname_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBoxFachname.Items.Add("Test");
            comboBoxFachname.Items.Add(comboBoxFachname.Text);
            textBoxNote1.Enabled = true;
            textBoxNote2.Enabled = true;
            textBoxNote3.Enabled = true;
        }
    }
}
