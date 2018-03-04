using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode
{
    public class WordPattern
    {
        public WordPattern()
        {
        }

        public bool TestWordPattern(string pattern, string str)
        {
            bool retValue = true;
            string tempOutValue = "";
            int patternSize = pattern.Length;
            int arrayStrSize = str.Split(' ').Length;

            if (arrayStrSize != patternSize)
            {
                return false;
            }

            string[] stringArray = str.Split(' ');


            Dictionary<char, string> dictionary = new Dictionary<char, string>();

            for (int i = 0; i < arrayStrSize; i++)
            {
                if (dictionary.TryGetValue(pattern[i], out tempOutValue))
                {
                    if (tempOutValue != stringArray[i])
                    {
                        retValue = false;
                        break;
                    }
                }
                else
                {
                    if (dictionary.ContainsValue(stringArray[i]))
                    {
                        retValue = false;
                        break;
                    }
                    else {
                        dictionary.Add(pattern[i], stringArray[i]);
                    }

                }
            }


            return retValue;
        }
    }
}
