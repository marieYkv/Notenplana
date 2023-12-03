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
            //modelRegestrierung.speichern(NeuesProfil, NeuesProfil);
            ModelNoteHj1 modelNoteHj1 = new ModelNoteHj1();
            NoteHj1 NeueNoteHj1 = new NoteHj1();
            NeueNoteHj1.Fachname = comboBoxFachname.Text;
            NeueNoteHj1.Note = textBoxNote1.Text;
            NeueNoteHj1.Note = textBoxNote2.Text;
            NeueNoteHj1.Note = textBoxNote3.Text;
            modelNoteHj1.speichern1(NeueNoteHj1);
        }

        private void buttonZurueck_Click(object sender, EventArgs e)
        {
            ViewHauptprogramm viewHauptprogramm = new ViewHauptprogramm();
            viewHauptprogramm.Show();

            this.Close();
        }
    }
}
