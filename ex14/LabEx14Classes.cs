using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEx14
{
    class MyMath
    {
        public static double MyMax(double num1, double num2)
        {

            if (num1 > num2)
                return num1;
            else
                return num2;
        }
        public static bool IsPrime(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }
                return true;
        }
    }
    class DrawShape
    {
        public static void DrawRectangle(int length,int height)
        {
            for (int i = 0; i < height; i++)
            {
                for (int k = 0; k < length; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void DrawSquare(int length)
        {
            Console.WriteLine();
            for (int i = 0; i < length; i++)
            {
                for (int k = 0; k < length; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
