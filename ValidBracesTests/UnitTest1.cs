using NUnit.Framework;
using ValidBraces;

namespace ValidBracesTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("()", true)]
        [TestCase("[(])", false)]
        [TestCase("][()", false)]
        [TestCase("(})", false)]
        [TestCase("(){}[]", true)]
        [TestCase("([{}])", true)]
        [TestCase("(}", false)]
        [TestCase("[(])", false)]
        [TestCase("[({})](]", false)]
        [TestCase("[({})]()", true)]
        [TestCase("(", false)]
        [TestCase("}", false)]
        [TestCase("]]", false)]
        [TestCase("[[]]", true)]
        public void Test_1(string braces, bool expected) 
        {
            Assert.AreEqual(expected, ValidBracesClass.ValidBraces(braces));
        }
    }
}