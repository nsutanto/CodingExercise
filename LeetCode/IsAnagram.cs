//https://leetcode.com/problems/valid-anagram/description/
using System;
using System.Collections.Generic;
namespace LeetCode
{
    public class IsAnagram
    {
        public IsAnagram()
        {
        }

        public bool TestIsAnagram(string s, string t)
        {
            if (s == t)
            {
                return true;
            }

            if (s.Length != t.Length)
            {
                return false;
            }

            char[] arrayS = s.ToCharArray();
            char[] arrayT = t.ToCharArray();

            Array.Sort(arrayS);
            Array.Sort(arrayT);


            for (int i = 0; i < arrayS.Length; i++)
            {
                if (arrayS[i] != arrayT[i])
                {
                    return false;
                }
            }
           
            return true;
        }

    }
}
