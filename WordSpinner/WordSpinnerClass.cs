using System;
using System.Linq;

namespace WordSpinner
{
    public static class WordSpinnerClass
    {
        public static string SpinWords(string sentence) =>
            string.Join(' ', sentence
                    .Split(null)
                    .Select(word => word.Length >= 5 ? string.Concat(word.Reverse()) : word));
    }
}