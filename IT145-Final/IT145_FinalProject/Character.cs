/*
 * Program: Character Class
 * Purpose: Class to store character information
 * Author: Thomas Shampney, Nicholas Ngueyen
 * Date: 2026-04-05
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;

namespace IT145_FinalProject
{
    internal class Character
    {
        protected string _characterName; //TBS: Character name
        protected int _characterHP; //TBS: Stat for character health scaling
        protected int _characterATK; //TBS: Stat for damage scaling
        protected int _characterINT; //TBS: Stat for secondary/passive/skill scaling
        Profession _characterProfession; //TBS: Character profession inherit
        protected Ingredient characterBasicIngred; //NN: 
        protected Meal equippedMeal;

        public static BindingList<Character> _characterList = new BindingList<Character>(); //TBS: Binding list for characters
        public static BindingList<Character> _characterEnemyList = new BindingList<Character>(); //TBS: binding list for enemies

        public static List<Profession> _professions = new List<Profession>(); //TBS: Profession List

        #region Constructors
        public Character() //TBS: Default Constructor
        {
            _characterName = "";
            _characterATK = 0;
            _characterHP = 0;
            _characterATK = 0;
        } 

        public Character(string charName, int charHP, int charATK, int charINT, Profession charProfession) //TBS: Full Constructor
        {
            _characterProfession = charProfession;
            _characterName = charName;
            _characterATK = charProfession.GetProfessionATK();
            _characterINT = charProfession.GetProfessionINT();
            _characterHP = charProfession.GetProfessionHP();
        }
        public Character(Profession charProfession) //TBS: Class only constructor
        {
            _characterProfession = charProfession;
            _characterHP = charProfession.GetProfessionHP();
            _characterATK = charProfession.GetProfessionATK();
            _characterINT = charProfession.GetProfessionINT();
        }
        public Character(Profession charProfession, string charName) //TBS: Class and name constructor
        {
            _characterName = charName;
            _characterProfession = charProfession;
            _characterHP = charProfession.GetProfessionHP();
            _characterATK = charProfession.GetProfessionATK();
            _characterINT = charProfession.GetProfessionINT();
        }
        public Character(string charName, int charHP, int charATK, int charINT) //TBS: Stat only constructor
        {
            _characterName = charName;
            _characterATK = charATK;
            _characterINT = charINT;
            _characterHP = charHP;
        }
        public Character(Profession charProfession, string charName, Ingredient charIng) //TBS: Class and name constructor
        {
            characterBasicIngred = charIng;
            _characterName = charName;
            _characterProfession = charProfession;
            _characterHP = charIng.GetIngredientHp() + charProfession.GetProfessionHP();
            _characterATK = charIng.GetIngredientAtk() + charProfession.GetProfessionATK();
            _characterINT = charIng.GetIngredientInt() + charProfession.GetProfessionINT();
        }


        #endregion

            #region Get Set
        public void CharacterSetClass (Profession charProfession) //TBS: Set character class
        {
            _characterProfession = charProfession; 
        }

        public void CharacterSetName(string name) //TBS: Set Name Functiion
        {
            if (name != "") //NN: blank check
                _characterName = name;
            else
                _characterName = "BLANK";
        }

        public void CharacterSetATK(int ATK) //TBS: Set ATK Functiion   
        {
            _characterATK = Math.Clamp(ATK,1,10); //NN: Clamp
        }
        public void CharacterSetHP(int HP) //TBS: Set HP Functiion
        {
            _characterHP = Math.Clamp(HP, 1, 20); //NN: Clamp
        }
        public void CharacterSetINT(int INT) //TBS: Set INT Functiion
        {
            _characterINT = Math.Clamp(INT, 0, 10); //NN: Clamp
        }

        public string GetProfessionName() //TBS: Get Function for Name
        {
            return _characterProfession.GetProfessionName();
        }

        public int GetProfessionATK() //TBS: Get Function for ATK
        {
            return _characterProfession.GetProfessionATK();
        } 
         
        public int GetProfessionHP() //TBS: Get Function for HP
        {
            return _characterProfession.GetProfessionHP();
        }

        public int GetProfessionINT() //TBS: Get Function for INT
        {
            return _characterProfession.GetProfessionINT();
        }

        public string CharacterGetName() //TBS: Get Function for character name
        {
            return _characterName;
        }

        public int GetCharacterHP() //TBS
        {
            return _characterHP;
        }
        public int GetCharacterATK() //TBS
        {
            return _characterATK;
        }
        public int GetCharacterINT() //TBS
        {
            return _characterINT;
        }
        public void CharacterSetBasicIngredient(Ingredient ingred) //NN
        {
            characterBasicIngred = ingred;
        }
        public string GetBasicIngredientName() //NN
        {
            if (characterBasicIngred != null)
                return characterBasicIngred.getStats().Name;
            else
                return "None";
        }
        public (int HP, int ATK, int INT) GetBasicIngredientStats() //NN
        {
            if (characterBasicIngred != null)
            {
                var stats = characterBasicIngred.getStats();
                return (stats.HP, stats.ATK, stats.INT);
            }
            else
                return (0, 0, 0);
        }

        public void SetEquippedMeal(Meal meal) //NN
        {
            equippedMeal = meal;
        }
        public (int HP, int ATK, int INT) GetEquippedMealStats() //NN
        {
            if (equippedMeal != null)
            {
                var stats = equippedMeal.getStats();
                return (stats.HP, stats.ATK, stats.INT);
            }
            else
                return (0, 0, 0);
        }
        public string GetEquippedMealEffect() //NN
        {
            if (equippedMeal != null)
                return equippedMeal.GetMealEffect();
            else
                return "None";
        }
        #endregion

        #region Properties
        public string CharacterName //TBS: Property for character name to be used with combobox
        {
            get { return _characterName; }
        }

        #endregion

        #region Ability Functions
        public static int useBasicAttack(Character activechar) //TBS: Function to use basic attack
        {
            int calcdmg;

            calcdmg = activechar.GetProfessionATK();

            return calcdmg;
        }

        public void useSpecialAttack() //TBS: Secondary attack for use with ingrediants
        {

        }

        #endregion
    }
}
