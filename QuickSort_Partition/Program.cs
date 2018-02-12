using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    // https://www.hackerrank.com/challenges/quicksort1/problem
    static int[] quickSort(int[] arr)
    {
        // Complete this function
        List<int> left = new List<int>();
        List<int> right = new List<int>();
        List<int> same = new List<int>();
        List<int> finalList = new List<int>();
        int[] finalArray;

        if (arr.Length == 1)
        {
            return arr;
        }
        else
        {
            int pivot = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < pivot)
                {
                    left.Add(arr[i]);
                }
                else if (arr[i] == pivot)
                {
                    same.Add(arr[i]);
                }
                else
                {
                    right.Add(arr[i]);
                }
            }

            if (left.Count > 0)
            {
                int[] sortedLeft = quickSort(left.ToArray());
                printArray("left", sortedLeft);

            }
            if (right.Count > 0)
            {
                int[] sortedRight = quickSort(right.ToArray());
                printArray("right", sortedRight);
            }

            finalList.AddRange(left);
            finalList.AddRange(same);
            finalList.AddRange(right);

            finalArray = finalList.ToArray();
            Console.WriteLine("Final List", finalArray);
        }
        return finalArray;
    }

    static void printArray(string test, int[] array)
    {
        Console.WriteLine(test);
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }

    static void Main(String[] args)
    {
        string nString = "6";
        string array = "4 5 3 7 2";

        int n = Convert.ToInt32(nString);
        string[] arr_temp = array.Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        int[] result = quickSort(arr);
        Console.WriteLine(String.Join(" ", result));
    }
}

