using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    public class SquareRoot
    {
        public void Sqaure()
        {
            Console.WriteLine("Enter the Positive Number");
            int num = Convert.ToInt32(Console.ReadLine());
            double root = Math.Sqrt(num);
            Console.WriteLine("Square root of the " + num + " number is: " + Root);
        }
    }
}
