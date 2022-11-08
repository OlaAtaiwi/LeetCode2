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
            var patternDict = new Dictionary<char, string>();
            var wordsDict = new Dictionary<string,char>();
            for (int i = 0; i < pattern.Length; i++)
            {
                if (!patternDict.ContainsKey(pattern[i]))
                {
                    if (!wordsDict.ContainsKey(words[i]))
                    {
                        patternDict.Add(pattern[i], words[i]);
                        wordsDict.Add(words[i], pattern[i]);
                    }
                    else
                        return false;
                }
                else
                {
                    if (patternDict[pattern[i]] != words[i])
                        return false;
                }
            }

            return true;
        }
    }
}
