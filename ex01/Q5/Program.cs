using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Amount Of Nails:");
            int nails = int.Parse(Console.ReadLine());
            int Boxes = nails / 50;
            int Left = nails % 50;
            Console.WriteLine("For {0} Nails, you need to order {1} Boxes, and there will be {2} Leftover.", nails, Boxes, Left);
            Console.Read();
        }
    }
}
