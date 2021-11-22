using System;
using System.Collections.Generic;

namespace RandomPresentGifterSelector
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            for (int i = 1; i < 28; i++)
            {
                Console.WriteLine("Please enter a number:");

                int input = int.Parse(Console.ReadLine());
                Random rnd = new Random();

                int number1 = rnd.Next(1, 27);

                if (list) // Make that so if a number from the randoms has been already used, the loop breaks and generates another number.
                {
                    break;
                }

                Console.WriteLine($"Number {input} will gift a present to number {number1}");

                list.Add(number1);
            }
        }
    }
}
