using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.StringLib
{
   public static class StringExtention
    {
        public static string MyReverse(this string phrase)
        {
            if(string.IsNullOrEmpty(phrase))
            {
                throw new ArgumentNullException(nameof(phrase));
            }
           return string.Join(" ", phrase.Split(' ').Select(x => new string(x.Reverse().ToArray())));
        }
    }

    public class ReverseString
    {
        public string GetReverseString(string phrase)
        {
           return phrase.MyReverse();
        }
    }
}
