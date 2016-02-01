using System;
using DebugDemo.Library.Collatz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DebugDemo.Tests
{
    [TestClass]
    public class CollatzTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var instance = new CollatzCompute();
            var actual = instance.CalculateMaxCycles(new Input {Start = 113383, End = 10000000});
            Assert.AreEqual(686, actual.Value);
        }
    }
}
