using System;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            bool check = LeapYear(year);
            if (check == true)
                Console.WriteLine($"{year} is a leap year.");
            else
                Console.WriteLine($"{year} is NOT a leap year.");

            Console.ReadKey();
        }

        static bool LeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0 && year % 400 != 0)
                    return false;
                return true;
            }
            return false;
        }
    }
}