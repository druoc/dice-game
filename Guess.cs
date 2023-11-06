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
        public int maxGuesses = 3;
        public bool hasUserLost = false;
        public bool hasUserWon = false;
        public string userInput { get; private set; }
        public string userInputConverted { get; private set; }


        public void UpdateAmountOfGuesses()
        {
            amountOfGuesses++;
        }

        public void UpdateLoseStatus()
        {
            hasUserLost = true;
        }

        public void UpdateWinStatus()
        {
            hasUserWon = true;
        }

        public void GetUserInput()
        {
            userInput = Console.ReadLine();
        }

        public int ConvertInputToInt()
        {
            return Convert.ToInt32(userInput);
        }

                
    }
}
