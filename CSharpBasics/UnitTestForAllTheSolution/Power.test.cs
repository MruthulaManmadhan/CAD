using NUnit.Framework;
using System.Collections.Generic;
using Power;
namespace Tests
{
    public class Power
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int actualValue = Program.Power(10,3);
            int expectedValue = 1000;
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}