using leetcode_csharp.Easy;
using leetcode_csharp.Hard;
using leetcode_csharp.Medium;
using System;
using System.Collections.Generic;
class Program
{

    static void Main()
    {
        Console.WriteLine("WelCOme To LeetCode...");
        #region 8 String_to_Integer
        String_to_Integer stringToInteger = new String_to_Integer();
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        int result = stringToInteger.MyAtoi(input);
        Console.WriteLine("Converted integer: " + result);
        #endregion 8 String_to_Integer
        #region 7 ReverseInteger
        /*
         
        ReverseInteger reverseInteger = new ReverseInteger();
        Console.WriteLine("Enter an integer:");
        int input = int.Parse(Console.ReadLine());
        int reversed = reverseInteger.Reverse(input);
        Console.WriteLine("Reversed integer: " + reversed);
        */
        #endregion 7 ReverseInteger
        #region 6 ZigZagConversion
        /*
        Console.WriteLine("Enter string:");
        string input = Console.ReadLine();

        Console.WriteLine("Enter number of rows:");
        int numRows = int.Parse(Console.ReadLine());

        // Create object of solution class
        ZigzagSolution solution = new ZigzagSolution();

        // Call method
        string result = solution.ZigzagConvert(input, numRows);

        Console.WriteLine("Output: " + result);
        */
        #endregion 6 ZigZagConversion

        #region 5 LongestPalindrome
        /*
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        string result = LongestPalindrome.LongestPalindromeClass(input);
        Console.WriteLine("Longest Palindromic Substring: " + result);
        */
        #endregion 5 LongestPalindrome

        #region 4 MedianOfTwoSortedArraysClass
        /*
        Console.WriteLine("Enter Array 1 numbers with space");

        string number1 = Console.ReadLine(); 
        int[] nums1 = number1.Split(new char[] { ',', ' ' }).Select(int.Parse).ToArray();         

        Console.WriteLine("Enter Array 2 numbers with space");

        string number2 = Console.ReadLine();
        int[] nums2 = number2.Split(new char[] {',',' '}).Select(int.Parse).ToArray();
        
        MedianOfTwoSortedArraysClass obj = new MedianOfTwoSortedArraysClass();
        double result = obj.FindMedianSortedArrays(nums1, nums2);

        Console.WriteLine("Median: " + result);
        */
        #endregion 4 MedianOfTwoSortedArraysClass

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

        /*int firstNumber = readNumber("Enter first Number");
        int secondNumber = readNumber("Enter second Number");

        int maxNumber= Math.Max(firstNumber, secondNumber);
        Console.WriteLine("Max Number is: " + maxNumber);
        */

    }

    static int readNumber(string message)
    {
        int number;
        while (true)
        {
            Console.WriteLine(message);
            if (int.TryParse(Console.ReadLine(), out number))
            {
                return number;
            }
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}
 