using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlternatingCharacters;

namespace AlternatingCharactersTests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(3, Program.Process("AAAA"));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(4, Program.Process("BBBBB"));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(0, Program.Process("ABABABAB"));
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(0, Program.Process("BABABA"));
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(4, Program.Process("AAABBB"));
        }

    }
}
