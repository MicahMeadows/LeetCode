using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public static class LC5_LongestPalindromaticString
    {
        public static string LongestPalindrome(string s)
        {
            int longestL = 0;
            int longestR = 0;
            Dictionary<char, List<int>> letterPositions = new();

            // add all letter indexes to dictionary
            for (int i = 0; i < s.Length; i++)
            {
                var theLetter = s[i];
                if (!letterPositions.ContainsKey(theLetter))
                    letterPositions.Add(theLetter, new List<int>());
                letterPositions[theLetter].Add(i);
            }

            // check palindromes of each letter in hash
            foreach (var letter in letterPositions)
            {
                // if the letter doesnt exist more than once it cant be the start of a palindrome
                if (letter.Value.Count < 2)
                    continue;

                // loop through each potential letter
                for (int i = 0; i < letter.Value.Count - 1; i++)
                {
                    //for (int j = i + 1; j < letter.Value.Count; j++)
                    for (int j = letter.Value.Count - 1; j >= i + 1; j--)
                    {
                        int valL = letter.Value[i];
                        int valR = letter.Value[j];
                        int potentialPalindromeL = valL;
                        int potentialPalindromeR = valR;

                        Console.WriteLine($"{valL} <-> {valR} potPal: {s.Substring(valL, valR - valL + 1)}");

                        if (potentialPalindromeR - potentialPalindromeL + 1 < longestR - longestL + 1)
                        {
                            i++;
                            j = letter.Value.Count;
                            continue;
                        }

                        while (valL <= valR)
                        {
                            if (s[valL] == s[valR])
                            {
                                valL++;
                                valR--;
                            } 
                            else
                            {
                                break;
                            }
                        }
                        if (valL > valR)
                        {
                            if (potentialPalindromeR - potentialPalindromeL + 1 > longestR - longestL + 1)
                            {
                                longestL = potentialPalindromeL;
                                longestR = potentialPalindromeR;
                            }
                        }
                    }
                }
            }

            if (String.IsNullOrEmpty(s))
                return "";

            return s.Substring(longestL, longestR - longestL + 1);
        }
    }
}
