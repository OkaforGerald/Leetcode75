using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode75_345
{
    public class Solution
    {
        public string ReverseVowels(string s)
        {
            int rPointer = s.Length - 1;
            int lPointer = 0;
            List<char> Vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];
            var strArray = s.ToCharArray();

            while(lPointer < rPointer && lPointer < s.Length && rPointer < s.Length)
            {
                if (Vowels.Contains(strArray[lPointer]) && Vowels.Contains(strArray[rPointer]))
                {
                    var temp = strArray[lPointer];
                    strArray[lPointer] = strArray[rPointer];
                    strArray[rPointer] = temp;

                    lPointer++;
                    rPointer--;
                }

                if (!Vowels.Contains(strArray[lPointer])) lPointer++;
                if (!Vowels.Contains(strArray[rPointer])) rPointer--;

                if (rPointer < 0) break;
            }

            return new string(strArray);
        }
    }
}
