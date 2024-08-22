using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode75_151
{
    public class Solution
    {
        public string ReverseWords(string s)
        {
            var words = new List<string>();
            var tokens = s.Split(' ');

            foreach(var token in tokens)
            {
                if(!string.IsNullOrEmpty(token)) words.Add(token);
            }
            words.Reverse();
            return string.Join(' ', words);
        }
    }
}
