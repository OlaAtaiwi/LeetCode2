using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems
{
    class CountPairsInArray
    {
        public static int CountPairs(int[] nums, int k)
        {
            int len = nums.Length;
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
            int result = 0;
            for (int i = 0; i < len; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], new List<int>() {i });
                }
                else
                {
                    foreach (int value in dict[nums[i]])
                    {
                        int p = i * value;
                        if (p % k == 0)
                          result++;
                    }
                    dict[nums[i]].Add(i);
                }

            }
            return result;
        }
    }
}

/* Old Solution
int result = 0;
 for (int i = 0; i < nums.Length; i++)
     for (int j = i + 1; j < nums.Length; j++)
          if (nums[i] == nums[j] && (i * j) % k == 0)
              result++;
return result;*/