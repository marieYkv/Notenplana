﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notenplana23
{
    internal class FachHj2
    {
        private string fachname;
        private bool pruefungsfach;

        public string Fachname { get => fachname; set => fachname = value; }
        public bool Pruefungsfach { get => pruefungsfach; set => pruefungsfach = value; }

        public FachHj2(string fachname, bool pruefungsfach)
        {
            Fachname = fachname;
            Pruefungsfach = pruefungsfach;
        }

        public FachHj2() {}
    }
}
