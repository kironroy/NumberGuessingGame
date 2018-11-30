using System;
using System.Globalization;
using System.Collections.Generic;

public static class OpeningGameScene
{
    public static void ArtTitle()
    {

        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.Title = "ASCII Art";
        Console.WriteLine(); // breakline
        Console.WriteLine(); // breakline
        Console.WriteLine(); // breakline
        string title =
            @"
                                
                                   
                             ███▄    █  █    ██  ███▄ ▄███▓ ▄▄▄▄   ▓█████  ██▀███       ▄████  ▄▄▄       ███▄ ▄███▓▓█████ 
                             ██ ▀█   █  ██  ▓██▒▓██▒▀█▀ ██▒▓█████▄ ▓█   ▀ ▓██ ▒ ██▒    ██▒ ▀█▒▒████▄    ▓██▒▀█▀ ██▒▓█   ▀ 
                            ▓██  ▀█ ██▒▓██  ▒██░▓██    ▓██░▒██▒ ▄██▒███   ▓██ ░▄█ ▒   ▒██░▄▄▄░▒██  ▀█▄  ▓██    ▓██░▒███   
                            ▓██▒  ▐▌██▒▓▓█  ░██░▒██    ▒██ ▒██░█▀  ▒▓█  ▄ ▒██▀▀█▄     ░▓█  ██▓░██▄▄▄▄██ ▒██    ▒██ ▒▓█  ▄ 
                            ▒██░   ▓██░▒▒█████▓ ▒██▒   ░██▒░▓█  ▀█▓░▒████▒░██▓ ▒██▒   ░▒▓███▀▒ ▓█   ▓██▒▒██▒   ░██▒░▒████▒
                            ░ ▒░   ▒ ▒ ░▒▓▒ ▒ ▒ ░ ▒░   ░  ░░▒▓███▀▒░░ ▒░ ░░ ▒▓ ░▒▓░    ░▒   ▒  ▒▒   ▓▒█░░ ▒░   ░  ░░░ ▒░ ░
                            ░ ░░   ░ ▒░░░▒░ ░ ░ ░  ░      ░▒░▒   ░  ░ ░  ░  ░▒ ░ ▒░     ░   ░   ▒   ▒▒ ░░  ░      ░ ░ ░  ░
                               ░   ░ ░  ░░░ ░ ░ ░      ░    ░    ░    ░     ░░   ░    ░ ░   ░   ░   ▒   ░      ░      ░   
                                     ░    ░            ░    ░         ░  ░   ░              ░       ░  ░       ░      ░  ░
                                                                 ░                                                        

                                                                 

                ";

        Console.WriteLine(title);
        Console.WriteLine(); // breakline
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("                                                     Press enter to continue...");
        Console.ReadKey();
        Console.Clear();


    }
}