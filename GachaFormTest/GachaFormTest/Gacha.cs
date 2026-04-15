using System;
using System.Collections.Generic;
using System.Linq;
namespace GachaFormTest
{
    internal class Gacha
    {
        private List<string> ingredients;

        public Gacha(List<string> ingredients)
        {
            this.ingredients = ingredients;
        }
    }

    public class Ingredient
    {
        public string Name;
        public int Weight;

        public Ingredient(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }
    }

    public class RarityGacha
    {
        private Random rng = new Random();
        private List<Ingredient> ingredients;

        public int PullCost = 10;

        public RarityGacha(List<Ingredient> ingredients)
        {
            this.ingredients = ingredients;
        }

        public string Pull(Player player)
        {
            if (!player.Spend(PullCost))
                return "Not enough currency.";

            if (ingredients.Count == 0)
                return "No ingredients available.";

            int totalWeight = ingredients.Sum(i => i.Weight);
            int roll = rng.Next(totalWeight);

            int cumulative = 0;
            foreach (var item in ingredients)
            {
                cumulative += item.Weight;
                if (roll < cumulative)
                    return item.Name;
            }

            return ingredients.Last().Name;
        }
    }
}