using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode75_724
{
    public class Solution
    {
        //public int PivotIndex(int[] nums)
        //{
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (nums.Take(i).Sum() == nums.Skip(i + 1).Sum()) return i;
        //    }
        //    return -1;
        //}

        public int PivotIndex(int[] nums)
        {
            int totalSum = nums.Sum();
            int leftSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (leftSum == totalSum - leftSum - nums[i])
                    return i;

                leftSum += nums[i];
            }

            return -1;
        }
    }
}
