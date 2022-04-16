using System;
using NUnitTesting;

namespace NUnitTesting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(">>>>>>> Welcome to NUnit Logical Programs <<<<<<<");
            bool end = true;
            Console.WriteLine("1. Vending Machine\n2. Day Of Week\n3. Temperature\n4. End Of The Program");
            while (end == true)
            {
                Console.WriteLine("\nEnter an Option to Exicute.");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        VendingMachine machine = new VendingMachine();
                        machine.Counting();
                        break;
                    case 2:
                        DayOfWeek1 day = new DayOfWeek1();
                        day.WeekDay();
                        break;
                    case 3:
                        Temperature tem = new Temperature();
                        tem.celsiusToFehrenheit();
                        tem.fehrenheitToCelsius();
                        break;
                    case 4:
                        end = false;
                        Console.WriteLine("Program Is Ended.");
                        break;
                    default:
                        Console.WriteLine("Enter the Valid Option");
                        break;
                }
            }
        }

    }
}