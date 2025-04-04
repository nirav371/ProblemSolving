using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    internal class _334
    {

            public bool IncreasingTriplet(int[] nums)
            {
                int first = Int32.MaxValue;
                int second = Int32.MinValue;

                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] <= first)
                    {
                        first = nums[i];
                    }
                    else if (nums[i] <= second)
                    {
                        second = nums[i];
                    }
                    else
                    {
                        return true;
                    }
                }
                return false;
            }
        }

    }
    

