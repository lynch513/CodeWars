using System;
using System.Linq;

namespace DisemVowelTrolls
{
    public class DisemVowel
    {
        public static string Disemvowel(string str) =>
            new (str.Where(ch => !"aeiou".Contains(Char.ToLower(ch))).ToArray());
        
        public static string Disemvowel_(string str) =>
            string.Concat(str.Where(ch => !"aeiou".Contains(Char.ToLower(ch))).ToArray());
    }
}