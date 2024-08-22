using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode75_392
{
    public class Solution
    {
        public bool IsSubsequence(string s, string t)
        {
            int charPosition = 0;
            if (string.IsNullOrEmpty(s)) return true;
            for (int i = 0; i < t.Length; i++)
            {
                if (charPosition == s.Length) break;
                if (t[i] == s[charPosition])
                {
                    charPosition++;
                }

                if (charPosition == s.Length) return true;
            }

            return false;
        }
    }
}
