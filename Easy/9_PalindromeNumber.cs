using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_csharp.Easy
{
    public class PalindromeNumber
    { 
        public bool IsPalindrome(int x)
        {
            // Negative numbers and numbers ending with 0
            // (except 0 itself) cannot be palindrome
            if (x < 0 || x % 10 == 0 && x != 0)
                return false;

            int reversedHalf = 0;

            // Reverse only half of the number
            while (x > reversedHalf)
            {
                reversedHalf = reversedHalf * 10 + x % 10;
                x /= 10;
            }

            // Even digits: x == reversedHalf
            // Odd digits: x == reversedHalf / 10
            return x == reversedHalf || x == reversedHalf / 10;
        }
    }
}
