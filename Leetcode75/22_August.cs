using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode75
{
        public class Solution
        {
            public int FindComplement(int num)
            {
                StringBuilder sb = new();
                int result = 0;
                while (num != 0)
                {
                    var remainder = num % 2;
                    sb.Append(remainder);
                    num = num / 2;
                }

                var binary = sb.ToString().Reverse().ToArray();
                for (int i = 0; i < binary.Count(); i++)
                {
                    if (binary[i] == '1') { binary[i] = '0'; } else { binary[i] = '1'; };
                }
                
                for(int i = 0; i < binary.Length; i++)
                {
                    result += (int)char.GetNumericValue(binary[i]) * (int) Math.Pow(2, binary.Length - (i + 1));
                }

                return result;
            }
        }
    }
