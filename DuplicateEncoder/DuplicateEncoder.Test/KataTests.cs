using DuplicateEncoder.Code;
using NUnit.Framework;

namespace DuplicateEncoder.Test
{
    [TestFixture]
    public class KataTests
    {
        private Kata _kata;

        [SetUp]
        public void SetUp()
        {
            _kata = new Kata();
        }
        [Test]
        public void Test1()
        {
            Assert.AreEqual("(((", _kata.DuplicateEncode("din"));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual("()()()", _kata.DuplicateEncode("recede"));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(")())())", _kata.DuplicateEncode("Success"), "should ignore case");
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual("))((", _kata.DuplicateEncode("(( @"));
        }
    }
}