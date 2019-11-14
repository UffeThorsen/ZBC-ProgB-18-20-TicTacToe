using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe;

namespace TicTacToeUnitTest
{
    public class TestAI : IPlayer
    {
        public virtual Placement NextMove(Game gameState)
        {
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    Placement p = new Placement(i, j);
                    if (gameState.IsLegalMove(p))
                    {
                        return p;
                    }
                }
            }
            return new Placement();
        }
    }

    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void TestGameConstructor()
        {
            IPlayer p1 = new UffeAIPlayer();
            IPlayer p2 = new UffeAIPlayer();
            Game g = new Game(p1, p2);
        }

        [ExpectedException(typeof(ArgumentException), AllowDerivedTypes = true)]
        [TestMethod]
        public void TestGameConstructorWithNullPlayer()
        {
            IPlayer p1 = null;
            IPlayer p2 = null;
            Game g = new Game(p1, p2);
        }

        [ExpectedException(typeof(ArgumentException), AllowDerivedTypes = true)]
        [TestMethod]
        public void TestGameConstructorWithSamePlayerTwice()
        {
            IPlayer p1 = new TestAI();
            Game g = new Game(p1, p1);
        }
    }
}
