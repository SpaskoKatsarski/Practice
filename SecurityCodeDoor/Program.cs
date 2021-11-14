using System;

namespace SecurityCodeDoor
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            int visitedDestinations = 0;

            while (destination.ToLower() != "stop")
            {
                double neededMoney = int.Parse(Console.ReadLine());
                int daysToSaveMoney = int.Parse(Console.ReadLine());
                bool hasTheMoney = false;
                double sum = 0;

                for (int i = 0; i < daysToSaveMoney; i++)
                {
                    sum += double.Parse(Console.ReadLine());
                    if (sum >= neededMoney)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        hasTheMoney = true;
                        visitedDestinations++;
                        break;
                    }
                }
                if (!hasTheMoney)
                {
                    double difference = neededMoney - sum;
                    Console.WriteLine($"You needed {difference} more leva to visit {destination}.");         
                }
                destination = Console.ReadLine();
            }
            Console.WriteLine($"You have visited {visitedDestinations} destinations!");
        }
    }
}
