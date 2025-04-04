using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    internal class _238
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] preffix = new int[nums.Length];
            int[] suffix = new int[nums.Length];
            
            Array.Fill(preffix, 1);
            Array.Fill(suffix, 1);

            for(int i = 1; i < nums.Length; i++)
            {
                preffix[i] = preffix[i - 1] * nums[i - 1];
            }
            for(int i = nums.Length - 2; i >= 0; i--)
            {
                suffix[i] = suffix[i + 1] * nums[i + 1];
            }
            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = preffix[i] * suffix[i];
            }
            return nums;
           
        }
    }
}
