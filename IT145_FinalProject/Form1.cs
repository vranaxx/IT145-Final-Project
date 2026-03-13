namespace IT145_FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form_Click(object sender, EventArgs e)
        {
            new SubForm(this,(Button)sender).Show();
            this.Hide();
        }
    }
}
