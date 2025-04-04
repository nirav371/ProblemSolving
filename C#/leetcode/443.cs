using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    internal class _443
    {
        public int Compress(char[] chars)
        {
            var i = 0;
            var j = 0;

            while (i < chars.Length)
            {
                var current = chars[i];
                var counter = 0;

                while (i < chars.Length && chars[i] == current)
                {
                    i++;
                    counter++;
                }

                chars[j++] = current;

                if (counter > 1)
                {
                    foreach (var counterChar in counter.ToString())
                    {
                        chars[j++] = counterChar;
                    }
                }
            }

            return j;
        }
    }
}
