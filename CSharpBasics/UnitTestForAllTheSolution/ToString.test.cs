using NUnit.Framework;
using System.Collections.Generic;
using ToStringForAnArray;

namespace Tests
{
    public class ToString
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IntegerList integerList = new IntegerList();
            string actualValue = integerList.ToString();
            string expectedValue = "1,2,3,4,5";
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}