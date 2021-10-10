using DisemVowelTrolls;
using NUnit.Framework;

namespace DisemVowelTrollsTests
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
            Assert.AreEqual("Ths wbst s fr lsrs LL!", DisemVowel.Disemvowel("This website is for losers LOL!"));
        }
        
        [Test]
        public void Test2()
        {
            Assert.AreEqual("Ths wbst s fr lsrs LL!", DisemVowel.Disemvowel_("This website is for losers LOL!"));
        }
    }
}