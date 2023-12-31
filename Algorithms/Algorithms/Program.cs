﻿using System;
using static Algorithms.Solution;

namespace Algorithms
{
    public class Solution
    {
        #region BINARY SEARCH

        //Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search target in nums.If target exists, then return its index.Otherwise, return -1.

        //You must write an algorithm with O(log n) runtime complexity.

        public int Search(int[] nums, int target)
        {

            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }


        #endregion

        #region First Bad Version

        //You are a product manager and currently leading a team to develop a new product.Unfortunately,
        //the latest version of your product fails the quality check.Since each version is developed based on the previous version,
        //all the versions after a bad version are also bad.
        //Suppose you have n versions[1, 2, ..., n] and you want to find out the first bad one, which causes all the following ones to be bad.
        //You are given an API bool isBadVersion(version) which returns whether version is bad.Implement a function to find the first bad version.
        //You should minimize the number of calls to the API.
        public class VersionControl
        {
            private int badVersion;

            public VersionControl(int bad)
            {
                badVersion = bad;
            }

            public bool IsBadVersion(int version)
            {
                return version >= badVersion;
            }

            public int FirstBadVersion(int n)
            {
                int left = 1;
                int right = n;

                while (left < right)
                {
                    int mid = left + (right - left) / 2;

                    if (IsBadVersion(mid))
                    {
                        right = mid;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }

                return left;
            }
        }




        #endregion

        #region SearchInsert

        public int SearchInsert(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            // The target is not found, return the index where it would be inserted
            return left;
        }

        #endregion

        #region SortedSquares

        //Given an integer array nums sorted in non-decreasing order,
        //return an array of the squares of each number sorted in non-decreasing order.

        //Example 1:

        //Input: nums = [-4, -1, 0, 3, 10]
        //Output: [0,1,9,16,100]
        //Explanation: After squaring, the array becomes[16, 1, 0, 9, 100].
        //After sorting, it becomes [0,1,9,16,100].

        public int[] SortedSquares(int[] nums)
        {
            int[] squares = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                squares[i] = nums[i] * nums[i];
            }

            Array.Sort(squares);

            return squares;
        }

        #endregion

        #region Rotate

        //Given an integer array nums,
        //rotate the array to the right by k steps, where k is non-negative.
        public void Rotate(int[] nums, int k)
        {
            int n = nums.Length;

            // Handle the case where k is larger than array length
            k %= n;

            // Create a temporary array to store the rotated elements
            int[] temp = new int[k];

            // Copy the last k elements from the original array to the temporary array
            Array.Copy(nums, n - k, temp, 0, k);

            // Shift the remaining elements of the original array to the right by k steps
            for (int i = n - k - 1; i >= 0; i--)
            {
                nums[i + k] = nums[i];
            }

            // Copy the elements from the temporary array back to the original array
            Array.Copy(temp, 0, nums, 0, k);
        }

        #endregion

    }
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>BINARY SEARCH>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");

            #region BINARY SEARCH

            int[] nums = { 1, 3, 5, 7, 9 };
            int target = 5;

            Solution solution = new Solution();
            int result = solution.Search(nums, target);

            Console.WriteLine("Index of target: " + result);

            #endregion

            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>First Bad Version>>>>>>>>>>>>>>>>>>>>>>>>>");

            #region First Bad Version

            int n = 5;
            int bad = 4;

            VersionControl versionControl = new VersionControl(bad);
            int firstBadVersion = versionControl.FirstBadVersion(n);

            Console.WriteLine("First Bad Version: " + firstBadVersion);

            #endregion

            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>SearchInsert>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");

            #region SearchInsert

            int[] orderedNums = { 1, 3, 5, 6 };
            int versionTarget = 5;

            int index = solution.SearchInsert(orderedNums, versionTarget);

            Console.WriteLine("Index: " + index);

            #endregion

            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>SortedSquares>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");

            #region SortedSquares

            int[] numsArr = { -4, -1, 0, 3, 10 };

            int[] sortedResult = solution.SortedSquares(numsArr);

            Console.WriteLine("Output: [" + string.Join(", ", sortedResult) + "]");

            #endregion

            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>Rotate>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");

            #region Rotate

            int[] noms = { 1, 2, 3, 4, 5, 6, 7 };
            int k = 3;

            solution.Rotate(noms, k);

            Console.WriteLine("Output: [" + string.Join(", ", nums) + "]");

            #endregion
        }
    }
}