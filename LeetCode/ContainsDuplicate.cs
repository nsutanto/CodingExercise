//https://leetcode.com/problems/contains-duplicate/description/
using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode
{
    public class ContainsDuplicate
    {
        public ContainsDuplicate()
        {
        }

        public bool TestContainsDuplicate(int[] nums)
        {
            HashSet<int> hash = new HashSet<int>();

            foreach(int num in nums)
            {
                if (!hash.Contains(num))
                {
                    hash.Add(num);
                }
                else
                {
                    return true;
                }
            }

            return false;

        }

    }
}
