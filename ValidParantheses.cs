using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EasyLeetCode
{
    internal class ValidParantheses
    {
        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            if (s.Length % 2 != 0 || s[0] == ')' || s[0] == '}' || s[0] == ']')
            {
                return false;
            }

            for (int i = 0; i < s.Length-1; i++)
            {
                stack.Push(s[i]);

                if (s[i+1] == ')' && stack.Peek() == '(' || s[i+1] == '}' && stack.Peek() == '{' || s[i+1] == ']' && stack.Peek() == '[')
                {
                    stack.Pop();
                }
            }

            return stack.Count() == 0;

        }
    }
}
