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

        //Ayn depqi hamar erb taretivy usern e mutqagrum 
        static void func(int year)
        {
            if (year % 4 == 0)
            {
                for (int i = 1; i <= 20; i++)
                {
                    Console.WriteLine(year);
                    year += 4;
                }
            }
            if (year % 4 == 1)
            {
                year = year + 3;
                for (int i = 1; i <= 20; i++)
                {
                    Console.WriteLine(year);
                    year += 4;
                }
            }

            if (year % 4 == 2)
            {
                year = year + 2;
                for (int i = 1; i <= 20; i++)
                {
                    Console.WriteLine(year);
                    year += 4;
                }
            }

            if (year % 4 == 3)
            {
                year = year + 1;
                for (int i = 1; i <= 20; i++)
                {
                    Console.WriteLine(year);
                    year += 4;
                }
            }

        }

        static void Main(string[] args)
        {
            f();
            /*Console.WriteLine("Enter a year please:");
            int year = int.Parse(Console.ReadLine());
            func(year);*/
        }
    }
}
