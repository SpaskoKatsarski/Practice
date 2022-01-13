using System;

namespace MultiplyingTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (b > 9)
            {
                Console.WriteLine($"{a} * {b} = {a * b}");
            }
            else
            {
                for (int i = b; i <= 10; i++)
                {
                    Console.WriteLine($"{a} * {i} = {a * i}");
                }
            }
        }
    }
}
