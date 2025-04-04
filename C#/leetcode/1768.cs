using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    internal class _1768
    {
        public string MergeAlternately(string word1, string word2)
        {
             StringBuilder res = new StringBuilder();
            int MinLength = Math.Min(word1.Length, word2.Length);
            for (int i = 0; i < MinLength; i++)
            {
                res.Append(word1[i]);
                res.Append(word2[i]);

            }
            res.Append(word1.Substring(MinLength));
            res.Append(word2.Substring(MinLength));

            return res.ToString();
        }
    }
}

