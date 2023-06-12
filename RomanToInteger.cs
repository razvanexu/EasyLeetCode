using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLeetCode
{
    internal class RomanToInteger
    {
        public static int RomanToInt(string s)
        {
            Dictionary<char, int> romanToIntMap = new Dictionary<char, int>();
            romanToIntMap.Add('I', 1);
            romanToIntMap.Add('V', 5);
            romanToIntMap.Add('X', 10);
            romanToIntMap.Add('L', 50);
            romanToIntMap.Add('C', 100);
            romanToIntMap.Add('D', 500);
            romanToIntMap.Add('M', 1000);
            int result = 0;
            char current = s[s.Length-1];

            for(int i = s.Length-1; i >= 0; i--)
            {
                if (s.Length == 1)
                {
                    result = romanToIntMap.FirstOrDefault(x => x.Key == s[i]).Value;
                }
                else if (romanToIntMap.FirstOrDefault(x => x.Key == s[i]).Value >= romanToIntMap.FirstOrDefault(x => x.Key == current).Value)
                {
                    result += romanToIntMap.FirstOrDefault(x => x.Key == s[i]).Value;
                    current = s[i];
                }
                else
                {
                    result -= romanToIntMap.FirstOrDefault(x => x.Key == s[i]).Value;
                    current = s[i];
                }
            }
            return result;
        }
    }
}
