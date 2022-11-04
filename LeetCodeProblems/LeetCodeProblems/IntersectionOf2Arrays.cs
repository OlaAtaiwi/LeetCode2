using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems
{
    class IntersectionOf2Arrays
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            List<int> r = new List<int>();
            List<int> l = Enumerable.ToList(nums1);
            List<int> ll = Enumerable.ToList(nums2);
            foreach (int item in l)
            {
                if (ll.Contains(item))
                {
                    r.Add(item);
                    ll.Remove(item);
                }
            }
            int[] result = r.ToArray();
            return result;
            
        }
    }
}
