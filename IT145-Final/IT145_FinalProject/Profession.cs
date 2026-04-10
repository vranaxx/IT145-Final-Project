/*
 * Program: Profession Class
 * Purpose: Class to define what a profession is for use in character class
 * Author: Thomas Shampney
 * Date: 2026-04-05
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace IT145_FinalProject
{
    internal class Profession
    {
        private string _professionName; //TBS: Variable for class name; also used as UID
        private int _professionINT; //TBS: Profession base INT stat
        private int _professsionHP; //TBS: Profession base HP stat
        private int _professionATK; //TBS: Profession base ATK stat

        private static Random random = new Random();

        public Profession() //TBS: Defaault Constructor
        {

        }
        public Profession(string name) //TBS: Constructor based on class
        {
            switch (name)
            {
                case "Warrior":
                    _professionName = "Warrior";
                    _professionATK = 5;
                    _professionINT = 2;
                    _professsionHP = 3;
                    break;
                case "Tank":
                    _professionName = "Tank";
                    _professionATK = 3;
                    _professionINT = 2;
                    _professsionHP = 5;
                    break;
                case "Ranged":
                    _professionName = "Ranged";
                    _professionATK = 4;
                    _professionINT = 4;
                    _professsionHP = 2;
                    break;
                default:
                    break;
            }
        }

        public string GetProfessionName()
        {
            return _professionName; 
        }
        public int GetProfessionINT()
        {
            return _professionINT;
        }

        public int GetProfessionHP()
        {
            return _professsionHP;
        }

        public int GetProfessionATK()
        {
            return _professionATK;
        }
        public static Profession GetCharacterProffesionRandom()
        {
            Character._professions.Add(new Profession("Warrior"));
            Character._professions.Add(new Profession("Tank"));
            Character._professions.Add(new Profession("Ranged"));            

            int index = random.Next(Character._professions.Count);
            return Character._professions[index];
        }
    }
}
