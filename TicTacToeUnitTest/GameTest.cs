using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe;

namespace TicTacToeUnitTest
{
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
    }
}
