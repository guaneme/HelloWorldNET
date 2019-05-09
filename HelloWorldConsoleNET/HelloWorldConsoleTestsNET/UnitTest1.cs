using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldConsoleTestsNET
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Assert.Inconclusive();
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(1, 1);
        }
    }
}
