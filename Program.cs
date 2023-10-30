using System.Runtime.CompilerServices;

namespace DiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();
            int diceNumber = dice.DiceRoll();
            int amountOfGuesses = 1;
            
            Console.WriteLine("Dice rolled, try and guess which number:");
            string userGuess = Console.ReadLine();
            int userGuessConverted = Convert.ToInt32(userGuess);

            do
            {
                if (userGuessConverted == diceNumber)
                {
                    Console.WriteLine($"Correct! The number was {diceNumber}");
                    Console.WriteLine($"It took {amountOfGuesses} guesses.");
                    amountOfGuesses = 3;
                }
                else
                {
                    Console.WriteLine($"Incorrect, try again! You have {3 - amountOfGuesses} guesses left.");
                    amountOfGuesses++;
                    userGuess = Console.ReadLine();
                }
            } while (amountOfGuesses < 3);

            if (amountOfGuesses == 3)
            {
                Console.WriteLine("You lose! better luck next time!");
            }
    }
    }
}