using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLeetCode
{
    public class PalindromeNumber
    {
        public static bool isPalindrome(int number)
        {
            char[] nr = number.ToString().ToCharArray();
            Array.Reverse(nr);
            string reverse = new string(nr);
            return number.ToString() == reverse;
        }

        public static bool isPalindromeWhileLoop(int x)
        {
            int temp = x;
            int remainder, reversed = 0;
            while (x > 0)
            {
                remainder = x %10;
                reversed = reversed * 10 + remainder;
                x = x /10;
            }

            return temp == reversed;
        }
    }
}
