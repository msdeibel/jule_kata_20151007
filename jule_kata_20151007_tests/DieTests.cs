using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jule_kata_20151007;

namespace jule_kata_20151007_tests
{
    [TestClass]
    public class DieTests
    {
        [TestMethod]
        public void DieRollHasSufficientProbabilityToAlwaysBeBetween1And6()
        {
            SixSidedDie die = new SixSidedDie();

            for (int i = 0; i < 10000; i++)
            {
                Assert.IsTrue(die.Roll() >= 1 && die.Roll() <= 6);
            }
        }
    }
}
