using System;
using System.Collections.Generic;

namespace DigitalRoot
{
    public static class DigitalRootClass
    {
        public static int DigitalRoot(long n)
        {
            n = Math.Abs(n);
            if (n <= 9)
                return (int)n;
            var lastDigit = (int) (n % 10);
            var headDigits = n / 10;
            var result = lastDigit + DigitalRoot(headDigits);
            return DigitalRoot(result);
        }
        
        public static int DigitalRoot_(long n)
        {
            return (int)(1 + (Math.Abs(n) - 1) % 9);
        }
    }
}