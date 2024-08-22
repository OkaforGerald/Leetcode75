using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode75_1431
{
    public class Solution
    {
        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            List<bool> result = new();

            candies.ToList().ForEach(x => result.Add(x + extraCandies >= candies.Max()));

            return result;
        }
    }
}
