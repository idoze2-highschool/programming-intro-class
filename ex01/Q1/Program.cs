using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Side1;
            int Side2;
            int SurfaceArea;
            int Perimeter;

            Console.Write("Enter The First Side Of the Rectangle: ");
            Side1 = int.Parse(Console.ReadLine());
            Console.Write("Enter The Second Side Of the Rectangle: ");
            Side2 = int.Parse(Console.ReadLine());
            SurfaceArea = Side2 * Side1;
            Perimeter = (2 * Side1) + (Side2 * 2);

            Console.WriteLine("The Surface Equals to " + SurfaceArea);
            Console.WriteLine("The Perimeter Equals to " + Perimeter);

            Console.Read();
        }
    }
}
