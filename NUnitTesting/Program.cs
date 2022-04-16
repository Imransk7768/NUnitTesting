﻿using System;
using NUnitTesting;

namespace NUnitTesting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(">>>>>>> Welcome to Logical Programs <<<<<<<");
            bool end = true;
            Console.WriteLine("1. Vending Machine\n2. End Of The Program");
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