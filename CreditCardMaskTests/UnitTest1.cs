using CreditCardMask;
using NUnit.Framework;

namespace CreditCardMaskTests
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
            Assert.AreEqual("############5616", CreditCardMaskClass.Maskify("4556364607935616"));
            Assert.AreEqual("1", CreditCardMaskClass.Maskify("1"));
            Assert.AreEqual("#1111", CreditCardMaskClass.Maskify("11111"));
        }
        
        [Test]
        public void Test2()
        {
            Assert.AreEqual("############5616", CreditCardMaskClass.Maskify_("4556364607935616"));
            Assert.AreEqual("1", CreditCardMaskClass.Maskify_("1"));
            Assert.AreEqual("#1111", CreditCardMaskClass.Maskify_("11111"));
            Assert.AreEqual("", CreditCardMaskClass.Maskify_(""));
        }
    }
}