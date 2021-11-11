using System;

namespace SumEvenAndOddNums
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int sumOddNums = 0;
            int sumEvenNums = 0;

            while (input != "Stop")
            {
                int currentNumber = int.Parse(input);
                int counter = 0;
                for (int i = 1; i <= currentNumber; i++)
                {
                    if (currentNumber % i == 0)
                    {
                        counter++;
                    }
                }
                if (counter == 2)
                {
                    sumEvenNums += currentNumber;
                }
                else
                {
                    sumOddNums += currentNumber;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Odd sum: {sumOddNums}\nEven Sum: {sumEvenNums}");
        }
    }
}
