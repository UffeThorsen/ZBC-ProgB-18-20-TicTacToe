using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class NicolaiStupidAI : IPlayer
    {
        public Placement NextMove(Game gameState)
        {
            int i = 0;
            int j = 0;
            Placement p = new Placement(i, j);

            if (gameState.IsLegalMove(p))
            {
                for (; i > 3; i++)
                {
                    for (; j > 3; j++)
                    {


                        return p;

                    }
                }
            }
            else
            { 
                Console.WriteLine("No avilable moves ");
            } 
            

            throw new NotImplementedException("Not fully done");
        }
    }
}
