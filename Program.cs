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
            for (int guessCount = 1; guessCount <= guess.maxGuesses; guessCount++)
            {
                int userGuess = GetUserInput();

                if (userGuess == diceNumber)
                {
                    Console.WriteLine($"Correct! The number was {diceNumber}");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                    break;
                }
                else
                {
                    int guessesLeft = guess.maxGuesses - guessCount;
                    if (guessesLeft > 0)
                    {
                        Console.WriteLine($"Incorrect, try again! You have {guessesLeft} guesses left.");
                    }
                    else
                    {
                        Console.WriteLine("You've used all your guesses. Game over!");
                    }
                }
            }
        }




        static int GetUserInput()
            {
                int userGuess;
                while(true)
                {
                    if (int.TryParse(Console.ReadLine(), out userGuess) && userGuess >= 1 && userGuess <= 6)
                    {
                        return userGuess;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number between 1 and 6.");
                    }
                }
            }
    }
 }