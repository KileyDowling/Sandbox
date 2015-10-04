using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepPlaying = false;
            Console.WriteLine("Please enter a word");
            string userInput = Console.ReadLine();

            Hangman hangman = new Hangman(userInput);
            Console.WriteLine(hangman.buildBoard());

            while (!keepPlaying)
            {
                Console.WriteLine("Please enter a single letter guess");
                string userGuess = Console.ReadLine();
                bool result = hangman.guessedLetterCorrectly(userGuess[0]);
                char guess = userGuess[0];
                hangman.acceptUserGuess(guess);
                Console.WriteLine(hangman.updateBoard());
                keepPlaying = hangman.solvedPuzzle();
            }
            Console.WriteLine("Congrats, you won!");

            Console.ReadLine();

        }
    }

    public class Hangman
    {
        string userInput;
        int numOfLetters;
        char[] userGuesses = new char[26];
        int currentPlacement = 0;
        string completedPuzzle = "";
        private string result = "";

        public bool solvedPuzzle()
        {
            completedPuzzle = result;
            if (userInput == completedPuzzle)
            {
                return true;
            }
            return false;
        }

        public Hangman(string input)
        {
            this.userInput = input;
            this.numOfLetters = userInput.Length;
        }

        public bool guessedLetterCorrectly(char guess)
        {
            for (int i = 0; i < numOfLetters; i++)
            {
                if (guess == userInput[i])
                {
                    Console.WriteLine("There was a {0}!", guess);
                    return true;

                }
            }
            Console.WriteLine("Sorry, there was no {0}!", guess);

            return false;
        }

        public bool acceptUserGuess(char guess)
        {
            for (int i = 0; i < currentPlacement + 1; i++)
            {
                if (guess == userGuesses[i])
                {
                    Console.WriteLine("You already guessed that letter!");
                    currentPlacement++;
                    return true;
                }
            }
            userGuesses[currentPlacement] = guess;
            currentPlacement++;
            return false;
        }


        public string buildBoard()
        {
            for (int i = 0; i < numOfLetters; i++)
            {
                result += "_";
            }

            return result;
        }

        public string updateBoard()
        {
            char[] updatedResult = result.ToCharArray();
           

            for (int i = 0; i < userInput.Length; i++)
            {
                for (int j = currentPlacement-1; j < currentPlacement; j++)
                {
                    if (userInput[i] == userGuesses[j])
                    {
                        updatedResult[i] = userInput[i];
                    }

                }
            }

            string asString = new string(updatedResult);
            result = asString;
            return asString;
        }



    }
    
}
