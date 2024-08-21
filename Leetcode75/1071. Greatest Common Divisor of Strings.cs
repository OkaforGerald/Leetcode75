using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode75
{
    public class Solution
    {
        public static string GcdOfStrings(string str1, string str2)
        {
            string? prefix = null;
            for (int i = 1; i <= Math.Min(str1.Length, str2.Length); i++)
            {
                var possiblePrefix = str1.Substring(0, i);
                if (possiblePrefix != str2.Substring(0, i))
                {
                    break;
                }
                else
                {
                    if (CheckStringAgainstPrefix(str1, possiblePrefix))
                    {
                        if (CheckStringAgainstPrefix(str2, possiblePrefix)) prefix = possiblePrefix;
                    }
                }
            }

            if (prefix is null) return "";

            return prefix;
        }

        public static bool CheckStringAgainstPrefix(string str, string prefix)
        {
            int i = 0;
            while (i + prefix.Length - 1 < str.Length)
            {
                var subStr = str.Substring(i, prefix.Length);
                if (subStr != prefix) return false;

                i += prefix.Length;
            }
            if (i != str.Length) return false;

            return true;
        }
    }
}
