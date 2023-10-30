using System.Runtime.CompilerServices;

namespace DiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();
            Guess guess = new Guess();
            int diceNumber = dice.Roll();
            
            Console.WriteLine("Dice rolled, try and guess which number:");
            string userInput = Console.ReadLine();
            int userGuessConverted = guess.ConvertInputToInt(userInput);


            do
            {
                if (userGuessConverted == diceNumber)
                {
                    Console.WriteLine($"Correct! The number was {diceNumber}");
                    Console.WriteLine($"It took {guess.amountOfGuesses} guesses.");
                }
                else
                {
                    Console.WriteLine($"Incorrect, try again! You have {3 -guess.amountOfGuesses} guesses left.");
                    guess.UpdateAmountOfGuesses();
                    if(guess.amountOfGuesses == 3)
                    {
                        guess.UpdateLoseStatus();
                    }
                    userInput = Console.ReadLine();
                }
            } while (guess.amountOfGuesses < 3 && guess.hasUserLost == false);

            if (guess.amountOfGuesses == 3)
            {
                Console.WriteLine("You lose! better luck next time!");
            }
    }
    }
}