using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode75_283
{
    public class Solution
    {
        public static void MoveZeroes(int[] nums)
        {
            int i = 0, j = 0;

            while (j < nums.Length - 1 && i < nums.Length)
            {
                if (nums[i] != 0) { i++; continue; }

                j = i;
                while (nums[j] == 0 && j < nums.Length - 1)
                {
                    j++;
                }
                (nums[i], nums[j]) = (nums[j], nums[i]);
            }
        }
    }
}
