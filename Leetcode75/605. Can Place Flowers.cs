using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode75_605
{
    public class Solution
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int newlyPlanted = 0;
            if (!flowerbed.Any()) return false;
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (i > 0 && i < flowerbed.Length - 1)
                {
                    if (flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0 && flowerbed[i] != 1)
                    {
                        flowerbed[i]++;
                        newlyPlanted++;
                    }
                }
                else
                {
                    if (i == 0 && flowerbed.Length == 1) { if (flowerbed[i] != 1) newlyPlanted++; break; }
                    if (i == 0 && flowerbed[i + 1] == 0 && flowerbed[i] != 1) { flowerbed[i]++; newlyPlanted++; }
                    if (i == flowerbed.Length - 1 && flowerbed[i - 1] == 0 && flowerbed[i] != 1) { flowerbed[i]++; newlyPlanted++; }
                }
            }

            return newlyPlanted >= n;
        }
    }
}
