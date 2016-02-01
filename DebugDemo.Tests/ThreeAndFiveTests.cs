using System;
using DebugDemo.Library.Collatz;
using DebugDemo.Library.ThreeAndFive;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DebugDemo.Tests
{
    [TestClass]
    public class ThreeAndFiveTests
    {

        /*
        If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Find the sum of all the multiples of 3 or 5 below 1000.
            
            */


        [TestMethod]
        public void Test1to10()
        {
            var instance = new ThreeAndFive();
            var actual = instance.FindSum(new Input {Start = 1, End = 10});
            Assert.AreEqual(23,actual.Value);
        }

        [TestMethod]
        public void Test1to1000()
        {
            var instance = new ThreeAndFive();
            var actual = instance.FindSum(new Input { Start = 1, End = 1000 });
            Assert.AreEqual(233168, actual.Value);
        }
    }
}
