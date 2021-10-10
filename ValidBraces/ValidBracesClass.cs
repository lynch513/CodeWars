using System;
using System.Collections.Generic;
using System.Linq;

namespace ValidBraces
{
    public class ValidBracesClass
    {
        private static (char, char)[] Braces =
        {
            ('(', ')'),
            ('{', '}'),
            ('[', ']')
        };

        private static bool IsOpenBrace(char ch) =>
            Braces.Select(t => t.Item1).Contains(ch);

        private static bool CheckPairBrace(char ch1, char ch2) =>
            Braces.FirstOrDefault(t => t.Item1 == ch1).Item2 == ch2;
    
        public static bool ValidBraces(string braces)
        {
            Stack<char> stack = new();
            foreach (var ch in braces)
            {
                if (IsOpenBrace(ch))
                    stack.Push(ch);
                else if (stack.Count == 0)
                    stack.Push(ch);
                else if (CheckPairBrace(stack.Peek(), ch))
                    stack.Pop();
                else
                    stack.Push(ch);
            }
            return stack.Count == 0;
        }
    }
}