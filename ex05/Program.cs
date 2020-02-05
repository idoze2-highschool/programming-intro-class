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
            //1
            Console.WriteLine("Enter length: ");
            int q1len = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Width: ");
            int q1wid = int.Parse(Console.ReadLine());
            Console.WriteLine("Area ={0}", (q1len * q1wid));
            Console.WriteLine("Diagonal ={0}", Math.Sqrt(Math.Pow(q1len,2) + Math.Pow(q1wid,2)));

            Console.ReadLine();
            //2
            Console.Write("Radius= ");
            int q2rad = int.Parse(Console.ReadLine());
            Console.WriteLine("A. Diameter = {0}", (q2rad * 2));
            Console.WriteLine("B. Perimeter = {0}", (2 * q2rad * Math.PI));
            Console.WriteLine("C. Area = {0}", (Math.PI * Math.Pow(q2rad,2)));

            Console.ReadLine();
            //3
            Random q3 = new Random();
            int q3num1 = q3.Next(20, 40);
            Console.WriteLine(q3num1);
            int q3num2 = q3.Next(20, 40);
            Console.WriteLine(q3num2);
            int q3num3 = q3.Next(20, 40);
            Console.WriteLine(q3num3);
            Console.WriteLine("{0} Is the biggest", Math.Max(Math.Max(q3num1,q3num2),q3num3) );
            
            Console.ReadLine();
            //4
            Console.Write("1st student's Height= ");
            int q4h1 = int.Parse(Console.ReadLine());
            Console.Write("2nd student's Height= ");
            int q4h2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Abs(q4h1 - q4h2));
            Console.WriteLine(Math.Min(q4h1,q4h2));



            Console.ReadLine();
            //5
            Random q5 = new Random();
            int q5num1 = q3.Next(10, 99);
            Console.WriteLine(q5num1);
            int q5num2 = q3.Next(10, 99);
            Console.WriteLine(q5num2);
            int q5num3 = q3.Next(10, 99);
            Console.WriteLine(q5num3);
            Console.WriteLine("A. {0} is the biggest", Math.Max(Math.Max(q5num1, q5num2), q5num3));
            if ((Math.Round(Math.Sqrt(q5num1)) == Math.Round(Math.Sqrt(q5num2))) || (Math.Round(Math.Sqrt(q5num1)) == Math.Round(Math.Sqrt(q5num3))) || (Math.Round(Math.Sqrt(q5num3)) == Math.Round(Math.Sqrt(q5num2))) )
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
             


            Console.Read();      
        }
    }
}
