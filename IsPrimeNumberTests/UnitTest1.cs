using System.Collections.Generic;
using IsPrimeNumber;
using NUnit.Framework;

namespace IsPrimeNumberTests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        private static IEnumerable<TestCaseData> PrimeNumsCases
        {
            get
            {
                yield return new TestCaseData(0).Returns(false);
                yield return new TestCaseData(1).Returns(false);
                yield return new TestCaseData(2).Returns(true);
                yield return new TestCaseData(3).Returns(true);
                yield return new TestCaseData(4).Returns(false);
                yield return new TestCaseData(5).Returns(true);
                yield return new TestCaseData(6).Returns(false);
                yield return new TestCaseData(7).Returns(true);
                yield return new TestCaseData(8).Returns(false);
                yield return new TestCaseData(9).Returns(false);
                yield return new TestCaseData(10).Returns(false);
                yield return new TestCaseData(11).Returns(true);
                yield return new TestCaseData(12).Returns(false);
                yield return new TestCaseData(13).Returns(true);
                yield return new TestCaseData(14).Returns(false);
                yield return new TestCaseData(15).Returns(false);
                yield return new TestCaseData(16).Returns(false);
                yield return new TestCaseData(17).Returns(true);
            }
        }
        
        [Test, TestCaseSource(nameof(PrimeNumsCases))]
        public bool Test1(int num) =>
            IsPrimeNumberClass.IsPrime(num);
    }
}