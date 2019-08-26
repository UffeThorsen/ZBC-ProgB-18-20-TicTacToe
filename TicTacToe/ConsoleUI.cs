using System;

namespace TicTacToe
{
    class ConsoleUI
    {
        public static void singlePLayer()
        {

        }
       public static void runGame()
        {
            Console.WriteLine("TicTacToe the game\n");
            Console.WriteLine("Press a key to start the game");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("1. Singleplayer");
            Console.WriteLine("2. 1v1");
            Console.WriteLine("3. AI v AI");
            Console.WriteLine("3. Exit game");
            start:
            string input = Console.ReadLine().Trim().ToLower();            
            switch (input)
            {
                case "1":
                    Console.WriteLine("1. 3 tokens with moves");
                    Console.WriteLine("2. Unlimited tokens");
                    Console.WriteLine("3. 3 tokens in order");
                    string input1 = Console.ReadLine().Trim().ToLower();
                    switch (input1)
                    {
                        case "1":
                            Console.WriteLine("");
                        break;
                    }

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
        /*
        static void Main(string[] args)
        {
            runGame();
        }
        */
    }
    
    
}
