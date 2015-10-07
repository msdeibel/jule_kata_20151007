using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jule_kata_20151007;

namespace jule_kata_20151007_tests
{
    [TestClass]
    public class MarkerStackTests
    {
        [TestMethod]
        public void NewPlayerMarkerStackIsEmpty()
        {
            MarkerStack playerMarkerStack = MarkerStack.PlayerMarkerStack();
            Assert.AreEqual(0, playerMarkerStack.Count());
        }

        [TestMethod]
        public void NewGameMarkerStackHas13Markers()
        {
            MarkerStack gameMarkerStack = MarkerStack.GameMarkerStack();
            Assert.AreEqual(13, gameMarkerStack.Count());
        }

        [TestMethod]
        public void AddingUpTo13MarkersToEmptyStackIsOk()
        {
            MarkerStack playerMarkerStack = MarkerStack.PlayerMarkerStack();

            playerMarkerStack.addMarkers(1);
            playerMarkerStack.addMarkers(4);
            playerMarkerStack.addMarkers(5);
            playerMarkerStack.addMarkers(3);

            Assert.AreEqual(13, playerMarkerStack.Count());
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void AddingMoreThan13MarkersThrowsException()
        {
            MarkerStack playerMarkerStack = MarkerStack.PlayerMarkerStack();

                playerMarkerStack.addMarkers(13);
                playerMarkerStack.addMarkers(1);
        }

        [TestMethod]
        public void AddingMoreThan13MarkersDoesNotChangeTheCounter()
        {
            MarkerStack playerMarkerStack = MarkerStack.PlayerMarkerStack();
            try
            {
                playerMarkerStack.addMarkers(13);
                playerMarkerStack.addMarkers(1);
            }
            catch (ArgumentOutOfRangeException exArg)
            {
                Assert.AreEqual(13, playerMarkerStack.Count());
            }
        }

        [TestMethod]
        public void RemovingUpTo13MarkersFromAFullStackIsOk()
        {
            MarkerStack gameMarkerStack = MarkerStack.GameMarkerStack();

            gameMarkerStack.removeMarkers(1);
            gameMarkerStack.removeMarkers(4);
            gameMarkerStack.removeMarkers(5);
            gameMarkerStack.removeMarkers(3);

            Assert.AreEqual(0, gameMarkerStack.Count());
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void RemovingMoreThan13MarkersThrowsException()
        {
            MarkerStack markerStack = MarkerStack.GameMarkerStack();

            markerStack.removeMarkers(13);
            markerStack.removeMarkers(1);
        }

        [TestMethod]
        public void RemovingMoreThan13MarkersDoesNotChangeTheCounter()
        {
            MarkerStack markerStack = MarkerStack.GameMarkerStack();

            try
            {
                markerStack.removeMarkers(13);
                markerStack.removeMarkers(1);
            }
            catch(ArgumentOutOfRangeException exArg)
            {
                Assert.AreEqual(0, markerStack.Count());
            }
        }
    }
}
