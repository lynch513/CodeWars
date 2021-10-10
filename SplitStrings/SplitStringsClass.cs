using System;
using System.Collections.Generic;
using System.Linq;

namespace SplitStrings
{
    public class SplitStringsClass
    {
        public static bool IsEven(int num) =>
            num % 2 == 0;
        
        public static string[] Solution(string str)
        {
            if (string.IsNullOrEmpty(str))
                return Array.Empty<string>();
            var res = IsEven(str.Length) ? str : string.Concat(str, '_');
            return Enumerable
                .Range(0, res.Length / 2)
                .Select(i => res.Substring(i * 2, 2))
                .ToArray();
        }
    }
}