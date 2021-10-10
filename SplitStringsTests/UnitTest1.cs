using NUnit.Framework;
using SplitStrings;

namespace SplitStringsTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new [] { "ab", "c_" }, "abc")]
        [TestCase(new [] { "ab", "cd", "ef" }, "abcdef")]
        [TestCase(new string[0], "")]
        [TestCase(new string[0], null)]
        public void Test1(string[] expected, string input)
        {
            Assert.AreEqual(expected, SplitStringsClass.Solution(input));
        }
    }
}