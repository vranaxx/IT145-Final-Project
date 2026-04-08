using System;
using System.Collections.Generic;
using System.Text;

namespace IT145_FinalProject
{
    internal class Combat
    {
        static private int _turnTracker;
        private int _currentChar = -1;

        public Combat()
        {

        }

        public void CombatStart(Character char1, Character char2)
        {
            char2.CharacterSetHP(char2.GetCharacterHP() - Character.useBasicAttack(char1));
        }

        public void CombatSetTurn(int turn)
        {
            _turnTracker = turn;
        }

        static public int CombatInitializeTurn()
        {
            _turnTracker = 1;

            return _turnTracker;
        }

        public void CombatNextChar()
        {
            if (Character._characterList.Count > 3)
            {
                _currentChar++;
            }
            else { _currentChar = 0; };
        }
    }
}
