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

        public string Fachname { get => fachname; set => fachname = value; }

        public FachHj1(string fachname)
        {
            Fachname = fachname;
        }

        public FachHj1() {}
    }
}
