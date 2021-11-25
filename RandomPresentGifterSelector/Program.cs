using System;
using System.Collections.Generic;
namespace RandomPresentGifterSelector
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Random rnd = new Random();

            bool flag = false;

            for (int i = 1; i < 28; i++)
            {
                if (!flag)
                {
                    Console.WriteLine("Please enter a number:");
                }
                else
                {
                    Console.WriteLine("Try again:");
                }

                flag = false;

                string input = Console.ReadLine();

                if (input.ToLower() == "end")
                {
                    Console.WriteLine("That was all. Thanks for participating!");
                    return;
                }
                if (input.ToLower() == "skip")
                {
                    continue;
                }

                int currentNum = int.Parse(input);

                int number1 = rnd.Next(1, 27);

                if (list.Contains(number1) || number1 == currentNum)
                {
                    flag = true;
                    i -= 1;
                    continue;
                }

                Console.WriteLine($"Number {currentNum} will gift a present to number {number1}");

                list.Add(number1);
            }
        }
    }
}
