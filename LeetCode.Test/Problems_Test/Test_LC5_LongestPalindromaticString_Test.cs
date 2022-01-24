using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Problems;
using NUnit.Framework;
namespace LeetCode.Test.Problems_Test
{
    [TestFixture]
    public class Test_LC5_LongestPalindromaticString_Test
    {
        [TestCase("a", ExpectedResult = "a")]
        [TestCase("babad", ExpectedResult = "bab")]
        [TestCase("cbbd", ExpectedResult = "bb")] 
        [TestCase("someracecardrives", ExpectedResult = "racecar")]
        [TestCase("abtacocatcd", ExpectedResult = "tacocat")]
        [TestCase("", ExpectedResult = "")]
        [TestCase("aacabdkacaa", ExpectedResult = "aca")]
        [TestCase("dad", ExpectedResult = "dad")]
        [TestCase("xaabacxcabaaxcabaax", ExpectedResult = "xaabacxcabaax")]
        [TestCase("abcda", ExpectedResult = "a")]
        [TestCase("aaaabaaa", ExpectedResult = "aaabaaa")]

        public string LongestPalindromeTest(string s)
        {
            return LC5_LongestPalindromaticString.LongestPalindrome(s);
        }
        
        [Test]
        public void LongestPalindromeTest_MultipleSingleChar_ReturnsOneOfThemByItself()
        {
            var result = LC5_LongestPalindromaticString.LongestPalindrome("abc");

            var isCorrect = result.Equals("a") || result.Equals("b") || result.Equals("c");

            Assert.True(isCorrect);
        }
    }
}
