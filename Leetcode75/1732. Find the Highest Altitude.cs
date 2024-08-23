using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode75_1732
{
    public class Solution
    {
        public int LargestAltitude(int[] gain)
        {
            int MaxAltitude = 0;
            int counter = 0;
            foreach (var alts in gain)
            {
                counter += alts;
                if (counter > MaxAltitude) MaxAltitude = counter;
            }

            return MaxAltitude;
        }
    }
}
