using System;

namespace TicTacToe
{
    class ConsoleUI
    {
       public static void runGame()
        {
            Console.WriteLine("TicTacToe the game\n");
            Console.WriteLine("Press a key to start the game");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("1. Singleplayer");
            Console.WriteLine("2. 1v1");
            Console.WriteLine("3. Exit game");
            start:
            string input = Console.ReadLine().Trim().ToLower();            
            switch (input)
            {
                case "1":
                    Console.WriteLine("Press any key to start the game");
                    Console.ReadKey();
                    //Start singleplayer game. 
                    break;

                case "2":
                    Console.WriteLine("Press any key to start the game");
                    Console.ReadKey();
                    //start 1v1/multiplayer game. 
                    break;

                case "3":
                    Console.WriteLine("Press any key to start the game");
                    Console.ReadKey();
                    break; 

                default:
                    Console.WriteLine("Sorry, we didnt understand your input");
                    Console.Clear();
                    goto start;
                   
                    
            }

            
            Console.ReadKey();
        }      
    }
}
