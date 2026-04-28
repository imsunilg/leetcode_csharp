using leetcode_csharp.Easy;
using leetcode_csharp.Medium;
using System;
using System.Collections.Generic;
class Program
{
  static void Main()
    {
        Console.WriteLine("WelCOme To LeetCode...");

        #region 3 LongestSubstringWithoutRepeatingCharacters
        /*
        Console.WriteLine("Enter string:");
        string input = Console.ReadLine();

        LongestSubstringClass obj = new LongestSubstringClass();
        int result = obj.LengthOfLongestSubstring(input);

        Console.WriteLine("Longest substring length: " + result);
        */
        #endregion 3 LongestSubstringWithoutRepeatingCharacters

        #region 2 AddTwoNumbers
        /*
        Console.WriteLine("Enter digits for l1 (space separated):");
        int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine("Enter digits for l2 (space separated):");
        int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        AddTwoNumbersClass obj = new AddTwoNumbersClass();

        ListNode l1 = obj.CreateList(arr1);
        ListNode l2 = obj.CreateList(arr2);

        ListNode result = obj.AddTwoNumbers(l1, l2);

        Console.WriteLine("Result:");
        obj.PrintList(result);
        */
        #endregion 2 AddTwoNumbers

        #region 1 TwoSum
        /*
        //var input = Console.ReadLine();

        //string[] splitValue= input.Split(',');



        //for(int i=0;i< splitValue.Length; i++)
        //{
        //    Console.WriteLine(splitValue[i]);
        //}

        //foreach (var item in splitValue)
        //{
        //    Console.WriteLine(item);
        //} 

        Console.WriteLine("Enter numbers (comma separated):"); 

        int[] nums = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);

        Console.WriteLine("Enter target:");
        int target = int.Parse(Console.ReadLine());

        int[] result = TwoSumClass.TwoSum(nums, target);

        Console.WriteLine($"Output: [{result[0]}, {result[1]}]");
        */
        #endregion 1 TwoSum

    }
}
 