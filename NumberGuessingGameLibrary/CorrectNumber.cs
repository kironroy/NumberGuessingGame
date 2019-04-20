using System;

namespace NumberGuessingGame
{
    public static class CorrectNumber
    {
        public static void CorrectTitle()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Title = "ASCII Art";
            Console.WriteLine(); // breakline
            Console.WriteLine(); // breakline
            Console.WriteLine(); // breakline
            string title =
                @"
                                
                                   
                          
                                         ██████╗ ██████╗ ██████╗ ██████╗ ███████╗ ██████╗████████╗
                                        ██╔════╝██╔═══██╗██╔══██╗██╔══██╗██╔════╝██╔════╝╚══██╔══╝
                                        ██║     ██║   ██║██████╔╝██████╔╝█████╗  ██║        ██║   
                                        ██║     ██║   ██║██╔══██╗██╔══██╗██╔══╝  ██║        ██║   
                                        ╚██████╗╚██████╔╝██║  ██║██║  ██║███████╗╚██████╗   ██║   
                                         ╚═════╝ ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝ ╚═════╝   ╚═╝   
                                                          


                                                                 

                ";

            Console.WriteLine(title);
            Console.WriteLine(); // breakline
            //Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Press enter");
            Console.ReadKey();
            Console.Clear();


        }
    }
}
