/*
* Program: Ingredient Class
* Purpose: Stores ingredients for use ingame
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
            
            new("Tangy Spice", 1,0,2),
            new("Crystal Flour", 0, -2, 4),
            new("Power Carrot", 1,2,0, "Power Attack"),
            new("MAX Protein", 2, 2, -2, "Power Attack"),
            new("Menacing Spice", 0,3,-1, "Defense Down"),
            new("Mama Liz's Chili Oil", 0, 4, -2, "Defense Down"),
            new("\"Superfood\"", 0,0,3, "Regeneration"),
            new("Bitter Juice", 3,0,0, "Regeneration"),
            new("Rock Candy", 1, 0, -1, "Defense Up"),
            new("Tortoise Shelling", 2, -1, 2, "Defense Up"),
            new("Sharp Spice", -1, 0, 1, "Attack All"),
            new("A Cherry on Top", 1, 1 ,1, "Attack All"),
            new("Hyperfruit", -1, 1, 1, "Attack Twice"),
            new("Dragontear", -2, 1, 2, "Attack Twice")

            ];

        protected string ingredientName, specialEffect; // special effect is used in meals specifically
        protected int HP, ATK, INT; // stats

        public Ingredient(string name, int HP, int ATK, int INT)
        {
            ingredientName = name;
            this.HP = HP;
            this.ATK = ATK;
            this.INT = INT;
            specialEffect = "None";
        }

        public Ingredient(string name, int HP, int ATK, int INT, string specialEffect) : this(name, HP, ATK, INT)
        {
            this.specialEffect = specialEffect;
        }

        public (string Name, int HP, int ATK, int INT) getStats()
        {
            return (ingredientName, HP, ATK, INT);
        }

        private static Random random = new Random();
        public static Ingredient GetIngredientRandom()
        {
            int index = random.Next(basicIngredients.Count);
            return basicIngredients[index];
        }

        public int GetIngredientHp()
        {
            return HP;
        }
        public int GetIngredientAtk()
        {
            return ATK;
        }
        public int GetIngredientInt()
        {
            return INT;
        }
        public string GetIngredientEffect()
        {
            return specialEffect;
        }
        public string GetIngredientName()
        {
            return ingredientName;
        }
    }
}