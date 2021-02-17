using System;

namespace ACA_Homework_1_2
{
    class Program
    {
        static void f()
        {
            int result = 2024;
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(result);
                result += 4;
            }
        }

        static void PrintLeapYears(int year)
        {
            if (year % 4 != 0)
            {
                year += 4 - (year % 4);
            }
            for (int i = 1; i <= 20; i++)
            {
                if (year % 100 == 0 && year % 400 != 0)
                {
                    i--;
                    year += 4;
                    continue;
                }
                Console.WriteLine(year);
                year += 4;
            }
        }

        static void Main(string[] args)
        {
            //  f();
            Console.WriteLine("Enter a year please:");
            int year = int.Parse(Console.ReadLine());
            PrintLeapYears(year);
        }
    }
}
