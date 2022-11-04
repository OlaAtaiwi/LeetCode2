using System;

namespace LeetCodeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
            do
            {
                Console.WriteLine("1- Count equal and divisible pairs in an array\n" +
                "2- Suntract the product and sum of digits of a number\n" +
                "3- Valid anagram\n" +
                "4- Word pattern\n" +
                "5- Intersection of 2 arrays\n" +
                "6- Exit" +
                " Choose Your Option");
                Console.WriteLine("_____________________________________________________");
                string input = Console.ReadLine();
                if (int.TryParse(input, out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Problem: Given a 0-indexed integer array nums of length n and an integer k, return the number of pairs (i, j) " +
                                "\nwhere 0 <= i < j < n, such that nums[i] == nums[j] and (i * j) is divisible by k.\n");
                            int[] arr = { 3, 1, 2, 2, 2, 1, 3 };
                            int k = 2;
                            Console.WriteLine("Our Array is: ");
                            Print(arr);
                            int result = CountPairsInArray.CountPairs(arr, k);
                            Console.WriteLine("Number of pairs= " + result);
                            Console.WriteLine("____________________________________________________");
                            break;
                        case 2:
                            Console.WriteLine("Problem: Given an integer number n, return the difference between the product of its digits and the sum of its digits.\n");
                            int number = 2345;
                            var difference = SubtractProductAndSumOfDigits.SubtractProductAndSum(number);
                            Console.WriteLine("Difference between product and summation of " + number + " digits is: " + difference);
                            Console.WriteLine("____________________________________________________");
                            break;
                        case 3:
                            Console.WriteLine("Problem: Given two strings s and t, return true if t is an anagram of s, and false otherwise." +
                            "\nAn Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using " +
                            "all the original letters exactly once.\n");
                            String str1 = "anagram", str2 = "nagaram";
                            Console.WriteLine($"our 2 Strings are:'{str1}' and '{str2}'");
                            bool isAnagram = ValidAnagram.IsAnagram(str1, str2);
                            if (isAnagram)
                                Console.WriteLine("2 Strings are Anagram");
                            else
                                Console.WriteLine("2 Strings are NOT Anagram");
                            Console.WriteLine("_____________________________________________________");
                            break;
                        case 4:
                            Console.WriteLine("Problem: Given a pattern and a string s, find if s follows the same pattern.\nHere follow means"+
                             "a full match, such that there is a bijection between a letter in pattern and a non - empty word in s\n");
                            string pattern = "abba";
                            string sentance = "dog cat cat dog";
                            Console.WriteLine($"Our Pattern is: '{pattern}' and our sentance is: '{sentance}'");
                            Console.WriteLine("Checking if sentence matches the pattern..");
                            var matches = WordPattern.WordsPattern(pattern, sentance);
                            if (matches)
                                Console.WriteLine("Yes! Matches");
                            else
                                Console.WriteLine("No! does not match");
                            Console.WriteLine("_____________________________________________________");
                            break;
                        case 5:
                            Console.WriteLine("Given two integer arrays nums1 and nums2, return an array of their intersection\n");
                            int[] arr1= {1,2,1,3,4,5};
                            int[] arr2= {1,3,6,5,1 };
                            int[] intersection = IntersectionOf2Arrays.Intersect(arr1, arr2);
                            Console.Write("Array1: ");
                            Print(arr1);
                            Console.Write("Array2: ");
                            Print(arr2);
                            Console.Write("Intersection of the 2 Arrays: ");
                            Print(intersection);
                            Console.WriteLine("_____________________________________________________");
                            break;
                        default:
                            Console.WriteLine("Please enter number between 1 and 6 only");
                            break;
                    }
                }
                else
                    Console.WriteLine("Please enter numbers only");
            } while (choice != 6);
        }
        private static void Print(int[] arr)
        {
            foreach (int item in arr)
                Console.Write(item + " ");
            Console.WriteLine();
        }
    }
}

