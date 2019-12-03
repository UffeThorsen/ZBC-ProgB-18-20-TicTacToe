using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class KasperAI : IPlayer
    {
        public virtual string Description
        {
            get
            {
                return "Kaspers AI";
            }
        }

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

        public override string ToString()
        {
            return Description;
        }
    }
}
