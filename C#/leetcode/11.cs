using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    internal class _11
    {
        public int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int MaxArea = 0;

            while (left < right)
            {
                MaxArea = Math.Max(MaxArea, (right - left) * (Math.Min(height[left], height[right + 1])));

                if (height[left] > height[right])
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
            return MaxArea;
        }
    }
}
