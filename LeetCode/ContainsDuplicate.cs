//https://leetcode.com/problems/contains-duplicate/description/
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

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


        public void TestExpediaTest2()
        {
            List<string> listStr2 = new List<string>();
            using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
                
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                listStr2.Add(line);
            }

            string[] arrayStr = listStr2.ToArray();

            int numToPrint = int.Parse(arrayStr[0]);

            Dictionary<string, int> dict = new Dictionary<string, int>();
            for (int i = 1; i < arrayStr.Length; i++)
            {
                if (arrayStr[i] != "")
                {
                    int stringSize = arrayStr[i].Length;
                    dict.Add(arrayStr[i], stringSize);
                }
            }

            List<string> listStr = new List<string>();
            listStr = dict.OrderByDescending(x => x.Value).Select(x => x.Key).Take(numToPrint).ToList();

            StringBuilder strBuilder = new StringBuilder();
            int ctr = 0;
            foreach (string s in listStr)
            {
                strBuilder.Append(s);
                if (ctr != listStr.Count - 1)
                {
                    strBuilder.Append("\n");
                }
            }

            string retValue = strBuilder.ToString();
            Console.WriteLine(retValue);
                
            //retValue = dict.OrderByDescending(x => x.Value).Select(x => x.Key).Take(k).ToList();
        }

        static IEnumerable<IEnumerable<T>>
            GetPermutations<T>(IEnumerable<T> list, int length)
        {
            if (length == 1) return list.Select(t => new T[] { t });

            return GetPermutations(list, length - 1)
                .SelectMany(t => list.Where(e => !t.Contains(e)),
                    (t1, t2) => t1.Concat(new T[] { t2 }));
        }



        public void TestExpediaTest1()
        {
            //string line = reader.ReadLine();
            string line = "40 40 40 40 29 29 29 29 29 29 29 29 57 57 92 92 92 92 92 86 86 86 86 86 86 86 86 86 86";

            string[] arrayNums = line.Split(' ');

            Dictionary<string, int> dict = new Dictionary<string, int>();
            StringBuilder retValue = new StringBuilder();
            foreach (string s in arrayNums)
            {
                if (!dict.ContainsKey(s))
                {
                    dict.Add(s, 1);
                }
                else
                {
                    int counter = dict[s];
                    counter = counter + 1;
                    dict[s] = counter;
                }
            }

            int ctr = 0;
            foreach (var item in dict)
            {
                retValue.Append(item.Value);
                retValue.Append(" ");
                retValue.Append(item.Key);

                if (ctr != dict.Count - 1)
                {
                    retValue.Append(" ");
                }


            }
            string retValString = retValue.ToString();
        }


        public void TestExpedia()
        {
            /*
            using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    UInt32 intNum = Convert.ToUInt32(line);

                    UInt32 result = intNum * intNum;

                    Console.WriteLine(result);
                }
                */


            using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    line = "40 40 40 40 29 29 29 29 29 29 29 29 57 57 92 92 92 92 92 86 86 86 86 86 86 86 86 86 86";

                    string[] arrayNums = line.Split(' ');

                    Dictionary<string, int> dict = new Dictionary<string, int>();
                    StringBuilder retValue = new StringBuilder();
                    foreach (string s in arrayNums)
                    {
                        if (!dict.ContainsKey(s))
                        {
                            dict.Add(s, 1);
                        }
                        else
                        {
                            int counter = dict[s];
                            counter = counter + 1;
                            dict[s] = counter;
                        }
                    }

                    foreach (var item in dict)
                    {
                        retValue.Append(item.Value);
                        retValue.Append(" ");
                        retValue.Append(item.Key);

                    }


                Console.WriteLine(retValue.ToString());
                }
        }

    }
}
