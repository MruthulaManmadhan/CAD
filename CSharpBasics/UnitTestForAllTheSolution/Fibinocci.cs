using NUnit.Framework;
using System.Collections.Generic;
using ForLoop;

namespace Tests
{
    public class Fibinocci
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            List<int> Fib = new List<int>() { 1,1 };
            List<int> actualValue = Program.Fibinoccci(1,1,5,Fib);
            List<int> expectedValue = new List<int>() {1,1,2,3,5,8,13};
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}