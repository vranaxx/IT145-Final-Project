/*
* Program: Meal Class
* Purpose: Collects ingredients and merges their effects
* Author: Nicholas Nguyen
* Date: 2026-04-08
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace IT145_FinalProject
{
    internal class Meal
    {
        protected Ingredient main, side, topping;
        protected int HP = 0, ATK = 0, INT = 0;
        protected string specialEffect;

        // because of how constructor chaining is ordered, chaining is done "in reverse"
        public Meal(Ingredient main) : this(main, null, null) { }
        
        public Meal(Ingredient main, Ingredient side) : this(main, side, null) { }
       
        public Meal(Ingredient main, Ingredient side, Ingredient topping)
        {
            this.main = main;
            this.side = side;
            this.topping = topping;

            // extract all stats
            string eff1 = "None", eff2 = "None", eff3 = "None";
            if (main != null)
                extractStats(main, ref eff1);
            if (side != null)
                extractStats(side, ref eff2);
            if (topping != null)
                extractStats(topping, ref eff3);

            // use the most frequently appeared special effect for the meal
            if (eff1 == eff2)
                specialEffect = eff1;
            else if (eff2 == eff3)
                specialEffect = eff2;
            else if (eff1 == eff3)
                specialEffect = eff1;
            else
                specialEffect = "None";
        }

        // helper function to extract stats from ingredients
        private void extractStats(Ingredient ing, ref string paramEff)
        {
            var stats = ing.getStats();
            HP += stats.HP;
            ATK += stats.ATK;
            INT += stats.INT;
            paramEff = ing.GetIngredientEffect();
            //Console.WriteLine(ing.getStats());
            //Console.WriteLine(paramEff);
        }

        public (int HP, int ATK, int INT) getStats()
        {
            return (HP, ATK, INT);
        }

        public int GetMealHP() { return HP; }
        public int GetMealATK() { return ATK; }
        public int GetMealINT() { return INT; }
        public string GetMealEffect() { return specialEffect; }

        public string MealIngredientNamesToString()
        {
            return 
                $"{(main != null ? main.GetIngredientName() : "None")} + " +
                $"{(side != null ? side.GetIngredientName() : "None")} + " +
                $"{(topping != null ? topping.GetIngredientName() : "None")}";
        }
    }
}
