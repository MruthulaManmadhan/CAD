using NUnit.Framework;
using System.Collections.Generic;
using ReverseArray;
namespace Tests
{
    public class ReverseArray
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int[] array = new int[] {1,2,3,4,5,6,7 };
            int[] actualValue = Program.Reverse(array,7);
            int[] expectedValue = new int[] { 7,6,5,4,3,2,1 };
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}