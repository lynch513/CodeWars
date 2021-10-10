using System;

namespace IsPrimeNumber
{
    public class IsPrimeNumberClass
    {
        public static bool IsPrime(int num)
        {
            var max = Math.Sqrt(num);
            for (var i = 2; i <= max; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return num > 1;
        }
    }
}