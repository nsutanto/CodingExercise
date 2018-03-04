using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //WordPattern test = new WordPattern();
            //test.TestWordPattern("abba", "dog dog dog dog");

            IsAnagram test = new IsAnagram();
            test.TestIsAnagram("ab", "ba");

        }
    }
}
