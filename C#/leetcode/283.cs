using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    internal class _283
    {
        public int[] MoveZeroes(int[] nums)
        {
            int zeroCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    zeroCount++;
                }
                else
                {
                    if (zeroCount > 0)
                    {
                        nums[i - zeroCount] = nums[i];
                        nums[i] = 0;
                    }
                }
            }
            return nums;
        }
    }
}
