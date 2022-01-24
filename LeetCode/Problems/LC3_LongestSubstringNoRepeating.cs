using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public static class LC3_LongestSubstringNoRepeating
    {
        public static int LengthOfLongestSubstring(string s)
        {
            int leftIdx = 0;
            int longestSubstringLen = 0;
            HashSet<char> curSubstringLetters = new HashSet<char>();

            for (int rightIdx = 0; rightIdx < s.Length; rightIdx++)
            {
                while (curSubstringLetters.Contains(s[rightIdx]))
                {
                    curSubstringLetters.Remove(s[leftIdx]);
                    leftIdx++;
                }
                curSubstringLetters.Add(s[rightIdx]);
                longestSubstringLen = Math.Max(longestSubstringLen, (rightIdx - leftIdx) + 1);
            }

            return longestSubstringLen;
        }
    }
}
