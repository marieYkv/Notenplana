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
    public partial class ViewProfiBearbeiten : Form
    {
        public ViewProfiBearbeiten()
        {
            InitializeComponent();
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            ModelProfilBearbeiten modelProfilBearbeiten = new ModelProfilBearbeiten();
            Profil bessersProfil = new Profil();
            bessersProfil.Benutzername = textBoxBenutzername.Text;
            bessersProfil.Passwort = textBoxPasswort.Text;
            modelProfilBearbeiten.speichern(bessersProfil);
            buttonSpeichern.Enabled = false;
            textBoxBenutzername.Enabled = false;
            textBoxPasswort.Enabled = false;
            buttonLoeschen.Enabled = false;
            MessageBox.Show("Ihr Profildaten wurde geändert.");
        }

        private void buttonLoeschen_Click(object sender, EventArgs e)
        {
            ModelProfilBearbeiten modelProfilBearbeiten = new ModelProfilBearbeiten();
            Profil bessersProfil = new Profil();
            bessersProfil.Benutzername = textBoxBenutzername.Text;
            bessersProfil.Passwort = textBoxPasswort.Text;
            modelProfilBearbeiten.loeschen(bessersProfil);
            buttonLoeschen.Enabled = false;
            buttonSpeichern.Enabled=false;
            MessageBox.Show("Ihr Profil wurde gelöscht.");
        }

        private void buttonZurueck_Click(object sender, EventArgs e)
        {
            ViewProfil viewProfil = new ViewProfil();
            viewProfil.Show();

            this.Close();
        }

        private void buttonBearbeiten_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Möchsten Sie Ihr Profil wirklich bearbeiten?");
            textBoxBenutzername.Enabled = true;
            textBoxPasswort.Enabled = true;
            buttonSpeichern.Enabled = true;
            buttonLoeschen.Enabled = true;
        }
    }
}
