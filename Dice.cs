using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    internal class Dice
    {
        private Random randomNumber = new Random();
        private int diceNumber;

        public Dice()
        {
            diceNumber = randomNumber.Next(1, 6);
        }

        public int Roll()
        {
            return diceNumber;
        }
    }
}
