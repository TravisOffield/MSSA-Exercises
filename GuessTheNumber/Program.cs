using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a game! Guess a number between 1 and 100.");
            playGame();
        }

        public static void playGame()
        {
            Random randNum = new Random();
            int myNum = randNum.Next(1, 100);
            int numGuesses = 1;
            string yourGuessTxt = Console.ReadLine();
            int yourGuess = int.Parse(yourGuessTxt);

            while (yourGuess != myNum)
            {
                if (yourGuess >= myNum)
                {
                    numGuesses++;
                    Console.WriteLine("Your guess is too high, guess again.");
                    string newGuessTxt = Console.ReadLine();
                    int newGuess = int.Parse(newGuessTxt);
                    yourGuess = newGuess;
                }
                else if (yourGuess <= myNum)
                {
                    numGuesses++;
                    Console.WriteLine("Your guess is too low, guess again.");
                    string newGuessTxt = Console.ReadLine();
                    int newGuess = int.Parse(newGuessTxt);
                    yourGuess = newGuess;
                }
            }

            if (yourGuess == myNum)
            {
                Console.WriteLine($"Good job, you got it in {numGuesses} guesses.");
            }
        }
    }
}
