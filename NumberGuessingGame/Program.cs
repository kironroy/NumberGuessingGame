using System;
using System.Globalization;
using System.Collections.Generic;


namespace NumberGuessingGame
{
    class Program
    {
        static void Main()
        {
            OpeningGameScene.ArtTitle(); // art screen  

            Game.CharacterName();  // intro

            string myChoice;

            do
            {



                Console.WriteLine("S - Start Quiz");
                Console.WriteLine("Q - Quit\n");
                Console.WriteLine("Choose S or Q: ");
                // Retrieve the user's choice
                myChoice = Console.ReadLine().Trim().ToUpper();
                switch (myChoice)
                {
                    case "S":
                        Game.Play();
                        Console.Clear();
                        break;
                    case "Q":
                        EndingGameScene.EndTitle();
                        break;
                    default:
                        Console.WriteLine(); // breakline
                        Console.WriteLine(String.Format("{0} is not a valid choice", myChoice));
                        Console.Clear();
                        break;

                } // do's end bracket
            } while (myChoice != "Q"); // users quits

           

        }
    }
}
