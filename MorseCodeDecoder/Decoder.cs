using System;
using System.Linq;
using System.Text;

namespace MorseCodeDecoder
{
    public static class Decoder
    {
        public static string Decode(string morseCode)
        {
            var words = morseCode.Split(new[] {"   "}, StringSplitOptions.RemoveEmptyEntries);
            var result = new StringBuilder();
            
            foreach (var word in words)
            {
                var letters = word.Split(' ');
                foreach (var letter in letters)
                {
                    result.Append(MorseCode.Get(letter));
                }
                result.Append(' ');
            }
            return result.ToString().Trim();
        }

        public static string Decode_(string morseCode)
        {
            var words = morseCode.Split(new[] {"   "}, StringSplitOptions.None);
            var translatedWords = words
                .Select(word => word.Split(' '))
                .Select(letters => string.Join("", letters.Select(MorseCode.Get)))
                .ToList();
            return string.Join(" ", translatedWords);
        }
    }
}