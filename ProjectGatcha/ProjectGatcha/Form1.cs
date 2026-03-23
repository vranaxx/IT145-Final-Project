namespace ProjectGatcha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int FoodCoin;
        FoodCoin = 10;

        private void Gamble1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomnum = rnd.Next(0, 10); //Number of ingedents

            textBox1.Text = randomnum.ToString();
        }

        private void Gamble2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomnum = rnd.Next(0, 10); //Number of ingedents

            textBox2.Text = randomnum.ToString();
        }

        private void Gamble3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomnum = rnd.Next(0, 10); //Number of ingedents

            textBox3.Text = randomnum.ToString();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
