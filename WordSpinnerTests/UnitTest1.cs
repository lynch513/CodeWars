using NUnit.Framework;
using WordSpinner;

namespace WordSpinnerTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public static void Test1()
        {
            Assert.AreEqual("emocleW", WordSpinnerClass.SpinWords("Welcome"));
        }
  
        [Test]
        public static void Test2()
        {  
            Assert.AreEqual("Hey wollef sroirraw", WordSpinnerClass.SpinWords("Hey fellow warriors"));
        }
  
        [Test]
        public static void Test3()
        {
            Assert.AreEqual("This is a test", WordSpinnerClass.SpinWords("This is a test"));
        }
  
        [Test]
        public static void Test4()
        {
            Assert.AreEqual("This is rehtona test", WordSpinnerClass.SpinWords("This is another test"));
        }
  
        [Test]
        public static void Test5()
        {
            Assert.AreEqual("You are tsomla to the last test", WordSpinnerClass.SpinWords("You are almost to the last test"));
        }
  
        [Test]
        public static void Test6()
        {
            Assert.AreEqual("Just gniddik ereht is llits one more", WordSpinnerClass.SpinWords("Just kidding there is still one more"));
        }
    }
}