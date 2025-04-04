using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    internal class _1679
    {
        public int MaxOperations(int[] nums, int k)
        {

            // Dictionary to store frequency of numbers
            Dictionary<int, int> freq = new Dictionary<int, int>();
            int operationCount = 0;

            foreach (int num in nums)
            {
                int complement = k - num;

                // Check if the complement exists in the dictionary
                if (freq.ContainsKey(complement) && freq[complement] > 0)
                {
                    operationCount++;
                    freq[complement]--;
                }
                else
                {
                    // Add the current number to the dictionary
                    if (!freq.ContainsKey(num))
                    {
                        freq[num] = 0;
                    }
                    freq[num]++;
                }
            }

            return operationCount;
        }
    }

    //int right = 1;
    //List<int> numsList = nums.ToList();
    //int OperationCount = 0;
    //int numsListLength = numsList.Count;
    //while (numsListLength > 1)
    //{
    //    if (numsList[0] + numsList[right] == k)
    //    {
    //        numsList.RemoveAt(right);
    //        numsList.RemoveAt(0);
    //        OperationCount++;
    //        right = 1;
    //    }
    //    else
    //    {
    //        if (right < numsListLength - 1)
    //        {
    //            right++;
    //        }
    //        else
    //        {
    //            numsList.RemoveAt(0);
    //            right = 1;
    //        }
    //    }
    //    numsListLength = numsList.Count;
    //}
    //return OperationCount;
}

