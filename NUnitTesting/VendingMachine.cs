using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    public class VendingMachine
    {
        public void Counting()
        {
            int[] notes = { 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
            int[] frequency = new int[notes.Length];
            Console.WriteLine("Enter Amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            for (int index = 0; index < notes.Length; index++)
            {
                if (amount > 0)
                {
                    frequency[index] = amount / notes[index];
                    amount -= frequency[index] * notes[index];
                }
            }
            for (int index = 0; index < frequency.Length; index++)
            {
                if (frequency[index] != 0)
                {
                    Console.WriteLine(notes[index] + "   " + frequency[index]);
                }
            }
        }
    }
}
