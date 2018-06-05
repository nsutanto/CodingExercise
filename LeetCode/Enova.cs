using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    public class Enova
    {
        public Enova()
        {
        }


       
        // Pangram
        /*
        public void testJPMorgan()
        {
            using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
                 while (!reader.EndOfStream) {
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }
        }
        */

        public string solution(string S)
        {
            if (string.IsNullOrEmpty(S))
            {
                return "";
            }

            string retValue = "";

            StringBuilder strBuilder = new StringBuilder();
            // Map for char and counter
            Dictionary<char, int> dict = new Dictionary<char, int>();
            string lowerCaseStr = S.ToLower();

            foreach (char c in lowerCaseStr)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    if (!dict.ContainsKey(c))
                    {
                        dict.Add(c, 1);
                    }
                    else
                    {
                        int counter = dict[c];
                        counter++;
                        dict[c] = counter;
                    }
                }
            }

            // sort dictionary by value
            //Dictionary<char, int> sortedDict = new Dictionary<char, int>();
            //sortedDict = (System.Collections.Generic.Dictionary<char, int>)dict.OrderByDescending(x => x.Value).Select(x => x.Key);

            var items = dict.OrderByDescending(r => r.Value);
                //.ThenBy(r => r.Key);

            int dictCounter = 0;
            int maxCount = 0;


            foreach (var item in items)
            {
                // just want to get the max value, since it is already sorted, it should be the first one.
                maxCount = item.Value;
                break;
            }

            List<char> sequenceChar = new List<char>();
            sequenceChar.Add('a');
            sequenceChar.Add('e');
            sequenceChar.Add('i');
            sequenceChar.Add('o');
            sequenceChar.Add('u');

            foreach (char seqChar in sequenceChar)
            {
                foreach (var item in items)
                {
                    if (item.Key == seqChar)
                    {
                        if (item.Value == maxCount)
                        {
                            if (dictCounter > 0)
                            {
                                strBuilder.Append("\n");
                            }

                            strBuilder.Append(item.Key);
                            strBuilder.Append(" appears ");
                            strBuilder.Append(item.Value);

                            strBuilder.Append(" time");
                            if (item.Value > 1)
                            {
                                strBuilder.Append("s");
                            }
                            dictCounter++;
                        }

                    }
                }   
            }

            retValue = strBuilder.ToString();
            return retValue;
        }

    }
}
