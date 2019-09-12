using System;
using System.Collections.Generic;

namespace TicTacToe
{
    static class ConsoleUI
    {
        private static Type[] NoMove3by3AIs = {
            typeof(ConsoleHumanPlayer),
            typeof(UffeAIPlayer)
        };

        /*public static Game SelectGameType()
        {
            throw new NotImplementedException();
        }*/

        public static IPlayer SelectPlayerType()
        {
            Console.WriteLine("Which player type do you want?");
            for(int i=0; i<NoMove3by3AIs.Length; i++)
            {
                Console.WriteLine(i + ":\t" + NoMove3by3AIs[i]);
            }
            string input = Console.ReadLine();
            int index = -1;
            while (!int.TryParse(input, out index) || index >= NoMove3by3AIs.Length || index < 0)
            {
                Console.WriteLine("That is not a valid selection, try again...");
                input = Console.ReadLine();
            }
            
            return (IPlayer) Activator.CreateInstance(NoMove3by3AIs[index]);
        }

        public static Game SetupGame()
        {
            //Select the game type, create a game.
            //Select player types and add players to game.
            //return game
            List<IPlayer> players = new List<IPlayer>();
            players.Add(SelectPlayerType());
            players.Add(SelectPlayerType());
            Game game = new Game(players);
            return game;
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
                if (game.IsGameDone)
                {
                    running = false;
                }
            }
        }
    }
    
    
}
