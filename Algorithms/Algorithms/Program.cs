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
                else if (nums[mid] > target)
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

    }
    public class Program
    {
        public static void Main()
        {
            #region BINARY SEARCH

            int[] nums = { 1, 3, 5, 7, 9 };
            int target = 5;

            Solution solution = new Solution();
            int result = solution.Search(nums, target);

            Console.WriteLine("Index of target: " + result);

            #endregion
        }
    }
}