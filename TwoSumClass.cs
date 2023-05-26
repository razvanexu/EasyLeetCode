using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLeetCode
{
    public class TwoSumClass
    {
        public static int[] TwoSumOnSquared(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] {i, j};
                    }
                }
            }
            throw new Exception("not found");
        }

        public static int[] TwoSumOn(int[] nums, int target)
        {
            Dictionary<int, int> hashTable = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int temp = target - nums[i];
                if (hashTable.ContainsKey(temp))
                {
                    return new int[] { hashTable[temp], i};
                }
                else
                {
                    hashTable[nums[i]] = i;
                }
            }
            throw new Exception("not found");
        }
    }
}
