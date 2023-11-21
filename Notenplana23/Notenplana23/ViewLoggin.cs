namespace Notenplana23
{
    public partial class ViewLoggin : Form
    {
        public ViewLoggin()
        {
            InitializeComponent();
        }
        private void buttonLoggin_Click(object sender, EventArgs e)
        {
            ViewHauptprogramm viewHauptprogramm = new ViewHauptprogramm();
            viewHauptprogramm.Show();

            this.Close();
        }
    }
}