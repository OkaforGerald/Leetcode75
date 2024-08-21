using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode75
{
    public class Solution
    {
        public string MergeAlternately(string word1, string word2)
        {
            StringBuilder sb = new();
            int limit = Math.Min(word1.Length, word2.Length);
            for (int i = 0; i < Math.Min(word1.Length, word2.Length); i++)
            {
                sb.Append(word1[i]);
                sb.Append(word2[i]);
            }
            if (word1.Length > word2.Length) { sb.Append(word1.Substring(limit)); } else { sb.Append(word2.Substring(limit)); }
            return sb.ToString();
        }
    }
}
