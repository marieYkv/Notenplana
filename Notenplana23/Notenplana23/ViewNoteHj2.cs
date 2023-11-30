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
    public partial class ViewNoteHj2 : Form
    {
        public ViewNoteHj2()
        {
            InitializeComponent();
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            ModelNoteHj2 modelNoteHj2 = new ModelNoteHj2();
            NoteHj2 NeueNoteHj2 = new NoteHj2();
            NeueNoteHj2.Fachname = comboBoxFachname.Text;
            NeueNoteHj2.Note = textBoxNote1.Text;
            NeueNoteHj2.Note = textBoxNote2.Text;
            NeueNoteHj2.Note = textBoxNote3.Text;
            modelNoteHj2.speichern(NeueNoteHj2);
        }
    }
}
