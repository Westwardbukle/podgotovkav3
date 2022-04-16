using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services;
using System;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Корней нет", Square.Calculate(15, 5, 3));
        }
    }
}
