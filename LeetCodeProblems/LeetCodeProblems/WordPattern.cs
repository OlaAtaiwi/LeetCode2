using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems
{
    class WordPattern
    {
        public static bool WordsPattern(string pattern, string s)
        {

           var words = s.Split(' ');
            if (words.Length != pattern.Length)
                return false;
            Dictionary<char, string> Dict = new Dictionary<char, string>();
            for (int i = 0; i < pattern.Length; i++)
            {
                if (Dict.ContainsKey(pattern[i]))
                {
                    if (Dict[pattern[i]] != words[i])
                        return false;
                }
                else
                {
                    if (Dict.ContainsValue(words[i]))
                        return false;
                    else
                        Dict.Add(pattern[i], words[i]);
                }
            }
            return true;
        }
    }
}
