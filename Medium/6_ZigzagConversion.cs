using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_csharp.Medium
{

    public class ZigzagSolution
    {
        public string ZigzagConvert(string s, int numRows)
        {
            if (numRows == 1 || s.Length <= numRows)
                return s;

            string[] rows = new string[numRows];

            for (int i = 0; i < numRows; i++)
                rows[i] = "";

            int currentRow = 0;
            bool goingDown = false;

            foreach (char c in s)
            {
                rows[currentRow] += c;

                if (currentRow == 0 || currentRow == numRows - 1)
                    goingDown = !goingDown;

                currentRow += goingDown ? 1 : -1;
            }

            string result = "";

            foreach (string row in rows)
                result += row;

            return result;
        }
    }
}
