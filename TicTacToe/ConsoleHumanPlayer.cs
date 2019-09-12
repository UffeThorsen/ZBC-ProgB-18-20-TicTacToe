﻿using System;


namespace TicTacToe
{
    class ConsoleHumanPlayer :IPlayer
    {
        public Placement NextMove(Game gameState)
        {
            bool parsed = false;
            while (!parsed)
            {
                Console.WriteLine(gameState);
                Console.WriteLine("\nWhere do you want to place your symbol?");
                Console.Write("Row number: ");
                string rowStr = Console.ReadLine();
                Console.Write("Column number: ");
                string colStr = Console.ReadLine();
                parsed = int.TryParse(rowStr, out int i);
                parsed &= int.TryParse(colStr, out int j);
                if (parsed)
                {
                    Placement move = new Placement(i, j);
                    //if (gameState.IsLegalMove(move))
                    if(true)
                    {
                        return move;
                    }
                    else
                    {
                        Console.WriteLine("That is not a legal move, the rules are:");
                        //Console.WriteLine(gameState.Rules);
                        Console.WriteLine("Let's try a new move...");
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