using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_csharp.Medium
{
    public class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;

            int maxArea = 0;

            while (left < right)
            {
                int width = right - left;

                int h = Math.Min(height[left], height[right]);

                int area = width * h;

                maxArea = Math.Max(maxArea, area);

                // Move smaller height pointer
                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return maxArea;
        }
    }
}
