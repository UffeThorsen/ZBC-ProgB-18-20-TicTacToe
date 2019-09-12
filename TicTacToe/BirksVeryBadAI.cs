using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class BirksVeryBadAI
    {
        public Placement NextMove(Game gameState)
        {
            bool parsed = false;
            while (!parsed)
            {
                Console.WriteLine(gameState);
                string rowStr = "0";
                string colStr = "0";
                parsed = int.TryParse(rowStr, out int i);
                parsed &= int.TryParse(rowStr, out int j);
                if (parsed)
                {
                    Placement move = new Placement(i, j);
                    if (gameState.IsLegalMove(move))
                    {
                        return move;
                    }
                    else
                    {
                        if (rowStr == "0")
                        {
                            rowStr = "1";
                        }
                        else if (rowStr == "1")
                        {
                            if(colStr == "0")
                            {
                                colStr = "1";
                            }
                            else if (colStr == "1")
                            {
                                colStr = "2";
                            }
                            else
                            {
                                rowStr = "2";
                            }
                        }
                        else if (rowStr == "2")
                        {
                            if(colStr == "0")
                            {
                                colStr = "1";
                            }
                            else if (colStr == "1")
                            {
                                colStr = "2";
                            }
                        }
                        parsed = false;
                    }

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Something didn't work, let's try again...");
                }
            }
            return new Placement();//For compilers sake only
        }
    }
}
