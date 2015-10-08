using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jule_kata_20151007;

namespace jule_kata_20151007_tests
{
    [TestClass]
    public class RollResultTests
    {
        [TestMethod]
        public void RollResultCorrectlyAssignesInputs()
        {
            RollResult rr = new RollResult(1, 2, 3);

            Assert.AreEqual(1, rr.Die1());
            Assert.AreEqual(2, rr.Die2());
            Assert.AreEqual(3, rr.Die3());
        }
    }
}
