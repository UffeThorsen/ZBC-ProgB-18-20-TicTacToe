using System;
using System.Collections.Generic;

namespace TicTacToe
{
    static class ConsoleUI
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

            Console.WriteLine("What gametype do you wan to play?");
            Console.WriteLine("1. Classic");
            Console.WriteLine("2. Morden");
            bool morden = false;
            bool asking = true;
            while (asking)
            {
                string input = Console.ReadLine().Trim().ToLower();
                asking = false;
                switch (input)
                {
                    case "1":
                        break;

                    case "2":
                        morden = true;
                        break;

                    default:
                        Console.WriteLine("Sorry, we didnt understand your input");
                        asking = true;
                        break;
                }
            }

            Game currentGame = new Game();
            bool running = true;
            Console.Clear();
            while (running)
            {
                Console.WriteLine(currentGame);
                Console.WriteLine("PLayer " + (int)currentGame.CurrentPlayer + "´s turn (" + currentGame.CurrentPlayer + ")");  
                if (/* Is all the symbols used?*/ false && morden)
                {
                    Console.WriteLine("What symbol du you want to move (write position!)");
                    string input1 = Console.ReadLine().Trim().ToLower();
                    string input2 = Console.ReadLine().Trim().ToLower();
                    int num1 = int.Parse(input1)-1;
                    int num2 = int.Parse(input2)-1;
                    Console.WriteLine("At what position do you want to place your symbol at?");
                    string input3 = Console.ReadLine().Trim().ToLower();
                    string input4 = Console.ReadLine().Trim().ToLower();
                    int num3 = int.Parse(input3)-1;
                    int num4 = int.Parse(input4)-1;
                    if (currentGame.Turn(num1, num2, num3, num4))
                    {
                        Console.WriteLine("illegal action!");
                    }
                }
                else
                {
                    Console.WriteLine("At what position do you want to place your symbol at?");
                    string input1 = Console.ReadLine().Trim().ToLower();
                    string input2 = Console.ReadLine().Trim().ToLower();
                    int num1 = int.Parse(input1)-1;
                    int num2 = int.Parse(input2)-1;
                    Console.Clear();
                    if (!currentGame.Turn(num1, num2))
                    {
                        Console.WriteLine("The spot was taken!");
                    }
                }
                if (currentGame.WhoWon() != 0)
                {
                    running = false;
                    Console.Clear();
                    Console.WriteLine("Player " + (int)currentGame.WhoWon() + " WON!");
                } else if (currentGame.IsBoardFull() && !morden)
                {
                    running = false;
                    Console.Clear();
                    Console.WriteLine("Alle the places on the board have been used! Everyone LOST!");
                }
            }
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
                        SinglePLayer();
                        break;

                    case "2":
                        OneVOne();
                        break;

                    case "3":
                        AiVAi();
                        break;

                    case "4":
                        Console.WriteLine("Exiting game");
                        break;
                    default:
                        Game game = new Game();
                       // DanielsConsoleUI.PrintUI(game);
                        break;
                }
            }
            
            Console.ReadKey();
        }       


        public static Game SelectGameType()
        {
            throw new NotImplementedException();
        }

        public static IPlayer SelectPlayerType(int playerNumber)
        {
            return new ConsoleHumanPlayer();
        }

        public static Game SetupGame()
        {
            //Select the game type, create a game.
            //Select player types and add players to game.
            //return game
            List<IPlayer> players = new List<IPlayer>();
            players.Add(SelectPlayerType(1));
            players.Add(SelectPlayerType(2));
            Game game = new Game(players);
            return game;
          //  throw new NotImplementedException();
        }

        public static void RunGame(Game game)
        {
            //while
            //Display game state
            //let game take next move
            //thus game keeps track of it's players AND can enforce the right type of player
            Console.Clear();
            bool running = true;
            while (running)
            {
                Console.WriteLine(game);
                game.NextMove();
                Console.Clear();
                if (game.IsGameOver)
                {
                    running = false;
                }
            }
            throw new NotImplementedException();
        }
    }
    
    
}
