using System;
using System.Linq;

namespace CreditCardMask
{
    public static class CreditCardMaskClass
    {
        public static string Maskify(string cc)
        {
            var len = cc.Length;
            var headCount = len > 4 ? len - 4 : 0;
            var trailCount = len - headCount;
            var mask = new string('#', headCount);
            var trailCc = string.Concat(cc.TakeLast(trailCount));
            return string.Concat(mask, trailCc);
        }
        
        public static string Maskify_(string cc)
        {
            return string.Concat(cc.Select((ch, i) => i >= cc.Length - 4 ? ch : '#'));
        }
    }
}