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
    public partial class ViewRegestrierung : Form
    {
        public ViewRegestrierung()
        {
            InitializeComponent();
        }

        private void textBoxBenutzername_textChanged(Object sender, EventArgs e)
        {

        }

        private void textBoxBenutzername_textChanged(Object sender, EventArgs e)
        {

        }

        private void buttonZurueck_Click(Object sender, EventArgs e)
		{
            ViewLoggin viewLoggin = new ViewLoggin();
            viewLoggin.show();

            this.Close();
		}

        private void buttonSpeichern_Click(Object sender, EventArgs e)
		{
            ViewLoggin viewLoggin = new ViewLoggin();
            viewLoggin.show();

            this.Close();
		}
    }
}
