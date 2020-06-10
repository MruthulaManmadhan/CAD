using NUnit.Framework;
using System.Collections.Generic;
using SquareRoot;
namespace Tests
{
    public class SquareRoot
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            double actualValue = Program.GetSquareRoot(1,100,100);
            double expectedValue = 10;
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}