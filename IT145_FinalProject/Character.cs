/*
 * Program: Character Class
 * Purpose: Class to store character information
 * Author: Thomas Shampney
 * Date: 2026-03-20
 */

#region To Do

/*
 * To Do
 * - Error checking and deletion of old GUID in GenereateNewGUID function
 * - Error checking for other set functions
 */

#endregion

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;

namespace IT145_FinalProject
{
    internal class Character
    {
        protected string _characterName; //TBS: Character name
        protected Guid _characterID; //TBS: Character identifier
        protected int _characterHP; //TBS: Stat for character health scaling
        protected int _characterATK; //TBS: Stat for damage scaling
        protected int _characterINT; //TBS: Stat for secondary/passive/skill scaling
        Profession _characterProfession; //TBS: Character profession inherit
        protected Ingredient characterBasicIngred;

        public static List<Character> characterInventory = new(); // List that contains all created characters

        private HashSet<Guid> _professionGUID = new HashSet<Guid>(); //TBS: HashSet for GUIDs

        #region Constructors
        public Character() //TBS: Default Constructor
        {
            _characterID = Guid.NewGuid();
            _characterName = "";
            _characterATK = 0;
            _characterHP = 0;
            _characterATK = 0;
        } 

        public Character(string charName, int charHP, int charATK, int charINT, Profession charProfession) //TBS: Full Constructor
        {
            _characterID = Guid.NewGuid();
            _characterProfession = charProfession;
            _characterName = charName;
            _characterATK = charProfession.GetProfessionATK();
            _characterINT = charProfession.GetProfessionINT();
            _characterHP = charProfession.GetProfessionHP();
        }
        public Character(Profession charProfession) //TBS: Class only constructor
        {
            _characterID = Guid.NewGuid();
            _characterProfession = charProfession;
            _characterHP = charProfession.GetProfessionHP();
            _characterATK = charProfession.GetProfessionATK();
            _characterINT = charProfession.GetProfessionINT();

        }
        public Character(Profession charProfession, string charName) //TBS: Class only constructor
        {
            _characterName = charName;
            _characterID = Guid.NewGuid();
            _characterProfession = charProfession;
            _characterHP = charProfession.GetProfessionHP();
            _characterATK = charProfession.GetProfessionATK();
            _characterINT = charProfession.GetProfessionINT();

        }
        public Character(string charName, int charHP, int charATK, int charINT) //TBS: Stat only constructor
        {
            _characterID = Guid.NewGuid();
            _characterName = charName;
            _characterATK = charATK;
            _characterINT = charINT;
            _characterHP = charHP;
        }

        #endregion

        #region Get Set
        public void CharacterSetClass (Profession charProfession) //TBS: Set character class
        {
            _characterProfession = charProfession; 
        }

        public void CharacterSetName(string name) //TBS: Set Name Functiion
        {
            _characterName = name;
        }

        public void CharacterGenNewGUID() //TBS: Set ID Functiion
        {
            _characterID = Guid.NewGuid();
        }
        public void CharacterSetATK(int ATK) //TBS: Set ATK Functiion   
        {
            _characterATK = ATK;
        }
        public void CharacterSetHP(int HP) //TBS: Set HP Functiion
        {
            _characterHP = HP;
        }
        public void CharacterSetINT(int INT) //TBS: Set INT Functiion
        {
            _characterINT = INT;
        }

        public void AddGUID (Character GUID) //TBS: Function to manually add a GUID to HashSet
        {
            _professionGUID.Add(GUID._characterID);
        }

        public void CharacterSetBasicIngredient(Ingredient ingred)
        {
            characterBasicIngred = ingred;
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

        public string GetCharacterName() //TBS: Get Function for character name
        {
            return _characterName;
        }

        public string GetBasicIngredientName()
        {
            if (characterBasicIngred != null)
                return characterBasicIngred.getStats().Name;
            else
                return "None";
        }
        public (int HP, int ATK, int INT) GetBasicIngredientStats()
        {
            if (characterBasicIngred != null)
            {
                var stats = characterBasicIngred.getStats();
                return (stats.HP, stats.ATK, stats.INT);
            }
            else
                return (0,0,0);
        }

        #endregion
    }
}
