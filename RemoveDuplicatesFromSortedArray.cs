using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLeetCode
{
    internal class RemoveDuplicatesFromSortedArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            nums = nums.Distinct().ToArray();
            return nums.Length;
        }

        public static int[] RemoveDuplicates2(int[] nums)
        {
            int[] expected = new int[nums.Length+1];

            expected = nums.GroupBy(x => x)
                .Where(x => x.Count() > 1)
                .Select(x => x.Key)
                .ToArray()
                .Concat(nums.Distinct())
                .ToArray();

            //return nums.Distinct().Count();
            return expected;
        }

        public static int RemoveDuplicates3(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            else if (nums.Length == 1)
                return 1;

            int index1 = 0,
                index2 = 1;

            while (index2 <= nums.Length - 1)
                if (nums[index1] == nums[index2])
                    index2++;
                else
                    nums[++index1] = nums[index2++];

            return ++index1;
        }

    }
}
