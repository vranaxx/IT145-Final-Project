using System;
using System.Collections.Generic;
using System.Text;

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

        public RarityGacha(List<Ingredient> ingredients)
        {
            this.ingredients = ingredients;
        }

        public string Pull()
        {
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

