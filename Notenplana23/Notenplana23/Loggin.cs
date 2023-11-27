using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notenplana23
{
    internal class Loggin
    {
        private string benutzername = "";
        private string passwort = "";

        public string Benutzername  { get => benutzername; set => benutzername = value; }
        public string Passwort  { get => passwort; set => passwort = value; }

        public Loggin(string benutzername, string passwort)
        {
            Benutzername = benutzername;
            Passwort = passwort;
        }

        public Loggin() {}
    }
}
