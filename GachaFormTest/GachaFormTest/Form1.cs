using System.Numerics;
using static GachaFormTest.Gacha;

namespace GachaFormTest
{
    public partial class Form1 : Form
    {
        private Player player;
        private RarityGacha gacha;

        public Form1()
        {
            InitializeComponent();

            var ingredients = new List<Ingredient>
            {
            new Ingredient("Power Carrot", 60), // common
            new Ingredient("Bitter Juice", 60),  
            new Ingredient("Crispy Spice", 40), //uncommon
            new Ingredient("Mama Liz's Chili Oil", 40), 
            new Ingredient("Crystal Sprinkle",20), //rare
            new Ingredient("Epic Frosting",20),
            new Ingredient("MAX Protein",10), //super rare
            new Ingredient("\"Superfood\"", 10),      
            };

            gacha = new RarityGacha(ingredients);

            lstIngredients.DataSource = ingredients.Select(i => $"{i.Name} (Weight {i.Weight})").ToList();

            player = new Player(startingCurrency: 100); //starting coins

            lstIngredients.DataSource = ingredients
                .Select(i => $"{i.Name} (Weight {i.Weight})")
                .ToList();

            lblCurrency.Text = $"Currency: {player.Currency}";
        }
        private void lstIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPull_Click(object sender, EventArgs e)
        {
            string result = gacha.Pull(player);
            lblResult.Text = "You Got: " + result;

            lblCurrency.Text = $"Currency: {player.Currency}";
        }
    }
}
