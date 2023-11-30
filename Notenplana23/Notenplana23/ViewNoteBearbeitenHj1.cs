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
    public partial class ViewNoteBearbeitenHj1 : Form
    {
        public ViewNoteBearbeitenHj1()
        {
            InitializeComponent();
        }

        private void buttonSpeichern1_Click(object sender, EventArgs e)
        {
            ModelNoteBearbeitenHj1 modelNoteBearbeitenHj1 = new ModelNoteBearbeitenHj1();
            NoteHj1 VerbesserteNote1Hj1 = new NoteHj1();
            VerbesserteNote1Hj1.Fachname = comboBoxFachname.Text;
            VerbesserteNote1Hj1.Note = textBoxNote1.Text;
            VerbesserteNote1Hj1.Note = textBoxNote2.Text;
            VerbesserteNote1Hj1.Note = textBoxNote3.Text;
            modelNoteBearbeitenHj1.speichern1(VerbesserteNote1Hj1);
        }

        private void buttonSpeichern2_Click(object sender, EventArgs e)
        {
            ModelNoteBearbeitenHj1 modelNoteBearbeitenHj1 = new ModelNoteBearbeitenHj1();
            NoteHj1 VerbesserteNote2Hj1 = new NoteHj1();
            VerbesserteNote2Hj1.Fachname = comboBoxFachname.Text;
            VerbesserteNote2Hj1.Note = textBoxNote1.Text;
            VerbesserteNote2Hj1.Note = textBoxNote2.Text;
            VerbesserteNote2Hj1.Note = textBoxNote3.Text;
            modelNoteBearbeitenHj1.speichern1(VerbesserteNote2Hj1);
        }

        private void buttonSPeichern3_Click(object sender, EventArgs e)
        {
            ModelNoteBearbeitenHj1 modelNoteBearbeitenHj1 = new ModelNoteBearbeitenHj1();
            NoteHj1 VerbesserteNote3Hj1 = new NoteHj1();
            VerbesserteNote3Hj1.Fachname = comboBoxFachname.Text;
            VerbesserteNote3Hj1.Note = textBoxNote1.Text;
            VerbesserteNote3Hj1.Note = textBoxNote2.Text;
            VerbesserteNote3Hj1.Note = textBoxNote3.Text;
            modelNoteBearbeitenHj1.speichern1(VerbesserteNote3Hj1);

        }
    }
}
