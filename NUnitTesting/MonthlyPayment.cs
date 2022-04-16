using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    public class MonthlyPayment
    {
        public void Payment()
        {
            Console.WriteLine("Enter your Payment : ");
            double pay = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Number of Year : ");
            double year = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter rate of Interest : ");
            double rate = Convert.ToDouble(Console.ReadLine());
            double num = 12 * year, r = rate / (12 * 100);
            double payment = 0;
            payment = (float)(pay * r / 1 - Math.Pow((1 + r), (-num)));
            Console.WriteLine(payment);
        }
    }
}
