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
            VerbesserteNote1Hj1.Halbjahresnote = textBoxNote2.Text;
            VerbesserteNote1Hj1.Jahresnote = textBoxNote3.Text;
            modelNoteBearbeitenHj1.speichern1(VerbesserteNote1Hj1);
            textBoxNote1.Enabled = false;
            textBoxNote2.Enabled = false;
            textBoxNote3.Enabled = false;
            MessageBox.Show("Ihre Note wurde geändert.");
        }

        private void buttonSpeichern2_Click(object sender, EventArgs e)
        {
            ModelNoteBearbeitenHj1 modelNoteBearbeitenHj1 = new ModelNoteBearbeitenHj1();
            NoteHj1 VerbesserteNote2Hj1 = new NoteHj1();
            VerbesserteNote2Hj1.Fachname = comboBoxFachname.Text;
            VerbesserteNote2Hj1.Note = textBoxNote1.Text;
            VerbesserteNote2Hj1.Halbjahresnote = textBoxNote2.Text;
            VerbesserteNote2Hj1.Jahresnote = textBoxNote3.Text;
            modelNoteBearbeitenHj1.speichern1(VerbesserteNote2Hj1);
            textBoxNote1.Enabled = false;
            textBoxNote2.Enabled = false;
            textBoxNote3.Enabled = false;
            MessageBox.Show("Ihre Note wurde geändert.");
        }

        private void buttonSPeichern3_Click(object sender, EventArgs e)
        {
            ModelNoteBearbeitenHj1 modelNoteBearbeitenHj1 = new ModelNoteBearbeitenHj1();
            NoteHj1 VerbesserteNote3Hj1 = new NoteHj1();
            VerbesserteNote3Hj1.Fachname = comboBoxFachname.Text;
            VerbesserteNote3Hj1.Note = textBoxNote1.Text;
            VerbesserteNote3Hj1.Halbjahresnote = textBoxNote2.Text;
            VerbesserteNote3Hj1.Jahresnote = textBoxNote3.Text;
            modelNoteBearbeitenHj1.speichern1(VerbesserteNote3Hj1);
            textBoxNote1.Enabled = false;
            textBoxNote2.Enabled = false;
            textBoxNote3.Enabled = false;
            MessageBox.Show("Ihre Note wurde geändert.");
        }

        private void buttonLoeschen1_Click(object sender, EventArgs e)
        {
            ModelNoteBearbeitenHj1 modelNoteBearbeitenHj1 = new ModelNoteBearbeitenHj1();
            NoteHj1 VerbesserteNote1Hj1 = new NoteHj1();
            VerbesserteNote1Hj1.Fachname = comboBoxFachname.Text;
            VerbesserteNote1Hj1.Note = textBoxNote1.Text;
            VerbesserteNote1Hj1.Halbjahresnote = textBoxNote2.Text;
            VerbesserteNote1Hj1.Jahresnote = textBoxNote3.Text;
            modelNoteBearbeitenHj1.loeschen(VerbesserteNote1Hj1);
            textBoxNote1.Enabled = false;
            textBoxNote2.Enabled = false;
            textBoxNote3.Enabled = false;
            MessageBox.Show("Ihre Note wurde gelöscht.");
        }

        private void buttonLoeschen2_Click(object sender, EventArgs e)
        {
            ModelNoteBearbeitenHj1 modelNoteBearbeitenHj1 = new ModelNoteBearbeitenHj1();
            NoteHj1 VerbesserteNote1Hj1 = new NoteHj1();
            VerbesserteNote1Hj1.Fachname = comboBoxFachname.Text;
            VerbesserteNote1Hj1.Note = textBoxNote1.Text;
            VerbesserteNote1Hj1.Halbjahresnote = textBoxNote2.Text;
            VerbesserteNote1Hj1.Jahresnote = textBoxNote3.Text;
            modelNoteBearbeitenHj1.loeschen(VerbesserteNote1Hj1);
            textBoxNote1.Enabled = false;
            textBoxNote2.Enabled = false;
            textBoxNote3.Enabled = false;
            MessageBox.Show("Ihre Note wurde gelöscht.");
        }

        private void buttonLoeschen3_Click(object sender, EventArgs e)
        {
            ModelNoteBearbeitenHj1 modelNoteBearbeitenHj1 = new ModelNoteBearbeitenHj1();
            NoteHj1 VerbesserteNote1Hj1 = new NoteHj1();
            VerbesserteNote1Hj1.Fachname = comboBoxFachname.Text;
            VerbesserteNote1Hj1.Note = textBoxNote1.Text;
            VerbesserteNote1Hj1.Halbjahresnote = textBoxNote2.Text;
            VerbesserteNote1Hj1.Jahresnote = textBoxNote3.Text;
            modelNoteBearbeitenHj1.loeschen(VerbesserteNote1Hj1);
            textBoxNote1.Enabled = false;
            textBoxNote2.Enabled = false;
            textBoxNote3.Enabled = false;
            MessageBox.Show("Ihre Note wurde gelöscht.");
        }

        private void buttonZurueck_Click(object sender, EventArgs e)
        {
            ViewNoteHj1 viewNoteHj1 = new ViewNoteHj1();
            viewNoteHj1.Show();

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
