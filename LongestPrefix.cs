using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLeetCode
{
    internal class LongestPrefix
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            Array.Sort(strs);
            int index = 0;

            if(strs.Length < 1)
            {
                return strs[0];
            }
            else {  

                while(index < strs[0].Length && index < strs[strs.Length-1].Length)
                {
                    if (strs[0].Length > 0 && strs[0][index] == strs[strs.Length - 1][index])
                    {
                        index++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return strs[0].Substring(0, index);
        }
    }
}
