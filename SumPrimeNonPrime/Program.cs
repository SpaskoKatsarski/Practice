using System;

namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int totalPrime = 0;
            int totalNonPrime = 0;

            while (input != "stop")
            {
                int currentNumber = int.Parse(input);

                if (currentNumber < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
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
                        totalPrime += currentNumber;
                    }
                    else
                    {
                        totalNonPrime += currentNumber;
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {totalPrime}\nSum of all non prime numbers is: {totalNonPrime}");
        }
    }
}
