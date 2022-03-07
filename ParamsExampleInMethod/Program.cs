using System;
using System.Collections.Generic;

namespace ParamsExampleInMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyMethod(1, 2, 3, 4, 5);

            string[] arr = Console.ReadLine().Split();

            List<string> longestPalindrome = new List<string>();

            int longestCount = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] == arr[i + 1])
                {
                    longestCount += 2;
                    longestPalindrome = 
                }
            }
        }

        static void MyMethod(params int[] numbers)
        {
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
