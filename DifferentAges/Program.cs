using System;

namespace DifferentAges
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            string result = age <= 2 ? "baby" : age <= 19 ? "teenager" : age <= 50 ? "adult" : age > 50 ? "older than fifty" : "older";

            Console.WriteLine(result);
        }
    }
}
