using NUnit.Framework;

namespace MyMath.Tests
{
    public class Tests
    {


        [Test]
        [TestCase(4, 6)]
        [TestCase(3, 7)]
        [TestCase(5, 5)]
        [TestCase(10, 0)]
        [TestCase(0, 0)]
        [TestCase(0, 10)]
        [TestCase(-10, 20)]
        [TestCase(20, -10)]

        public void Addition(int a, int b)
        {
            var sum = MyMath.Operations.Add(a, b);
            Assert.AreEqual(10, sum);
        }
    }
}