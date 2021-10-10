using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace DirectionReduction
{
    public class DirectionReductionClass
    {
        private static (string, string)[] Opposite = {("NORTH", "SOUTH"), ("EAST", "WEST")};
        
        private static bool IsOpposite(string a, string b) =>
            Opposite.Contains((a, b)) || Opposite.Contains((b, a));

        public static string[] dirReduc(string[] arr) =>
            arr.Aggregate(
                new List<string>(),
                (buf, i) => IsOpposite(i, buf.LastOrDefault()) ? buf.SkipLast(1).ToList() : buf.Append(i).ToList()
            ).ToArray();
    }
}