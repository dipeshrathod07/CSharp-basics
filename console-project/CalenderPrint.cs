using System;
using System.IO;

namespace Csharp
{
    class CalenderPrint
    {
        public static void Display()
        {
        Console.Write("Enter month (1-12): ");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nCalendar for {month}/{year}");
        CalenderDisplay(month, year);
        }


        public static void CalenderDisplay(int month,int year)
        {
            string[] days = {"Sun","Mon","Tue","Wed","Thrus","Fri","Sat"};

            foreach(string day in days)
            {
                Console.Write(day + " ");
            }
            Console.WriteLine();
            
            int daysInMonth = DateTime.DaysInMonth(year,month);

           
            DateTime dt = new DateTime(year, month, 1);     
            int startDay = (int)dt.DayOfWeek;

            for(int i = 0; i < startDay ; i++)
            {
               Console.Write("    ");

            }

            for(int day = 1 ; day <= daysInMonth ; day++)
            {
                Console.Write(day.ToString().PadLeft(3) + " ");

                if((startDay+day)%7 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine(" ");

        }

    }
}

