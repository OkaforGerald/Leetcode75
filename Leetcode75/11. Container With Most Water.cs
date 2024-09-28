using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode75_11
{
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int lPointer = 0;
            int rPointer = height.Length - 1;
            int LargestArea = 0;
            while (lPointer <= rPointer)
            {
                var CurrentArea = Math.Min(height[lPointer], height[rPointer]) * (rPointer - lPointer);
                if (CurrentArea > LargestArea) LargestArea = CurrentArea;
                if (height[rPointer] > height[lPointer]) { lPointer++; } else { rPointer--; }
            }

            return LargestArea;
        }
    }
}
