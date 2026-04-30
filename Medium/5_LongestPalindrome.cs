using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_csharp.Medium
{
    internal class LongestPalindrome
    {
       public static string LongestPalindromeClass(string s)
       {
            if (string.IsNullOrEmpty(s)) return "";

            int start = 0, maxLength = 1;

            for (int i = 0; i < s.Length; i++)
            {
                // Odd length palindrome
                ExpandFromCenter(s, i, i, ref start, ref maxLength);

                // Even length palindrome
                ExpandFromCenter(s, i, i + 1, ref start, ref maxLength);
            }

            return s.Substring(start, maxLength);
       }

        static void ExpandFromCenter(string s, int left, int right, ref int start, ref int maxLength)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                int length = right - left + 1;

                if (length > maxLength)
                {
                    start = left;
                    maxLength = length;
                }

                left--;
                right++;
            }
        }
    }
}
