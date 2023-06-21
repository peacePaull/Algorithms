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

        private bool IsBadVersion(int mid)
        {
            throw new NotImplementedException();
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

            #region First Bad Version

            int n = 5;
            int bad = 4;

            int firstBadVersion = solution.FirstBadVersion(n);

            Console.WriteLine("First Bad Version: " + firstBadVersion);

            #endregion
        }
    }
}