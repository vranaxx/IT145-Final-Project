/*
* Program: Restaurant Class
* Purpose: Contains Ingredient inventory, turns into Meals for use with hero characters
* Author: Nicholas Nguyen
* Date: 2026-04-08
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace IT145_FinalProject
{
    internal class Restaurant
    {
        public static BindingList<Ingredient> ingredientInventory = new BindingList<Ingredient>();

        public static void AddToInventory(Ingredient ingredient)
        {
            ingredientInventory.Add(ingredient);
        }

        public static Meal CreateMeal(Ingredient ing1, Ingredient ing2, Ingredient ing3)
        {
            // assures each ingredient specified is inside inventory: else null
            Ingredient
                addToMeal1 = (ing1 != null && ingredientInventory.Remove(ing1)) ? ing1 : null,
                addToMeal2 = (ing2 != null && ingredientInventory.Remove(ing2)) ? ing2 : null,
                addToMeal3 = (ing3 != null && ingredientInventory.Remove(ing3)) ? ing3 : null;

            return new(addToMeal1,addToMeal2,addToMeal3);
        }

        public static void CreateAndEquipMeal(Character hero, Ingredient ing1, Ingredient ing2, Ingredient ing3)
        {
            hero.SetEquippedMeal(CreateMeal(ing1,ing2,ing3));
        }
    }
}
