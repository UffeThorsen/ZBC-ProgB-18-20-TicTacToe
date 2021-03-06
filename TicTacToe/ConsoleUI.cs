﻿using System;
using System.Collections.Generic;

namespace TicTacToe
{
    public static class ConsoleUI
    {
        public static Type[] NoMove3by3AIs = {
            typeof(ConsoleHumanPlayer),
            typeof(UffeAIPlayer),
            typeof(UffeSmarterAIPlayer),
            typeof(BirksVeryBadAI),
            typeof(DanielsEpicAI),
            typeof(DanielsEpicerAI),
            typeof(JacobIAI),
            typeof(ThomasAIPlayer),
            typeof(RasmusAI),
            typeof(StigAI),
            typeof(KasperAI),
            typeof(JacobAAI),
            //typeof(KarlGustavAI),
            //typeof(JannieAIPlayer),
            typeof(MFBadAI),
            typeof(PoppeAi),
            typeof(AntonAI),
        };

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
            IPlayer p1 = SelectPlayerType();
            IPlayer p2 = SelectPlayerType();
            Game game = new Game(p1, p2);
            return game;
        }

        public static void RunGame(Game game)
        {
            Console.Clear();
            while (!game.IsGameDone)
            {
                Console.WriteLine("The current state is:\n");
                Console.WriteLine(game);
                Console.WriteLine("\nNext to place is " + game.CurrentPlayer);
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                game.NextMove();
                Console.Clear();
            }
            Console.WriteLine(game);
            Console.WriteLine("The game is over.\n");
            if(game.WhoWon() == null)
            {
                Console.WriteLine("The game ended in a tie.");
            }
            else
            {
                Console.WriteLine(game.WhoWon() + " won the game.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
    
    
}
