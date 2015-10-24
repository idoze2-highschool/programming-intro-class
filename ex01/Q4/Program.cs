using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Minutes:");
            int min = int.Parse(Console.ReadLine());
            int hour = min / 60;
            Console.WriteLine("The Number In Hours Is {0} and {1} Minutes.", hour, (min - hour * 60));
            Console.Read();
        }
    }
}
