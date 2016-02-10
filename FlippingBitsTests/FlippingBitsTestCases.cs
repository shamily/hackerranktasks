using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution;

namespace FlippingBitsTests
{
    [TestClass]
    public class FlippingBitsTestCases
    {
        [TestMethod]
        public void ReturnPositive()
        {
            Assert.AreEqual(4294967294, Solution.Solution.Process(1));
            Assert.AreEqual(2147483648, Solution.Solution.Process(2147483647));
            Assert.AreEqual(4294967295, Solution.Solution.Process(0));
        }
    }
}
