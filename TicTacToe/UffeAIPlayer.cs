using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class UffeAIPlayer : IPlayer
    {
        private Random r = new Random();

        protected Placement RandomMove(Game gameState)
        {
            int i = r.Next(3);
            int j = r.Next(3);
            Placement p = new Placement(i, j);
            while (!gameState.IsLegalMove(p))
            {
                p.X = r.Next(3);
                p.Y = r.Next(3);
            }
            return p;
        }

        //Randomly selects a legal position
        public virtual Placement NextMove(Game gameState)
        {
            return RandomMove(gameState);
        }
    }

    class UffeSmarterAIPlayer : UffeAIPlayer
    {
        private bool WinningMove(Game gameState, out Placement p)
        {
            throw new NotImplementedException();
        }

        private bool PreventiveMove(Game gameState, out Placement p)
        {
            throw new NotImplementedException();
        }

        public override Placement NextMove(Game gameState)
        {
            //Can I win?
            Placement p;
            if(WinningMove(gameState, out p))
            {
                return p;
            }
            //Can  I prevent you from winning?
            if(PreventiveMove(gameState, out p))
            {
                return p;
            }
            //Otherwise random
            return RandomMove(gameState);
        }
    }
}
