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
            Assert.AreEqual(10, Solution.Solution.Process(10));
        }
}
}
