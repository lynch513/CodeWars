using NUnit.Framework;
using static DirectionReduction.DirectionReductionClass;

namespace DirectionReductionTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new string[0], new string[0])]
        [TestCase(new[] {"NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST"}, new[] {"WEST"})]
        [TestCase(new[] {"NORTH", "WEST", "SOUTH", "EAST"}, new[] {"NORTH", "WEST", "SOUTH", "EAST"})]
        public void Test2(string[] arr, string[] expected)
        {
            Assert.AreEqual(expected, dirReduc(arr));
        }
    }
}