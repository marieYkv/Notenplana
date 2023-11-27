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

        public string Fachname { get => fachname; set => fachname = value; }

        public NoteHj2(string fachname)
        {
            Fachname = fachname;
        }

        public NoteHj2() {}
    }
}
