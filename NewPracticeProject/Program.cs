using System;
using System.Collections.Generic;

namespace NewPracticeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> newList = new List<string>();

            string input = Console.ReadLine();
            int counter = 0;

            while (input.ToLower() != "Stop")
            {
                newList.Add(input);

                if (newList.Contains(String.Empty))
                {
                    break;
                }
                counter++;

                Console.WriteLine($"Current loop number: {counter}.\nNew input:");

                input = Console.ReadLine();
            }
            Console.WriteLine("Good practice!");

        }
    }
}
