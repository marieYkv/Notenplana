using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notenplana23
{
    internal class FachHj1
    {
        private string fachname;
        private bool pruefungsfach;

        public string Fachname { get => fachname; set => fachname = value; }
        public bool Pruefungsfach { get => pruefungsfach; set => pruefungsfach= value; }

        public FachHj1(string fachname, bool pruefungsfach)
        {
            Fachname = fachname;
            Pruefungsfach = pruefungsfach;
        }

        public FachHj1() {}
    }
}
