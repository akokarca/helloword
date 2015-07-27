using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWord;

namespace HelloWordTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("HelloWord", Program.CreateMessage());
        }
    }
}
