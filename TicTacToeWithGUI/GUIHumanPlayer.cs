using System;
using TicTacToe;

namespace TicTacToeWithGUI
{
    public class GUIHumanPlayer :IPlayer
    {
        public string Description
        {
            get
            {
                return "Human Player";
            }
        }

        public Placement NextMove(Game gamestate)
        {
            return PlayerInputHolder.input;
        }
    }
}
