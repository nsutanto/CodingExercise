using System;
namespace LeetCode
{
    public class BinarySearch
    {
        public BinarySearch()
        {
        }

        // https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/description/
        public int FindMin(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            if (nums.Length == 1)
            {
                return nums[0];
            }

            int start = 0;
            int end = nums.Length - 1;

            while (start < end)
            {
                if (nums[start] < nums[end])
                    return nums[start];

                int mid = (start + end) / 2;

                if (nums[mid] >= nums[start])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid;
                }
            }

            return nums[start];
        }
    }
}
