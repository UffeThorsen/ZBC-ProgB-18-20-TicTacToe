using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class PoppeAi : IPlayer
    {
        private Random r = new Random();

        protected Placement RandomMove(Game gamestate)
        {
            int i = r.Next(3);
            int j = r.Next(3);

            Placement p = new Placement(i, j);
            while (!gamestate.IsLegalMove(p))
            {
                p.X = r.Next(3);
                p.Y = r.Next(3);
            }
            return p;
        }

        public virtual Placement NextMove(Game gamestate)
        {
            return RandomMove(gamestate);
        }
    }

      /*class PoppeUnbeatableAI
  {
        enum Player : Int32
        {
        }

        private Func minimax(Board: Array<Player>, IPlayer: Player)  Int32{
            if let winner = .getWinner(Board) as IPlayer
    }*/
}
