using System;

namespace TicTacToe
{
    class UffeAIPlayer : IPlayer
    {
        public virtual string Description {
            get {
                return "Uffes random AI";
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

    class UffeSmarterAIPlayer : UffeAIPlayer
    {
        public override string Description {
            get {
                return "Uffes single look-ahead AI";
            }
        }

        int iLength = 3; int jLength = 3;

        private bool IsWinningPlacement(Game g, Symbol s, int i, int j, int di, int dj)
        {
            if(g[i,j] != Symbol.N) { return false; }//Not empty
            if(i + 2*di >= iLength){ return false; }//i too high
            if(j+ 2*dj >= jLength) { return false; }//j too high
            if(i + 2*di < 0) { return false; }//i too low
            if(j + 2*dj < 0) { return false; }//j too low

            if(g[i+di, j+dj] == s && g[i+2*di, j+2*dj] == s)
            {
                return true;
            }

            return false;
        }
        private bool IsWinningPlacement(Game g, Symbol s, Placement p)
        {
            if(IsWinningPlacement(g, s, p.X, p.Y, 0, 1)) { return true; }//horizontal
            if (IsWinningPlacement(g, s, p.X, p.Y, 1, 0)) { return true; }//vertical
            if (IsWinningPlacement(g, s, p.X, p.Y, 1, 1)) { return true; }//diagonal
            if (IsWinningPlacement(g, s, p.X, p.Y, -1, 1)) { return true; }//other diagonal
            return false;
        }

        private bool WinningMove(Game gameState, Symbol symbol, out Placement p)
        {
            for (int i = 0; i < iLength; i++)
            {
                for(int j = 0; j < jLength; j++)
                {
                    p = new Placement(i, j);
                    if (IsWinningPlacement(gameState, symbol, p))
                    {
                        return true;
                    }
                }
            }
            p = new Placement();
            return false;
        }
        private bool WinningMove(Game gameState, out Placement p)
        {
            return WinningMove(gameState, gameState.CurrentPlayer, out p);
        }
        private bool PreventiveMove(Game gameState, out Placement p)
        {
            Symbol otherSymbol;
            if(gameState.CurrentPlayer == Symbol.X)
            {
                otherSymbol = Symbol.O;
            }
            else
            {
                otherSymbol = Symbol.X;
            }
            return WinningMove(gameState, otherSymbol, out p);
        }

        public new Placement NextMove(Game gameState)
        {
            //Can I win?
            Placement p;
            if (WinningMove(gameState, out p))
            {
                return p;
            }
            //Can  I prevent you from winning?
            if (PreventiveMove(gameState, out p))
            {
                return p;
            }
            //Otherwise random
            return RandomMove(gameState);
        }
    }
}
