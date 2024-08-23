using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode75_1137
{
    public class Solution
    {
        public int Tribonacci(int n)
        {
            int[] tribonacci = new int[n + 1];
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1 || n == 2)
            {
                return 1;
            }
            tribonacci[0] = 0;
            tribonacci[1] = 1;
            tribonacci[2] = 1;
            for (int i = 0; i <= n - 3; i++)
            {
                tribonacci[i + 3] = tribonacci[i] + tribonacci[i + 1] + tribonacci[i + 2];
            }
            return tribonacci[n];
        }
    }
}
