using System;
using System.Linq;
using System.Text;

namespace ReplaceWithAlphabetPosition
{
    public static class Kata
    {
        public static string AlphabetPosition(string text)
        {
            var sb = new StringBuilder();
            foreach (char ch in text.ToLower())
            {
                var i = ch - 96;
                if (i is > 0 and < 27)
                    sb.Append($"{i} ");
            }
            return sb.ToString().TrimEnd();
        }
        
        public static string AlphabetPosition_(string text)
        {
            return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a'+1));
        }
    }
}