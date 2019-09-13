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

        private bool InsideBound(int i, int length)
        {
            return i >= 0 && i < length;
        }
        private bool IsGood(Game g, Symbol s, int iNew, int jNew)
        {
            return InsideBound(iNew, iLength) && InsideBound(jNew, jLength) && g[iNew, jNew] == s;
        }

        //2 out of 3 should be s, the remaining should be N
        private bool IsWinningPlacement(Game g, Symbol s, int i, int j, int di, int dj)
        {
            if(g[i,j] != Symbol.N) { return false; }//Not empty
            int count = 0;
            foreach(int d in new int[]{ -2, -1, 1, 2}){
                if(IsGood(g, s, i + d*di, j+d*dj)) { count++; }
            }
            //If two either before or after (i,j) is good, then all is good
            return count == 2;
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
            p = new Placement(-1, -1);
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

        public override Placement NextMove(Game gameState)
        {
            //Can I win?
            Placement p;
            if (WinningMove(gameState, out p))
            {
                if (gameState.IsLegalMove(p))
                {
                    return p;
                }
            }
            //Can  I prevent you from winning?
            if (PreventiveMove(gameState, out p))
            {
                if (gameState.IsLegalMove(p))
                {
                    return p;
                }
            }
            //Otherwise random
            return RandomMove(gameState);
        }
    }
}
