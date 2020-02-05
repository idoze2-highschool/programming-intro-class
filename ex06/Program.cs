using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            while (1 == 1)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Go To Question (1-9): ");
                Console.ForegroundColor = ConsoleColor.Red;
                int quest = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Cyan;
                if ((quest < 1) || (quest > 9))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Question Number\nPress Enter To Return...");
                    Console.ReadLine();
                    Console.Clear();
                }
                switch (quest)
                {
                    //1
                    case 1:
                        Console.Clear();
                        Console.Write("question number: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(quest);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine();
                        for (int i = 0; i < 7; i++)
                        {
                            Console.WriteLine("Hello");
                        }
                        Console.WriteLine("Press Enter To Continue...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("question number: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(quest);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine();
                        for (int i = 0; i < 6; i++)
                        {
                            Console.Write("Num= ");
                            int q2num = int.Parse(Console.ReadLine());
                            if (q2num < 10)
                                Console.WriteLine("1 digit");
                            else
                                Console.WriteLine("Other");
                        }
                        Console.WriteLine("Press Enter To Continue...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    //3
                    case 3:
                        Console.Clear();
                        Console.Write("question number: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(quest);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine();
                        for (int i = 10; i < 40; i++)
                        {
                            if (i % 2 == 1)
                                Console.WriteLine(i);
                        }
                        Console.WriteLine();
                        for (int i = 60; i < 90; i++)
                        {
                            if (i % 2 == 0)
                                Console.WriteLine(i);
                        };
                        Console.WriteLine("Press Enter To Continue...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    //4
                    case 4:
                        Console.Clear();
                        Console.Write("question number: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(quest);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine();
                        for (int i = 11; i < 39; i += 2)
                        {
                            Console.WriteLine(i);
                        }
                        Console.WriteLine();
                        for (int i = 60; i < 90; i += 2)
                        {
                            Console.WriteLine(i);
                        }
                        Console.WriteLine("Press Enter To Continue...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    //5
                    case 5:
                        Console.Clear();
                        Console.Write("question number: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(quest);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine();
                        Console.Write("times= ");
                        int q5time = int.Parse(Console.ReadLine());
                        for (int i = 0; i < q5time; i++)
                        {
                            Console.Write('*');
                        }
                        Console.WriteLine("Press Enter To Continue...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    //6
                    case 6:
                        Console.Clear();
                        Console.Write("question number: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(quest);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine();
                        Console.Write("Num= ");
                        int q6num = int.Parse(Console.ReadLine());
                        for (int i = 1; i <= q6num; i++)
                        {
                            if (q6num % i == 0)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        Console.WriteLine("Press Enter To Continue...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    //7
                    case 7:
                        Console.Clear();
                        Console.Write("question number: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(quest);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine();
                        int q7count = 0;
                        Console.Write("average= ");
                        int q7avg = int.Parse(Console.ReadLine());
                        for (int i = 0; i < 8; i++)
                        {
                            Console.Write("Grade number {0}:", (i + 1));
                            int q7Grade = int.Parse(Console.ReadLine());
                            if (q7Grade > q7avg)
                                q7count++;
                        }
                        Console.WriteLine(q7count + " Are Bigger");
                        Console.WriteLine(8 - q7count + " Are Smaller or Equal");
                        Console.WriteLine("Press Enter To Continue...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    //8
                    case 8:
                        Console.Clear();
                        Console.Write("question number: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(quest);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine();
                        Console.Write("low= ");
                        int q8low = int.Parse(Console.ReadLine());
                        Console.Write("high= ");
                        int q8high = int.Parse(Console.ReadLine());
                        Console.Write("divider= ");
                        int q8div = int.Parse(Console.ReadLine());
                        for (int i = q8low; i < q8high; i++)
                        {
                            if (i % q8div == 0)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        Console.WriteLine("Press Enter To Continue...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    //9
                    case 9:
                        Console.Clear();
                        Console.Write("question number: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(quest);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine();
                        double q9count = 0;
                        Console.Write("People= ");
                        double q9n = int.Parse(Console.ReadLine());
                        for (int i = 0; i < q9n; i++)
                        {
                            Console.Write("How many tamrors were wrong? ");
                            int q9tamr = int.Parse(Console.ReadLine());
                            Console.Write("How many questions were wrong? ");
                            int q9quest = int.Parse(Console.ReadLine());
                            if ((q9tamr == 0) && (q9quest <= 3))
                                q9count++;
                        }
                        Console.WriteLine((q9count) + " Passed.");
                        Console.WriteLine((q9count / q9n * 100) + "% Passed.");
                        Console.WriteLine("Press Enter To Continue...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        }
    }

}
