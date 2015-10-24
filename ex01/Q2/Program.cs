using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double Tf;
            double Tc;

            Console.Write("Enter the temperature in Fahrenheit: ");
            Tf = double.Parse(Console.ReadLine());
            Tc = ((Tf - 32) * 5) / 9;

            Console.WriteLine("The Temperature in Celcius Is " + Tc + " Degrees.");
            Console.Read();
        }
    }
}
