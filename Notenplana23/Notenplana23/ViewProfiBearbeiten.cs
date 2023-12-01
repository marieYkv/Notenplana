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
        }

        private void buttonLoeschen_Click(object sender, EventArgs e)
        {
            ModelProfilBearbeiten modelProfilBearbeiten = new ModelProfilBearbeiten();
            Profil bessersProfil = new Profil();
            bessersProfil.Benutzername = textBoxBenutzername.Text;
            bessersProfil.Passwort = textBoxPasswort.Text;
            modelProfilBearbeiten.loeschen(bessersProfil);
        }
    }
}
