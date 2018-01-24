using System;
using BowlingKata.Bowling;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingKataUT
{
    [TestClass]
    public class GameUT
    {
        Game _game = null;
        [TestInitialize]
        public void InitGame()
        {
            _game = new Game();
            
        }
        [TestMethod]
        public void GivenTwelveStrikesScoreShouldBe300()
        {
            _game.Rolls = "XXXXXXXXXXXX";
            int extpected = 300;
            Assert.IsTrue(_game.Score == extpected);
        }
        [TestMethod]
        public void GivenTwentyRollsPair9MissScoreShouldBe90 ()
        {
            _game.Rolls = "9-9-9-9-9-9-9-9-9-9-";
            int extpected = 90;
            Assert.IsTrue(_game.Score == extpected);
        }
        [TestMethod]
        public void GivenTwentyRollsPair1Miss9MissScoreShouldBe50()
        {
            _game.Rolls = "1-9-1-9-1-9-1-9-1-9-";
            int extpected = 50;
            Assert.IsTrue(_game.Score == extpected);
        }
        [TestMethod]
        public void GivenTwentyOneRollsPair5spareScoreShouldBe150()
        {
            _game.Rolls = "5/5/5/5/5/5/5/5/5/5/5";
            int extpected = 150;
            Assert.IsTrue(_game.Score == extpected);
        }
        [TestMethod]
        public void GivenTwentyRollsPaSpare1MissShouldBe55()
        {
            _game.Rolls = "5/1-5/1-5/1-5/1-5/1-";
            int extpected = 55;
            Assert.IsTrue(_game.Score == extpected);
        }
    }
}
