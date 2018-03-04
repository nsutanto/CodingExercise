//https://leetcode.com/problems/top-k-frequent-elements/
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class TopKFrequentElements
    {
        public TopKFrequentElements()
        {
        }


        public IList<int> TopKFrequent(int[] nums, int k)
        {
            IList<int> retValue = new List<int>();
            Dictionary<int, int> dict = new Dictionary<int, int>();

            Array.Sort(nums);

            int counter = 0;
            int tempValue = 0;
            foreach(int num in nums)
            {
                if (num != tempValue)
                {
                    counter = 1;
                    dict[num] = counter;
                    tempValue = num;
                }
                else
                {
                    counter++;
                    dict[num] = counter;
                }
            }

            retValue = dict.OrderByDescending(x => x.Value).Select(x => x.Key).Take(k).ToList();
                
            return retValue;
        }
    }
}
