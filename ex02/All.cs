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
            //Start//
            Console.Write("Enter Name: ");
            string q1name = Console.ReadLine();
            Console.Write("Enter Grade: ");
            int q1grade = int.Parse(Console.ReadLine());
            if (q1grade > 55)
            {
                Console.WriteLine("{0} Passed", q1name);
            }
            else
            {
                Console.WriteLine("{0} Failed", q1name);
            }
            //End//
            Console.WriteLine();
            //Start//
            Console.Write("Enter 1st Number: ");
            int q2num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd Number: ");
            int q2num2 = int.Parse(Console.ReadLine());
            if (q2num1 > q2num2)
            {
                Console.WriteLine(q2num1 + " Is bigger. You can stop looking now.");
            }
            else
            {
                Console.WriteLine(q2num2 + " Is Bigger Than/Equal to "+q2num1+". You can stop looking now.");
            }
            //End//
            Console.WriteLine();
            //Start//
            Console.Write("Enter 1st Grade: ");
            int q3grade1 = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd Grade: ");
            int q3grade2 = int.Parse(Console.ReadLine());
            if ((q3grade2 - q3grade1) >= 5) {
            Console.WriteLine("The Student Advanced");
            }
            //End//
            Console.WriteLine();
            //Start//
            Console.Write("Enter Your ID Number (9 Digits): ");
            int q4ID = int.Parse(Console.ReadLine());
            int q4lastnum = q4ID % 10;
            if (q4lastnum == 3)
            {
                Console.WriteLine("You Got 10,000 Shekels Grant! ");
            }
            else
            {
                Console.WriteLine("Never Mind. Good Day!");
            }
            //End//
            Console.WriteLine();
            //Start//
            Console.WriteLine("1. What Is The Opposit Of Yes?");
            string q5a1 = Console.ReadLine();
            int q5a1b;
            if (q5a1 == "No") 
            {
                Console.WriteLine("You Are Correct!");
                q5a1b = 1;
            }
            else
            {
                Console.WriteLine("You Are Wrong!");
                 q5a1b = 0;
            }
            Console.Write("2. 10-4= ");
            int q5a2 = int.Parse(Console.ReadLine());
            if (q5a2 == 6)
            {
                Console.WriteLine("You Are Correct!");
                q5a2 = 1;
            }
            else
            {
                Console.WriteLine("You Are Wrong!");
                q5a2 = 0;
            }
            Console.Write("3. 4^2= ");
            int q5a3 = int.Parse(Console.ReadLine());
            if (q5a3 == 16)
            {
                Console.WriteLine("You Are Correct!");
                q5a3 = 1;
            }
            else
            {
                Console.WriteLine("You Are Wrong!");
                q5a3 = 0;
            }
            int q5right = q5a1b + q5a2 + q5a3;
            int q5wrong = 3 - q5right;
            if (q5wrong == 0)
            {
                Console.WriteLine("You Answered Perfectly!");
            }
            else
            {
                Console.WriteLine("You Answered {0} Right!",q5right);
                Console.WriteLine("You Answered {0} Wrong.",q5wrong);
            }
            //End//
            Console.WriteLine();
            //Start//
            Console.WriteLine("enter 3 digit number");
            int Q6NUM111 = int.Parse(Console.ReadLine());
            int Q6NUM100 = Q6NUM111 / 100;
            int Q6NUM1 = Q6NUM111 % 10;
            if (Q6NUM100 == Q6NUM1)
            {
                Console.WriteLine("Palindromic!");
            }
            else
            {
                Console.WriteLine("Not Palindromic.");
            }
            //End//
            Console.WriteLine();
            //Start//
            Console.WriteLine("Enter Number");
            int Q7NUM = int.Parse(Console.ReadLine());
            int Q7NUM1 = Q7NUM % 10;
            if (Q7NUM1 == 0)
            {
                Console.WriteLine("Even");
            }
            if (Q7NUM1 == 2)
            {
                Console.WriteLine("Even");
            }
            if (Q7NUM1 == 4)
            {
                Console.WriteLine("Even");
            }
            if (Q7NUM1 == 6)
            {
                Console.WriteLine("Even");
            }
            if (Q7NUM1 == 8)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Not Even");
            }
            //End//
            Console.WriteLine();
            //Start//
            Console.WriteLine("Enter Number (Positive/Negative)");
            int Q8NUM = int.Parse(Console.ReadLine());
            int Q8NUMF;
            if (0 > Q8NUM)
            {
                Q8NUMF = -1 * Q8NUM;
            }
            else
            {
                Q8NUMF = Q8NUM;
            }
            Console.WriteLine(Q8NUMF);
            //End//
            Console.WriteLine("Enter Time In the following Format: HHMM (H=Hours,M=Minutes)");
            int Q9HHMM = int.Parse(Console.ReadLine());
            int Q9HH = Q9HHMM / 100;
            int Q9MM = Q9HHMM % 100;
            int Q9HHF = Q9HH - 12;
            string noon;
            if (Q9HH >= 12)
            {
                noon = "pm";
            }
            else
            {
                noon = "am";
            }
            Console.WriteLine(Q9HHF+":"+Q9MM+""+noon);
            Console.Read();
            //Start//

        }
    }
}
