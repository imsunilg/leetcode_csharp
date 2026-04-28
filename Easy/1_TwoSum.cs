using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_csharp.Easy
{
    public class SolutionTS
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            int[] ans = new int[2];

            map[nums[0]] = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (map.ContainsKey(target - nums[i]))
                {
                    ans[0] = map[target - nums[i]];
                    ans[1] = i;

                    break;
                }
                map[nums[i]] = i;
            }

            return ans;
        }
    }
    public class TwoSumClass
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }

                map[nums[i]] = i;
            }

            return new int[] { -1, -1 }; // fallback (though problem guarantees one solution)
        }

    }

}
