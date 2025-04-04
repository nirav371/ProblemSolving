using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    public class _392
    {
        public bool IsSubsequence(string s, string t)
        {
            if (s.Length > t.Length)
            {
                return false;
            }
            int sPointer = 0;

            for (int i = 0; i < t.Length; i++)
            {
                if (s[sPointer] == t[i])
                {
                    sPointer++;
                    if (sPointer == s.Length)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
