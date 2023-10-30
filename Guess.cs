using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    public class Guess
    {
        public int amountOfGuesses = 1;
        public bool hasUserLost = false;

        public void UpdateAmountOfGuesses()
        {
            amountOfGuesses++;
        }

        public void UpdateLoseStatus()
        {
            hasUserLost = true;
        }

        public int ConvertInputToInt(string userInput)
        {
            return Convert.ToInt32(userInput);
        }

                
    }
}
