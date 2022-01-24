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
            string longestPalindrome = "";
            Dictionary<char, List<int>> letterPositions = new();

            // add all letter indexes to dictionary
            for (int i = 0; i < s.Length; i++)
            {
                var theLetter = s[i];
                if (!letterPositions.ContainsKey(theLetter))
                    letterPositions.Add(theLetter, new List<int>());
                letterPositions[theLetter].Add(i);
            }

            foreach (var letter in letterPositions)
            {
                // if the letter doesnt exist more than once it cant be the start of a palindrome
                if (letter.Value.Count < 2)
                    continue;

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

                        if (potentialPalindromeR - potentialPalindromeL + 1 < longestPalindrome.Length)
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
                            int newPalindromeLength = potentialPalindromeR - potentialPalindromeL + 1;
                            if (newPalindromeLength > longestPalindrome.Length)
                            {
                                longestPalindrome = s.Substring(potentialPalindromeL, newPalindromeLength);
                            }
                        }
                    }
                }
            }

            if (String.IsNullOrEmpty(longestPalindrome))
                return s.Length > 0 ? s[0].ToString() : "";

            return longestPalindrome;
        }
    }
}
