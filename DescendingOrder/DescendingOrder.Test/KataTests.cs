using DescendingOrder.Code;
using NUnit.Framework;

namespace DescendingOrder.Test
{
    public class Tests
    {
        private Kata _kata;

        [SetUp]
        public void Setup()
        {
            _kata = new Kata();
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(54421, _kata.DescendingOrder(42145));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(654321, _kata.DescendingOrder(145263));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(987654321, _kata.DescendingOrder(123456789));
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(2110, _kata.DescendingOrder(1012));
        }
    }
}