using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notenplana23
{
    internal class NoteHj2
    {
        private string fachname;
        private string note;
        private string halbjahresnote;
        private string jahresnote;


        public string Fachname { get => fachname; set => fachname = value; }
        public string Note { get => note; set => note = value; }
        public string Halbjahresnote { get => halbjahresnote; set => halbjahresnote = value; }
        public string Jahresnote { get => jahresnote; set => jahresnote = value; }

        public NoteHj2(string fachname, string note, string halbjahresnote, string jahresnote)
        {
            Fachname = fachname;
            Note = note;
            Halbjahresnote = halbjahresnote;
            Jahresnote = jahresnote;
        }

        public NoteHj2() {}
    }
}
