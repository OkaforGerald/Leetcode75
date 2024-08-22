using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode75_283
{
    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            int lPointer = 0;
            int rPointer = nums.Length - 1;

            while(lPointer < rPointer)
            {
                if (nums[lPointer] == 0)
                {
                    if (nums[rPointer] == 0)
                    {
                        rPointer--;
                        continue;
                    }
                    var temp = nums[lPointer];
                    nums[lPointer] = nums[rPointer];
                    nums[rPointer] = temp;

                    lPointer++;
                    rPointer--;
                }
                else
                {
                    lPointer++;
                }
            }
        }
        //public static void Main(string[] args)
        //{
        //    Solution solution = new Solution();
        //    int[] arr = [0, -1, 7, 0, 8, 0, 4];
        //    solution.MoveZeroes(arr);
        //    Console.WriteLine(String.Join(',', arr));
        //}
    }
}
