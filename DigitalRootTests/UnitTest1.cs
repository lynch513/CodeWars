using DigitalRoot;
using NUnit.Framework;

namespace DigitalRootTests
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
            Assert.AreEqual(7, DigitalRootClass.DigitalRoot(16));
            Assert.AreEqual(7, DigitalRootClass.DigitalRoot(-16));
            Assert.AreEqual(1, DigitalRootClass.DigitalRoot(19));
            Assert.AreEqual(6, DigitalRootClass.DigitalRoot(456));
            Assert.AreEqual(6, DigitalRootClass.DigitalRoot(942));
            Assert.AreEqual(6, DigitalRootClass.DigitalRoot(132189));
            Assert.AreEqual(2, DigitalRootClass.DigitalRoot(493193));
        }
        
        [Test]
        public void Test2()
        {
            Assert.AreEqual(7, DigitalRootClass.DigitalRoot_(16));
            Assert.AreEqual(7, DigitalRootClass.DigitalRoot_(-16));
            Assert.AreEqual(1, DigitalRootClass.DigitalRoot_(19));
            Assert.AreEqual(6, DigitalRootClass.DigitalRoot_(456));
            Assert.AreEqual(6, DigitalRootClass.DigitalRoot_(942));
            Assert.AreEqual(6, DigitalRootClass.DigitalRoot_(132189));
            Assert.AreEqual(2, DigitalRootClass.DigitalRoot_(493193));
        }
    }
}