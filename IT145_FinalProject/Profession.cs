/*
 * Program: Profession Class
 * Purpose: Class to define what a profession is for use in character class
 * Author: Thomas Shampney
 * Date: 2026-03-20
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace IT145_FinalProject
{
    internal class Profession
    {
        // private HashSet<String> _professionNames = new HashSet<String>() { "Warrior", "Tank", "Rogue" }; //TBS: HashSet for class names

        private string _professionName; //TBS: Variable for class name; also used as UID
        private int _professionINT; //TBS: Profession base INT stat
        private int _professsionHP; //TBS: Profession base HP stat
        private int _professionATK; //TBS: Profession base ATK stat

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
    }
}
