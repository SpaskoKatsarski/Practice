﻿using System;

namespace ShowingStuffToFriend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User, please enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("User, please enter your age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"{name}, what's your grade?");
            double studentGrade = double.Parse(Console.ReadLine());

            Console.WriteLine($"You are {name}, {age} age years old and your grade is {studentGrade:f2}");
        }
    }
}
