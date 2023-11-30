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
    public partial class ViewNoteBearbeitenHj2 : Form
    {
        public ViewNoteBearbeitenHj2()
        {
            InitializeComponent();
        }

        private void buttonSpeichern1_Click(object sender, EventArgs e)
        {
            ModelNoteBearbeitenHj2 modelNoteBearbeitenHj2 = new ModelNoteBearbeitenHj2();
            NoteHj2 VerbesserteNote1Hj2 = new NoteHj2();
            VerbesserteNote1Hj2.Fachname = comboBoxFachname.Text;
            VerbesserteNote1Hj2.Note = textBoxNote1.Text;
            VerbesserteNote1Hj2.Note = textBoxNote2.Text;
            VerbesserteNote1Hj2.Note = textBoxNote3.Text;
            //modelNoteBearbeitenHj2.speichern1(VerbesserteNote1Hj2);//problem
        }
    }
}
