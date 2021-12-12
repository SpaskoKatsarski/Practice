using System;

namespace FactorialNumbersSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int temporaryNumber = number;
            int factorialSum = 9;

            while (temporaryNumber > 0)
            {
                int currentNumber = temporaryNumber % 10;
                temporaryNumber /= 10;
                int currentFactNum = 1;

                for (int i = 1; i <= currentFactNum; i++)
                {
                    currentFactNum *= i;
                }
                factorialSum += currentFactNum;
            }
            if (factorialSum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
