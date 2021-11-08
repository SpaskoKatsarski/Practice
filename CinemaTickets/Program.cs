using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string film = Console.ReadLine();

            int totalStudent = 0;
            int totalStandard = 0;
            int totalKid = 0;
            int totalTickets = 0;

            while (film != "Finish")
            {
                int freePlaces = int.Parse(Console.ReadLine());
                int totalTicketsForCurrentProjection = 0;
                for (int i = 0; i < freePlaces; i++)
                {
                    string ticketType = Console.ReadLine();
                    if (ticketType == "End")
                    {
                        break;
                    }
                    if (ticketType == "student")
                    {
                        totalStudent++;
                    }
                    else if (ticketType == "standard")
                    {
                        totalStandard++;
                    }
                    else
                    {
                        totalKid++;
                    }
                    totalTicketsForCurrentProjection++;
                    totalTickets++;
                }
                double fullynessPercent = (double)totalTicketsForCurrentProjection / freePlaces * 100;
                Console.WriteLine($"{film} - {fullynessPercent:f2}% full.");

                film = Console.ReadLine();
            }
            double percentageStudent = (double)totalStudent / totalTickets * 100;
            double percentageStandard = (double)totalStandard / totalTickets * 100;
            double percentageKid = (double)totalKid / totalTickets * 100;
            Console.WriteLine($"Total tickets: {totalTickets}\n{percentageStudent:f2}% student tickets.\n{percentageStandard:f2}% standard tickets.\n{percentageKid:f2}% kids tickets.");
        }
    }
}
