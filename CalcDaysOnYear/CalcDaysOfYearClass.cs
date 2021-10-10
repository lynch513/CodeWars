using System;
using FluentDate;

namespace CalcDaysOnYear
{
    public class CalcDaysOfYearClass
    {
        public static DateTime CalcDays()
        {
            return new DateTime(2021, 1, 1) + 255.Days();
        }
    }
}