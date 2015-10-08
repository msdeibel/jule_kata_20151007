using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jule_kata_20151007;

namespace jule_kata_20151007_tests
{
    [TestClass]
    public class GameMasterTests
    {
        private GameMaster master;

        [TestInitialize]
        public void Initialize()
        {
            master = new GameMaster();
        }

        [TestMethod]
        public void GameMasterStartsWith13Markers()
        {
            Assert.AreEqual(13, master.MarkerCount());
        }

        [TestMethod]
        public void GameMasterStartsWithoutKnowingAnyPlayers()
        {
            Assert.AreEqual(0, master.PlayerCount());
        }

        [TestMethod]
        public void GameMasterCanRegisterPlayers()
        {
            master.RegisterPlayer();

            Assert.AreEqual(1, master.PlayerCount());
        }

        [TestMethod]
        public void GameMasterCanDeregisterPlayers()
        {
            master.RegisterPlayer();
            master.DeregisterPlayer(1);

            Assert.AreEqual(0, master.PlayerCount());
        }

        [TestMethod]
        public void DiceRollWorksWithoutPreviousResult()
        {
            RollResult rr = master.RollDice(true, true, true, null);

            Assert.IsTrue(1 <= rr.Die1() && 6 >= rr.Die1());
            Assert.IsTrue(1 <= rr.Die2() && 6 >= rr.Die2());
            Assert.IsTrue(1 <= rr.Die3() && 6 >= rr.Die3());
        }

        [TestMethod]
        public void DiceRollKeepsPreviousDie2Result()
        {
            RollResult previousResult = new RollResult(4, 7, 4);

            RollResult currentResult = master.RollDice(true, false, true, previousResult);

            Assert.AreEqual(7, currentResult.Die2());
        }

        [TestMethod]
        public void DiceRollDoesNotKeepPreviousResultOfZero()
        {
            RollResult previousResult = new RollResult(4, 0, 4);

            RollResult currentResult = master.RollDice(true, false, true, previousResult);

            Assert.AreNotEqual(0, currentResult.Die2());
        }

    }
}
