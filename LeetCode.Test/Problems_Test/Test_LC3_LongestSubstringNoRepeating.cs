using LeetCode.Problems;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test
{
    [TestFixture]
    public class Test_LC3_LongestSubstringNoRepeating
    {

        [TestCase("abcabcbb", ExpectedResult = 3)]
        [TestCase("bbbbb", ExpectedResult = 1)]
        [TestCase("pwwkew", ExpectedResult = 3)] 
        public int LengthOfLongestSubstringTest(string s)
        {
            return LC3_LongestSubstringNoRepeating.LengthOfLongestSubstring(s);
        }
    }
}
