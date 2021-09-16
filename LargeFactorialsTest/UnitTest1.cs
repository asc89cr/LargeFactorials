using System;
using NUnit.Framework;
using LargeFactorials;

namespace LargeFactorialsTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual("1", Program.Factorial(1));
            Assert.AreEqual("120", Program.Factorial(5));
            Assert.AreEqual("362880", Program.Factorial(9));
            Assert.AreEqual("1307674368000", Program.Factorial(15));
        }
    }
}