using System;
using System.Linq;

namespace PasswordBackwards
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = new string(username.ToCharArray().Reverse().ToArray());

            string input = Console.ReadLine();

            int count = 0;

            while (input != password)
            {
                count++;

                if (count == 4)
                {
                    Console.WriteLine("User blocked!");
                    return;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Hello {username}!");

        }
    }
}
