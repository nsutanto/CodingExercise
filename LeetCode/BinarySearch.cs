using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace LeetCode
{
    public class BinarySearch
    {
        public BinarySearch()
        {
        }

        //https://leetcode.com/problems/single-number/description/
        public int SingleNumber(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (int i in nums)
            {
                if (!dict.ContainsKey(i))
                {
                    dict.Add(i, 1);
                }
                else
                {
                    dict.Remove(i);
                }
            }

            List<int> list = dict.Keys.ToList();

            return list[0];

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
