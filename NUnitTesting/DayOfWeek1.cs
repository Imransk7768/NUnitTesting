using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    public class DayOfWeek1
    {
        public void WeekDay()
        {

            Console.Write("Enter month number between 1-12 : ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter day of 1-7 : ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter year in YYYY format : ");
            int year = Convert.ToInt32(Console.ReadLine());
            int y0 = year - (14 - month) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = month + 12 * ((14 - month) / 12) - 2;
            int d0 = (day + x + 31 * m0 / 12) % 7;
            switch (d0)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Thuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thuresday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("No Day Found");
                    break;
            }
        }
    }
}
