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
            NoteHj2 VerbesserteNoteHj2 = new NoteHj2();
            VerbesserteNoteHj2.Fachname = comboBoxFachname.Text;
            VerbesserteNoteHj2.Note = textBoxNote1.Text;
            VerbesserteNoteHj2.Halbjahresnote = textBoxNote2.Text;
            VerbesserteNoteHj2.Jahresnote = textBoxNote3.Text;
            //modelNoteBearbeitenHj2.speichern1(VerbesserteNoteHj2);//problem
            textBoxNote1.Enabled = false;
            textBoxNote2.Enabled = false;
            textBoxNote3.Enabled = false;
            MessageBox.Show("Ihre Note wurde geändert.");
        }

        private void buttonSpeichern2_Click(object sender, EventArgs e)
        {
            ModelNoteBearbeitenHj2 modelNoteBearbeitenHj2 = new ModelNoteBearbeitenHj2();
            NoteHj2 VerbesserteNote1Hj2 = new NoteHj2();
            VerbesserteNote1Hj2.Fachname = comboBoxFachname.Text;
            VerbesserteNote1Hj2.Note = textBoxNote1.Text;
            VerbesserteNote1Hj2.Halbjahresnote = textBoxNote2.Text;
            VerbesserteNote1Hj2.Jahresnote = textBoxNote3.Text;
            //modelNoteBearbeitenHj2.speichern1(VerbesserteNote1Hj2);
            textBoxNote1.Enabled = false;
            textBoxNote2.Enabled = false;
            textBoxNote3.Enabled = false;
            MessageBox.Show("Ihre Note wurde geändert.");
        }

        private void buttonSPeichern3_Click(object sender, EventArgs e)
        {
            ModelNoteBearbeitenHj2 modelNoteBearbeitenHj2 = new ModelNoteBearbeitenHj2();
            NoteHj2 VerbesserteNote1Hj2 = new NoteHj2();
            VerbesserteNote1Hj2.Fachname = comboBoxFachname.Text;
            VerbesserteNote1Hj2.Note = textBoxNote1.Text;
            VerbesserteNote1Hj2.Halbjahresnote = textBoxNote2.Text;
            VerbesserteNote1Hj2.Jahresnote = textBoxNote3.Text;
            //modelNoteBearbeitenHj2.speichern1(VerbesserteNote1Hj2);
            textBoxNote1.Enabled = false;
            textBoxNote2.Enabled = false;
            textBoxNote3.Enabled = false;
            MessageBox.Show("Ihre Note wurde geändert.");
        }

        private void buttonLoeschen1_Click(object sender, EventArgs e)
        {
            ModelNoteBearbeitenHj2 modelNoteBearbeitenHj2 = new ModelNoteBearbeitenHj2();
            NoteHj2 VerbesserteNote1Hj2 = new NoteHj2();
            VerbesserteNote1Hj2.Fachname = comboBoxFachname.Text;
            VerbesserteNote1Hj2.Note = textBoxNote1.Text;
            VerbesserteNote1Hj2.Halbjahresnote = textBoxNote2.Text;
            VerbesserteNote1Hj2.Jahresnote = textBoxNote3.Text;
            //modelNoteBearbeitenHj2.loeschen(VerbesserteNote1Hj2);
            textBoxNote1.Enabled = false;
            textBoxNote2.Enabled = false;
            textBoxNote3.Enabled = false;
            MessageBox.Show("Ihre Note wurde gelöscht.");
        }

        private void buttonLoeschen2_Click(object sender, EventArgs e)
        {
            ModelNoteBearbeitenHj2 modelNoteBearbeitenHj2 = new ModelNoteBearbeitenHj2();
            NoteHj2 VerbesserteNote1Hj2 = new NoteHj2();
            VerbesserteNote1Hj2.Fachname = comboBoxFachname.Text;
            VerbesserteNote1Hj2.Note = textBoxNote1.Text;
            VerbesserteNote1Hj2.Halbjahresnote = textBoxNote2.Text;
            VerbesserteNote1Hj2.Jahresnote = textBoxNote3.Text;
            //modelNoteBearbeitenHj2.loeschen(VerbesserteNote1Hj2);
            textBoxNote1.Enabled = false;
            textBoxNote2.Enabled = false;
            textBoxNote3.Enabled = false;
            MessageBox.Show("Ihre Note wurde gelöscht.");
        }

        private void buttonLoeschen3_Click(object sender, EventArgs e)
        {
            ModelNoteBearbeitenHj2 modelNoteBearbeitenHj2 = new ModelNoteBearbeitenHj2();
            NoteHj2 VerbesserteNote1Hj2 = new NoteHj2();
            VerbesserteNote1Hj2.Fachname = comboBoxFachname.Text;
            VerbesserteNote1Hj2.Note = textBoxNote1.Text;
            VerbesserteNote1Hj2.Halbjahresnote = textBoxNote2.Text;
            VerbesserteNote1Hj2.Jahresnote = textBoxNote3.Text;
            //modelNoteBearbeitenHj2.loeschen(VerbesserteNote1Hj2);
            textBoxNote1.Enabled = false;
            textBoxNote2.Enabled = false;
            textBoxNote3.Enabled = false;
            MessageBox.Show("Ihre Note wurde gelöscht.");
        }

        private void buttonZurueck_Click(object sender, EventArgs e)
        {
            ViewNoteHj2 viewNoteHj2 = new ViewNoteHj2();
            viewNoteHj2.Show();

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
