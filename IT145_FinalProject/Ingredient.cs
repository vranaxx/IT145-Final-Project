/*
 * Program: Ingredient Class
 * Purpose: Stores ingredents for use ingame
 * Author: Nicholas Nguyen
 * Date: 2026-04-01
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace IT145_FinalProject
{
    internal class Ingredient
    {
        public static List<Ingredient> basicIngredients = [
            new("Power Carrot", 1,2,0),
            new("Bitter Juice", 3,0,0),
            new("Tangy Spice", 1,0,2),
            new("Menacing Spice", 0,3,-1),
            new("Mama Liz's Chili Oil", 0, 4, -2),
            new("\"Superfood\"", 0,0,3),
            new("MAX Protein", 2, 2, -2),
            new("Crystal Sprinkle", 0, -2, 4),
            new("A Cherry on Top", 1, 1 ,1),
            ];

        protected string ingredientName;
        protected int HP, ATK, INT; 

        public Ingredient(string name, int HP, int ATK, int INT)
        {
            ingredientName = name;
            this.HP = HP;
            this.ATK = ATK;
            this.INT = INT;
        }

        public (string Name, int HP, int ATK, int INT) getStats()
        {
            return (ingredientName, HP, ATK, INT);
        }
    }
}
