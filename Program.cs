using System.Globalization;

namespace EasyLeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = { 2, 7, 11, 15 };
            //int[] nums2 = { 3, 2, 4 };

            //foreach (int i in TwoSumClass.TwoSumOn(nums2, 6))
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine(PalindromeNumber.isPalindromeWhileLoop(1221));

            //Console.WriteLine(RomanToInteger.RomanToInt("IVII"));

            //string[] strings = { "ab", "a" };

            //Console.WriteLine(LongestPrefix.LongestCommonPrefix(strings));

            //int[] arr = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

            //Console.WriteLine(RemoveDuplicatesFromSortedArray.RemoveDuplicates3(arr));

            //foreach (var item in RemoveDuplicatesFromSortedArray.RemoveDuplicates2(arr))
            //{
            //    Console.WriteLine(item);
            //}

            string par = "([}}])";
            //string par = "()";

            Console.WriteLine(ValidParantheses.IsValid(par));

        }
    }
}