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
            //3//
            Console.Write("Enter number Between 0-9: ");
            int q2num = int.Parse(Console.ReadLine());
            switch (q2num)
            {
                case 0:
                    Console.WriteLine("The number is zero!");
                    break;
                case 1:
                    Console.WriteLine("The number is one!");
                    break;
                case 2:
                    Console.WriteLine("The number is two!");
                    break;
                case 3:
                    Console.WriteLine("The number is three!");
                    break;
                case 4:
                    Console.WriteLine("The number is four!");
                    break;
                case 5:
                    Console.WriteLine("The number is five!");
                    break;
                case 6:
                    Console.WriteLine("The number is six!");
                    break;
                case 7:
                    Console.WriteLine("The number is seven!");
                    break;
                case 8:
                    Console.WriteLine("The number is eight!");
                    break;
                case 9:
                    Console.WriteLine("The number is nine!");
                    break;
            }
            //4//
            Console.Write("Enter 1st number: ");
            int q3num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd number: ");
            int q3num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Char (+ - * /): ");
            char q3char = char.Parse(Console.ReadLine());
            switch (q3char)
            {
                case '+':
                    Console.WriteLine(q3num1 + q3num2);
                    break;
                case '-':
                    Console.WriteLine(q3num1 - q3num2);
                    break;
                case '*':
                    Console.WriteLine(q3num1 * q3num2);
                    break;
                case '/':
                    Console.WriteLine(q3num1 / q3num2);
                    break;
            }
            //5//
            Console.Write("Enter Number Of Hours: ");
            int q5hours = int.Parse(Console.ReadLine());
            Console.Write("Enter Grade: ");
            char q5lv = char.Parse(Console.ReadLine());
            switch (q5lv)
            {
                case 'A':
                Console.WriteLine(q5hours * 100 );
                break;
                case 'B':
                Console.WriteLine(q5hours * 80);
                break;
                case 'C':
                Console.WriteLine(q5hours * 50);
                break;
                case 'D':
                Console.WriteLine(q5hours * 20);
                break;
            }
            //6//
            Console.WriteLine("Enter Day in the Month:");
            int q6MonthDay = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Month:");
            int q6month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Year (2 numbers like 09-2009 11-2011):");
            int q6year = int.Parse(Console.ReadLine());
                switch (q6month)
                {
                    case 1:
                    Console.WriteLine("Jan, "+(2000+q6year)+", "+q6MonthDay);
                    break;
                    case 2:
                    Console.WriteLine("Feb, "+(2000+q6year)+", "+q6MonthDay);
                    break;
                    case 3:
                    Console.WriteLine("Mar, " + (2000 + q6year) + ", " + q6MonthDay);
                    break;
                    case 4:
                    Console.WriteLine("Apr, " + (2000 + q6year) + ", " + q6MonthDay);
                    break;
                    case 5:
                    Console.WriteLine("May, " + (2000 + q6year) + ", " + q6MonthDay);
                    break;
                    case 6:
                    Console.WriteLine("July, " + (2000 + q6year) + ", " + q6MonthDay);
                    break;
                    case 7:
                    Console.WriteLine("June, " + (2000 + q6year) + ", " + q6MonthDay);
                    break;
                    case 8:
                    Console.WriteLine("Aug, " + (2000 + q6year) + ", " + q6MonthDay);
                    break;
                    case 9:
                    Console.WriteLine("Sept, " + (2000 + q6year) + ", " + q6MonthDay);
                    break;
                    case 10:
                    Console.WriteLine("Oct, " + (2000 + q6year) + ", " + q6MonthDay);
                    break;
                    case 11:
                    Console.WriteLine("Nov, " + (2000 + q6year) + ", " + q6MonthDay);
                    break;
                    case 12:
                    Console.WriteLine("Dec, " + (2000 + q6year) + ", " + q6MonthDay);
                    break;
                }
            //7//
            Console.Write("Enter Capital Letter: ");
            char q7let = char.Parse(Console.ReadLine());
            switch (q7let)
            { 
                    case 'A':
                    Console.WriteLine("a");
                    break;
                    case 'B':
                    Console.WriteLine("b");
                    break;
                    case 'C':
                    Console.WriteLine("c");
                    break;
                    case 'D':
                    Console.WriteLine("d");
                    break;
                    case 'E':
                    Console.WriteLine("e");
                    break;
                    case 'F':
                    Console.WriteLine("f");
                    break;
                    case 'G':
                    Console.WriteLine("g");
                    break;
                    case 'H':
                    Console.WriteLine("h");
                    break;
                    case 'I':
                    Console.WriteLine("i");
                    break;
                    case 'J':
                    Console.WriteLine("j");
                    break;
                    case 'K':
                    Console.WriteLine("k");
                    break;
                    case 'L':
                    Console.WriteLine("l");
                    break;
                    case 'M':
                    Console.WriteLine("m");
                    break;
                    case 'N':
                    Console.WriteLine("n");
                    break;
                    case 'O':
                    Console.WriteLine("o");
                    break;
                    case 'P':
                    Console.WriteLine("p");
                    break;
                    case 'Q':
                    Console.WriteLine("q");
                    break;
                    case 'R':
                    Console.WriteLine("r");
                    break;
                    case 'S':
                    Console.WriteLine("s");
                    break;
                    case 'T':
                    Console.WriteLine("t");
                    break;
                    case 'U':
                    Console.WriteLine("u");
                    break;
                    case 'V':
                    Console.WriteLine("v");
                    break;
                    case 'W':
                    Console.WriteLine("w");
                    break;
                    case 'X':
                    Console.WriteLine("x");
                    break;
                    case 'Y':
                    Console.WriteLine("y");
                    break;
                    case 'Z':
                    Console.WriteLine("z");
                    break;

            }
            //8//
            char q8tav2;
            Console.Write("Enter Letter: ");
            char q8tav = char.Parse(Console.ReadLine());
            q8tav2 =(char) (q8tav+1);
            Console.WriteLine(q8tav2);
            Console.Read();

        }
    }
}
