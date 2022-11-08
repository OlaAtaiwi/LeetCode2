using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems
{
    class IntersectionOf2Arrays
    {
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            List<int> r = new List<int>();
            var nums2Dictionary=new Dictionary<int, int>();
            foreach (int item in nums2)
                if (!nums2Dictionary.ContainsKey(item))
                    nums2Dictionary.Add(item, 0);
                else
                    nums2Dictionary[item]++;
            List<int> l = Enumerable.ToList(nums1);
            foreach (int item in l)
            {
                if (nums2Dictionary.ContainsKey(item))
                {
                    r.Add(item);
                    if (nums2Dictionary[item] == 0)
                        nums2Dictionary.Remove(item);
                    else
                        nums2Dictionary[item]--;
                }
            }
            int[] result = r.ToArray();
            return result;
            
        }
    }
}
