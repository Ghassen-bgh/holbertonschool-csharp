using NUnit.Framework;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(4, 6)]
        [TestCase(3, 7)]
        [TestCase(5, 5)]
        [TestCase(10, 0)]
        [TestCase(20, -10)]

        public void Add(int a, int b)
        {
            int sum = MyMath.Operations.Add(a, b);
            Assert.AreEqual(a + b, sum);
        }
    }
}