using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    internal class _1431
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int HighestCandies = candies.Max();
            IList<bool> res = new List<bool>();
            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] + extraCandies >= HighestCandies)
                {
                    res.Add(true);
                }
                else
                {
                    res.Add(false);
                }
            }
            return res;
        }
    }
}
