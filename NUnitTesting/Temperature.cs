using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    public class Temperature
    {
        public void celsiusToFehrenheit()
        {
            float f;
            Console.Write("Enter the temperature in Celcius : ");
            int c = Convert.ToInt32(Console.ReadLine());
            f = (c * 9 / 5) + 32;
            Console.WriteLine("Temperature in Celsius to Fahrenheit Is :" + f);
        }
        public void fehrenheitToCelsius()
        {
            float c, t;
            Console.Write("\nEnter the temperature in Fahrenheit Is : ");
            int f = Convert.ToInt32(Console.ReadLine());
            t = (f - 32) * 5;
            c = t / 9;
            Console.WriteLine("\nTemperature in Celsius To Fahrenheit Is :" + c);
        }
    }
}
