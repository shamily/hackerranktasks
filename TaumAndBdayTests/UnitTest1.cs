using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaumAndBday;

namespace TaumAndBdayTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TaumAndBdayTests()
        {
            Assert.AreEqual(20, Program.Process(10, 10, 1, 1, 1));
            Assert.AreEqual(37, Program.Process(5, 9, 2, 3, 4));
            Assert.AreEqual(12, Program.Process(3, 6, 9, 1, 1));
            Assert.AreEqual(35, Program.Process(7, 7, 4, 2, 1));
            Assert.AreEqual(12, Program.Process(3, 3, 1, 9, 2));
        }

        [TestMethod]
        public void TaumAndBdayLongTests()
        {
            Program.Process(10000000000, 10000000000, 10000000000, 10000000000, 10000000000);
        }
    }
}
