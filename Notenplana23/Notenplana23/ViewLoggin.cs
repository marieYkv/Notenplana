namespace Notenplana23
{
    public partial class ViewLoggin : Form
    {
        public ViewLoggin()
        {
            InitializeComponent();
        }

        private void buttonLoggin_Click(Object sender, EventArgs e)
		{
            ViewHauptprogramm viewHauptprogramm = new ViewHauptprogramm();
            ViewHauptprogramm.show();

            this.Close();
		}

        private void buttonRegestrierung_Click(Object sender, EventArgs e)
		{
            ViewRegestrierung viewRegestrierung = new ViewRegestrierung();
            viewRegestrierung.show();

            this.Hide();
		}
    }
}