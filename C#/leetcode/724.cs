using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    internal class _724
    {
        public int PivotIndex(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += nums[j];
                }
                for (int j = i + 1; j < nums.Length; j++)
                {
                    rightSum += nums[j];
                }
                if (leftSum == rightSum)
                {
                    return i;
                }
            }
            return -1;

            //int[] leftSum = new int[nums.Length];
            //int[] rightSum = new int[nums.Length];
            //leftSum[0] = 0;
            //rightSum[nums.Length - 1] = 0;
            //for (int i = 1; i < nums.Length; i++)
            //{
            //    leftSum[i] = leftSum[i - 1] + nums[i - 1];
            //}
            //for (int i = nums.Length - 2; i >= 0; i--)
            //{
            //    rightSum[i] = rightSum[i + 1] + nums[i + 1];
            //}
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (leftSum[i] == rightSum[i])
            //    {
            //        return i;
            //    }
            //}
            //return -1;

        }
    }
}
