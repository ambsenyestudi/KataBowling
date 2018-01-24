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
        public void GivenTwentyRollsPair9MissScoreShouldBe150 ()
        {
            _game.Rolls = "9-9-9-9-9-9-9-9-9-9-";
            int extpected = 150;
            Assert.IsTrue(_game.Score == extpected);
        }
    }
}
