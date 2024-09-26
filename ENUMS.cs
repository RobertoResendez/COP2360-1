using System;

namespace EnumExample
{
    // Define an enum to represent the days of the week
    enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a variable of the enum type and assign a value to it
            DaysOfWeek today = DaysOfWeek.Friday;

            // Output the enum value
            Console.WriteLine("Today is: " + today);

            // You can also cast the enum to an integer
            int dayNumber = (int)today;
            Console.WriteLine("Today is day number: " + dayNumber);

            // Example of using a switch statement with enums
            switch (today)
            {
                case DaysOfWeek.Monday:
                    Console.WriteLine("Start of the work week!");
                    break;
                case DaysOfWeek.Friday:
                    Console.WriteLine("Almost the weekend!");
                    break;
                case DaysOfWeek.Saturday:
                case DaysOfWeek.Sunday:
                    Console.WriteLine("It's the weekend!");
                    break;
                default:
                    Console.WriteLine("It's a regular workday.");
                    break;
            }
        }
    }
}