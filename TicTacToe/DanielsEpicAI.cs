﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class DanielsEpicAI :IPlayer
    {
        Placement NextMove(Game gameState)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (gameState.IsLegalMove(i,j))
                    {
                        return new Placement(i,j);
                    }
                }
                
            }
            throw new Exception();
        }
    }
}