using System;



namespace NumberGuessingGame
{
    public static class EndingGameScene
    {
        public static void EndTitle()
        {
            //Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.Title = "ASCII Art";
            Console.WriteLine(); // breakline
            Console.WriteLine(); // breakline
            Console.WriteLine(); // breakline
            string title =
                @"
                               
                     
                                                       

                                     ██████╗ ██╗   ██╗██╗████████╗████████╗███████╗██████╗ ██╗
                                    ██╔═══██╗██║   ██║██║╚══██╔══╝╚══██╔══╝██╔════╝██╔══██╗██║
                                    ██║   ██║██║   ██║██║   ██║      ██║   █████╗  ██████╔╝██║
                                    ██║▄▄ ██║██║   ██║██║   ██║      ██║   ██╔══╝  ██╔══██╗╚═╝
                                    ╚██████╔╝╚██████╔╝██║   ██║      ██║   ███████╗██║  ██║██╗
                                     ╚══▀▀═╝  ╚═════╝ ╚═╝   ╚═╝      ╚═╝   ╚══════╝╚═╝  ╚═╝╚═╝
                                                          

        
                                                                                              

                                                       

                ";

            Console.WriteLine(title);
            Console.ReadKey();
            Console.Clear();


        }
    }
}
