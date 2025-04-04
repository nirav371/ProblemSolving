using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    internal class _643
    {
        public class Solution
        {
            public double FindMaxAverage(int[] nums, int k)
            {
                double sum = 0;
                for (int i = 0; i < k; i++)
                {
                    sum += nums[i];
                }
                double max = sum;
                for (int i = k; i < nums.Length; i++)
                {
                    sum += nums[i] - nums[i - k];
                    max = Math.Max(max, sum);
                }
                return max / k;
            }
        }
    }
}
