using System;

namespace TicTacToe
{
    class ConsoleUI
    {
        /// <summary>
        /// Player VS AI
        /// </summary>
        static void SinglePLayer()
        {
            Console.Clear();
            Console.WriteLine("Singleplayer\n\n");
            Console.WriteLine("1. 3 tokens with moves");
            Console.WriteLine("2. Unlimited tokens");
            Console.WriteLine("3. 3 tokens in order");
            bool asking = true;
            while (asking)
            {
                string input1 = Console.ReadLine().Trim().ToLower();
                asking = false;
                switch (input1)
                {
                    case "1":
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine("Sorry, we didnt understand your input");
                        asking = true;
                        break;
                }
            }
        }

        /// <summary>
        /// Player VS Player
        /// </summary>
        static void OneVOne()
        {
            Console.Clear();
            Console.WriteLine("1v1\n\n");
            Game currentGame = new Game();
        }

        /// <summary>
        /// Shows the player 2 AI´s paying
        /// </summary>
        static void AiVAi()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Initial run of the game
        /// </summary>
       public static void RunGame()
        {
            Console.WriteLine("TicTacToe the game\n\n");
            Console.WriteLine("1. Singleplayer");
            Console.WriteLine("2. 1v1");
            Console.WriteLine("3. AI v AI");
            Console.WriteLine("4. Exit game");
            bool asking = true;
            while (asking)
            {
                string input = Console.ReadLine().Trim().ToLower();
                asking = false;
                switch (input)
                {
                    case "1":
                        //Start singleplayer game. 
                        SinglePLayer();
                        break;

                    case "2":
                        OneVOne();
                        //start 1v1/multiplayer game. 
                        break;

                    case "3":
                        AiVAi();
                        break;

                    case "4":
                        Console.WriteLine("Exiting game");
                        break;
                    default:
                        Console.WriteLine("Sorry, we didnt understand your input");
                        asking = true;
                        break;
                }
            }
            
            Console.ReadKey();
        }       
    }
    
    
}
