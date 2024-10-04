using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode75_1657
{
    public class Solution
    {
        public bool CloseStrings(string word1, string word2)
        {
            var map1 = CreateCharMap(word1);
            var map2 = CreateCharMap(word2);
            return map1.Keys.Intersect(map2.Keys).Count() == map1.Keys.Count() && CompareValues(map1.Values.ToList(), map2.Values.ToList());
        }

        bool CompareValues(List<int> values1, List<int> values2)
        {
            if (values1.Count != values2.Count) return false;
            values1.Sort();
            values2.Sort();

            for (int i = 0; i < values1.Count; i++)
            {
                if (values1[i] != values2[i]) return false;
            }

            return true;
        }

        Dictionary<char, int> CreateCharMap(string word)
        {
            var map = new Dictionary<char, int>();
            for (int i = 0; i < word.Length; i++)
            {
                if (map.TryGetValue(word[i], out _))
                {
                    map[word[i]]++;
                }
                else
                {
                    map.Add(word[i], 1);
                }
            }
            return map;
        }
    }
}
