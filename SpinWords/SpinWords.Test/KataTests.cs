using NUnit.Framework;
using SpinWords.Code;

namespace SpinWords.Test
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
            Assert.AreEqual("emocleW", _kata.SpinWords("Welcome"));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual("Hey wollef sroirraw", _kata.SpinWords("Hey fellow warriors"));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual("This is a test", _kata.SpinWords("This is a test"));
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual("This is rehtona test", _kata.SpinWords("This is another test"));
        }

        [Test]
        public void Test5()
        {
            Assert.AreEqual("You are tsomla to the last test", _kata.SpinWords("You are almost to the last test"));
        }

        [Test]
        public void Test6()
        {
            Assert.AreEqual("Just gniddik ereht is llits one more", _kata.SpinWords("Just kidding there is still one more"));
        }
    }
}