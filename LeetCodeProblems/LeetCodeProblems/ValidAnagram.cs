using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems
{
    class ValidAnagram
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;
            char[] sArray = s.ToCharArray();
            char[] tArray = t.ToCharArray();
            Array.Sort(sArray);
            Array.Sort(tArray);
            for (int i = 0; i < sArray.Length; i++)
                if (sArray[i] != tArray[i])
                    return false;
            return true;
        }
    }
}
