using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems
{
    class CountPairsInArray
    {
        public static int CountPairs(int[] nums, int k)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
                for (int j = i + 1; j < nums.Length; j++)
                    if (nums[i] == nums[j] && (i * j) % k == 0)
                        result++;
            return result;
        }
    }
}
