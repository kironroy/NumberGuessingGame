using System;
using System.Globalization;
using System.Collections.Generic;


namespace NumberGuessingGame
{
    public class Game
    {
        static string characterName;
        static string characterNameProper;
        static int playersGuess = 0;
        static int targetNumber = 5;
        static string Input = " ";
        static Random RandomNumber = new Random();

        public static void CharacterName()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Type your name");
            characterName = Console.ReadLine().Trim().ToLower();
            characterNameProper = new CultureInfo("en-US").TextInfo.ToTitleCase(characterName);
            Console.Clear();

            Console.WriteLine($"Hello {characterNameProper} I am the Number Wizard");
            Console.WriteLine(); // breakline
        }

        public static void Play()
        {
            targetNumber = RandomNumber.Next(10) + 1;
            Console.Write("Guess what number I am thinking of... ");
            Input = Console.ReadLine();
            if (int.TryParse(Input, out playersGuess))
            {
                if (playersGuess == targetNumber)
                {
                    CorrectNumber.CorrectTitle();
                    Console.WriteLine($"Congratulations! You guessed {playersGuess} and the number I was thinking of was {targetNumber}.");
                    Console.WriteLine();
                    Console.WriteLine("Press enter");
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"Too bad. You guessed {playersGuess} and the number I was thinking of was {targetNumber}, Try again!");
                    Console.WriteLine();
                    Console.WriteLine("Press enter");
                    //Console.Clear();

                }
            }
            else
            {
                Console.WriteLine("Please type a number");
                Console.Clear();
            }

            Console.Read();
        }

    }
}
