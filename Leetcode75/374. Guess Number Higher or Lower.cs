using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode75_374
{
    /** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

    public class Solution : GuessGame
    {
        public int GuessNumber(int n)
        {
            int l = 1;
            int r = n;

            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                int result = guess(mid);
                if (result == 0) return mid;

                if (result == 1)
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }
            return -1;
        }
    }
}
