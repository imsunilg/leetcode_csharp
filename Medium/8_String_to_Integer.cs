using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_csharp.Medium
{
    public class String_to_Integer
    {
        public int MyAtoi(string s)
        {
            const int INT_MIN = int.MinValue;   // -2147483648
            const int INT_MAX = int.MaxValue;   //  2147483647

            int i = 0;
            int n = s.Length;

            // 1) Skip leading spaces
            while (i < n && s[i] == ' ')
                i++;

            // 2) Optional sign
            int sign = 1;
            if (i < n && (s[i] == '+' || s[i] == '-'))
            {
                if (s[i] == '-') sign = -1;
                i++;
            }

            // 3) Read digits
            int num = 0;
            while (i < n && char.IsDigit(s[i]))
            {
                int digit = s[i] - '0';

                // 4) Check overflow before multiply/add
                if (num > (INT_MAX - digit) / 10)
                    return sign == 1 ? INT_MAX : INT_MIN;

                num = num * 10 + digit;
                i++;
            }

            return sign * num;
        }
    }
}
