// https://leetcode.com/problems/sort-characters-by-frequency/description/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class SortCharactersByFrequency
    {
        public SortCharactersByFrequency()
        {
        }

        public string FrequencySort(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            int counter = 1;
            foreach (char c in s)
            {
                if (dict.ContainsKey(c))
                {
                    int tempCounter = dict[c];
                    dict[c] = tempCounter + 1;
                }
                else
                {
                    dict.Add(c, counter);
                }
            }

            List<char> list = new List<char>();
            list = dict.OrderByDescending(x => x.Value).Select(x => x.Key).ToList();


            StringBuilder stringBuilder = new StringBuilder();
            foreach (char c in list)
            {
                int count = dict[c];
                for (int i = 0; i < count; i++)
                {
                    stringBuilder.Append(c);
                }
            }


            return stringBuilder.ToString();
        }
    }
}
