// https://www.hackerrank.com/challenges/insertionsort1/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void insertionSort1(int n, int[] arr)
    {
        // Complete this function
        for (int i = 0; i < arr.Count() - 1; i++)
        {
            int curNum = arr[i];
            int nextNum = arr[i + 1];

            if (nextNum < curNum)
            {

                int numToInsert = nextNum;
                int indexNextNum = i + 1;
                bool isFound = false;
                for (int j = indexNextNum; j > 0; j--)
                {

                    if (numToInsert < arr[j - 1])
                    {
                        arr[j] = arr[j - 1];         
                    }
                    else
                    {
                        arr[j] = numToInsert;
                        isFound = true;
                    }

                    foreach (var item in arr)
                    {
                        Console.Write(item.ToString());
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                    if (isFound) {
                        break;
                    }
                }

                if (!isFound) {
                    arr[0] = numToInsert;
                }
                foreach (var item in arr)
                {
                    Console.Write(item.ToString());
                    Console.Write(" ");
                }
            }          
        }
    }

    static void Main(String[] args)
    {
        //string nString = "10";
        //string array = "2 3 4 5 6 7 8 9 10 1";

        //string nString = "14";
        //string array = "1 3 5 9 13 22 27 35 46 51 55 83 87 23";
        string nString = "5";
        string array = "2 4 6 8 3";

        int n = Convert.ToInt32(nString);
        string[] arr_temp = array.Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        insertionSort1(n, arr);
    }
}