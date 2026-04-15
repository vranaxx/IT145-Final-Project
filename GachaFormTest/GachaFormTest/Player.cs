using System;
using System.Collections.Generic;
using System.Text;

namespace GachaFormTest
{
    public class Player
    {
        public int Currency;

        public Player(int startingCurrency)
        {
            Currency = startingCurrency;
        }

        public bool Spend(int amount)
        {
            if (Currency < amount)
                return false;

            Currency -= amount;
            return true;
        }

        public void AddCurrency(int amount)
        {
            Currency += amount;
        }
    }
}
