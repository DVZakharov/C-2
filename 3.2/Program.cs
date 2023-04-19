using System;

namespace _3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год");
            int year = Convert.ToInt32(Console.ReadLine());
            int days;
            for (int month = 1; month < 13; month++)
            {
                bool flag = false;
                if ((month == 4) || (month == 6) || (month == 9) || (month == 11))
                {
                    days = 30;
                    flag = true;
                    DateOnly date = new DateOnly(year, month, days);
                    DayOfWeek day = date.DayOfWeek;
                    Console.WriteLine($"{ThursdayCheck(day,days)}/{month}/{year} последний четверг месяца"); 

                }
                if (!flag && month != 2)
                {
                    days = 31;
                    DateOnly date = new DateOnly(year, month, days);
                    DayOfWeek day = date.DayOfWeek;
                    Console.WriteLine($"{ThursdayCheck(day,days)}/{month}/{year} последний четверг месяца");
                }
                if (month == 2)
                {
                    if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                        days = 29;
                    else days = 28;
                    DateOnly date = new DateOnly(year, month, days);
                    DayOfWeek day = date.DayOfWeek;
                    Console.WriteLine($"{ThursdayCheck(day,days)}/{month}/{year} последний четверг месяца");
                }
            }

        }

        private static int ThursdayCheck(DayOfWeek day, int d)
        {
            switch (day) 
            {
                case DayOfWeek.Monday: return d - 4;
                case DayOfWeek.Tuesday: return d - 5;
                case DayOfWeek.Wednesday: return d - 6;
                case DayOfWeek.Thursday: return d;
                case DayOfWeek.Friday: return d - 1;
                case DayOfWeek.Saturday: return d - 2;
                case DayOfWeek.Sunday: return d - 3;
                default: return d;
            }
        }
    }
}