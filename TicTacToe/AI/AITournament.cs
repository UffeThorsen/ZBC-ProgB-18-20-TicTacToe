using System;
using System.Collections.Generic;

namespace TicTacToe
{
    class AITournament
    {
        public static void RunLeague()
        {
            RunLeague(3, 0, 1);
        }

        public static void RunLeague(int win, int loss, int tie)
        {
            Type[] AIs = ConsoleUI.NoMove3by3AIs;
            int[] scores = new int[AIs.Length];
            for(int i=0; i<AIs.Length; i++)
            {
                for(int j=0; j<AIs.Length; j++)
                {
                    if (i != j && i != 0 && j != 0) {
                        Console.WriteLine("Now playing: " + AIs[i] + " vs. " + AIs[j]);
                        var players = new List<IPlayer>();
                        players.Add( (IPlayer)Activator.CreateInstance(AIs[i]) );
                        players.Add( (IPlayer)Activator.CreateInstance(AIs[j]) );
                        Game game = new Game(players);
                        while (!game.IsGameDone)
                        {
                            game.NextMove();
                        }
                        //if first player won, add win to scores[i] and loss to scores[j]
                        if(game.WhoWon() == players[0])
                        {
                            scores[i] += win;
                            scores[j] += loss;
                        }
                        //if second player won, add win to scores[j] and loss to scores[i]
                        else if (game.WhoWon() == players[1])
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

            Console.WriteLine("The final scores are: \n");
            for(int i=1; i<AIs.Length; i++)
            {
                Console.WriteLine(scores[i] + "\t-\t" + AIs[i]);
            }
        }
    }
}
