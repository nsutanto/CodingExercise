//https://leetcode.com/problems/isomorphic-strings/description/
using System;
using System.Collections.Generic;
namespace LeetCode
{
    public class IsIsomorphic
    {
        public IsIsomorphic()
        {
        }

        public bool TestIsIsomorphic(string s, string t)
        {
            Dictionary<char, char> dict = new Dictionary<char, char>();
            char valueOut;

            for (int i = 0; i < s.Length; i++)
            {
                if (dict.TryGetValue(s[i], out valueOut))
                {
                    if (valueOut != t[i])
                    {
                        return false;
                    }
                }
                else
                {
                    if (dict.ContainsValue(t[i]))
                    {
                        return false;
                    }
                    dict.Add(s[i], t[i]);
                }
            }


            return true;
        }
    }
}
