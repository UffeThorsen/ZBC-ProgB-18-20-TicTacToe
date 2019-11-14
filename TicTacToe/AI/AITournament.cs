using System;
using System.Collections.Generic;

namespace TicTacToe
{
    class AITournament
    {
        public static int[] RunLeague()
        {
            return RunLeague(3, 0, 1);
        }
        public static int[] RunLeague(int win, int loss, int tie, bool verbose=true)
        {
            Type[] AIs = ConsoleUI.NoMove3by3AIs;
            int[] scores = new int[AIs.Length];
            for(int i=0; i<AIs.Length; i++)
            {
                for(int j=0; j<AIs.Length; j++)
                {
                    if (i != j && i != 0 && j != 0) {
                        if (verbose) { Console.WriteLine("Now playing: " + AIs[i] + " vs. " + AIs[j]); }
                        IPlayer p1 = (IPlayer)Activator.CreateInstance(AIs[i]);
                        IPlayer p2 = (IPlayer)Activator.CreateInstance(AIs[j]);
                        Game game = new Game(p1, p2);
                        while (!game.IsGameDone)
                        {
                            game.NextMove();
                        }
                        //if first player won, add win to scores[i] and loss to scores[j]
                        if(game.WhoWon() == p1)
                        {
                            scores[i] += win;
                            scores[j] += loss;
                        }
                        //if second player won, add win to scores[j] and loss to scores[i]
                        else if (game.WhoWon() == p2)
                        {
                            scores[j] += win;
                            scores[i] += loss;
                        }
                        //if tied, add tie to scores[i] and scores[j]
                        else
                        {
                            scores[i] += tie;
                            scores[i] += tie;
                        }
                        
                        
                    }
                }
            }
            if (verbose)
            {
                Console.WriteLine("The final scores are: \n");
                for (int i = 1; i < AIs.Length; i++)
                {
                    Console.WriteLine(scores[i] + "\t-\t" + AIs[i]);
                }

                Console.WriteLine("\nMaximum possible score is " + ((AIs.Length - 2) * win * 2));
                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
            }
            return scores;
        }

        public static int[] RunNLeagues(int n)
        {
            return RunNLeagues(n, 3, 0, 1);
        }
        public static int[] RunNLeagues(int n, int win, int loss, int tie, bool verbose=true)
        {
            int[] scoresSummed = new int[ConsoleUI.NoMove3by3AIs.Length];
            for(int i=0; i<n; i++)
            {
                int[] scores = RunLeague(win, loss, tie, false);
                for(int j=0; j<scores.Length; j++)
                {
                    scoresSummed[j] += scores[j];
                }
            }
            if (verbose)
            {
                Console.WriteLine("The final scores are: \n");
                for (int i = 1; i < scoresSummed.Length; i++)
                {
                    Console.WriteLine(scoresSummed[i] + "\t-\t" + ConsoleUI.NoMove3by3AIs[i]);
                }

                Console.WriteLine("\nMaximum possible score is " + ((scoresSummed.Length - 2) * win * 2 * n));
                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
            }

            return scoresSummed;
        }
    }
}
