using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jule_kata_20151007;

namespace jule_kata_20151007_tests
{
    [TestClass]
    public class PlayerTests
    {
        Player player;

        [TestInitialize]
        public void Initialize()
        {
            player = new Player();
        }

        [TestMethod]
        public void NewPlayerHasAnEmptyMarkerStack()
        {
            Assert.AreEqual(0, player.MarkerCount());
        }

        [TestMethod]
        public void PlayerCanReceiveMarkers()
        {
            player.receiveMarkers(5);

            Assert.AreEqual(5, player.MarkerCount());
        }

        [TestMethod]
        public void PlayerCanReturnMarkers()
        {
            player.receiveMarkers(5);
            player.returnMarkers(3);

            Assert.AreEqual(2, player.MarkerCount());
        }
    }
}
