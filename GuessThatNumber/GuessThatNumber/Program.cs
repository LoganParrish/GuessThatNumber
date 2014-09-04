using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThatNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playing = true;
            while (playing)
            {
                GuessNumber();
                string playAgain = Console.ReadLine();
                if (playAgain == "n")
                {
                    Console.WriteLine("\n\n\nThanks for playing!");
                    playing = false;
                }
                else
                {
                    
                }
            }
            
            
            Console.ReadKey();
        }
        static void GuessNumber()
        {
            Console.WriteLine("Guess a number between 1 and 100");

            int guessCount = 1;

            Random randomNumGen = new Random();

            int randomNumber = randomNumGen.Next(0, 100);

            bool winnerChickenDinner = true;

            while (winnerChickenDinner)
            {
                string input = Console.ReadLine();

                oint playerGuess = int.Parse(input);

                if (playerGuess > randomNumber)
                {
                    guessCount++;
                    Console.WriteLine("Go a bit lower, sweetie.");

                    if (playerGuess - randomNumber > 50)
                    {
                        Console.WriteLine("You're cold as hell.");
                    }
                    else if (playerGuess - randomNumber > 25)
                    {
                        Console.WriteLine("You're warm I guess.");
                    }
                    else if (playerGuess - randomNumber > 10)
                    {
                        Console.WriteLine("You're getting warmer...");
                    }
                    else if (playerGuess - randomNumber > 5)
                    {
                        Console.WriteLine("HOLY $#!& YOU'RE HOT");
                    }
	
                }
                else if (playerGuess < randomNumber)
                {
                    guessCount++;
                    Console.WriteLine("Go a bit higher, sugarface.");
                    if (randomNumber - playerGuess > 50)
                    {
                        Console.WriteLine("You're cold as hell.");
                    }
                    else if (randomNumber - playerGuess > 25)
                    {
                        Console.WriteLine("You're warm I guess.");
                    }
                    else if (randomNumber - playerGuess > 10)
                    {
                        Console.WriteLine("You're getting warmer...");
                    }
                    else if (randomNumber - playerGuess > 5)
                    {
                        Console.WriteLine("HOLY $#!& YOU'RE HOT");
                    }
                    else if (randomNumber - playerGuess > 0)
                    {
                        Console.WriteLine("DEEP INTO THE DEPTHS OF THE SUN YOU ARE HOT, SO HOT.");
                    }
                }
                else
                {
                    winnerChickenDinner = false;
                    Console.WriteLine(" _    _ _____ _   _  _   _  ___________ \n| |  | |_   _| \\ | || \\ | ||  ___| ___ \\\n| |  | | | | |  \\| ||  \\| || |__ | |_/ / \n| |/\\| | | | | . ` || . ` ||  __||    / \n\\  /\\  /_| |_| |\\  || |\\  || |___| |\\ \\ \n \\/  \\/ \\___/\\_| \\_/\\_| \\_/\\____/\\_| \\_|");
                    Console.WriteLine("\n\nYou made " + guessCount + " guesses.");
                    Console.WriteLine("\n\n\nWould you like to play again? y/n");
                    
                                        
                }
                  
            }

        }
    }
}
