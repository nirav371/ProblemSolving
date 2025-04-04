using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    internal class _151
    {
        public string ReverseWords(string s)
        {
            List<string> words = new List<string>(s.Split(" ", StringSplitOptions.RemoveEmptyEntries).Reverse()); 
            return string.Join(" ", words);
        }
    }
}
