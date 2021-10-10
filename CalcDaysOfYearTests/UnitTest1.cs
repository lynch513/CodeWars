using System;
using CalcDaysOnYear;
using FluentAssertions;
using FluentAssertions.Extensions;
using NUnit.Framework;

namespace CalcDaysOfYearTests
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
            var result = CalcDaysOfYearClass.CalcDays();
            result.Should().Be(1.January(2021) + 255.Days());
        }

        [Test]
        public void Test_DevDay() =>
            13.September(2021)                                                       
                .Should()                                                               
                .Be(1.January(2021) + 255.Days());                                  
    }
}