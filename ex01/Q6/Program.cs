using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 3 digit number:");
            int Number = int.Parse(Console.ReadLine());
            int A100s100 = Number - (Number % 100);
            int A100s1 = A100s100 / 100;
            int A10s10 = Number - A100s100 - (Number % 10);
            int A10s1 = A10s10 / 10;
            int A1s1 = Number - A100s100 - A10s10;
            int A1s100 = A1s1 * 100;
            int A123s321 = A1s100 + A10s10 + A100s1;
            Console.WriteLine("A. {0}+{1}+{2}={3}", A100s1, A10s1, A1s1, A100s1 + A10s1 + A1s1);
            Console.WriteLine("B. {0}+{1}+{2}={3}", A100s100, A10s10, A1s1, Number);
            Console.WriteLine("C. "+A123s321);
            Console.Read();


        }
    }
}
