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
            int quest = 1;
            while (quest > 0)
            {
                Console.Clear();
                Console.Write("Go to Question: ");
                quest = int.Parse(Console.ReadLine());
                switch (quest)
                {
                    case 1:
                        Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                        //
                        Console.Write("How Much Is 4-2? ");
                        int q1ans = int.Parse(Console.ReadLine());
                        while (q1ans != 2)
                        {
                            Console.WriteLine("Wrong!");
                            Console.Write("How Much Is 4-2? ");
                            q1ans = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("Right!");
                        //
                        Console.ReadLine(); break;
                    case 2:
                        Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                        //
                        int q2grade = 0, q2avg, q2count = 1;
                        Console.Write("Enter Grade: ");
                        q2grade = int.Parse(Console.ReadLine());
                        q2avg = q2grade;
                        while (q2grade != 123)
                        {
                            Console.Write("Enter Grade: ");
                            q2grade = int.Parse(Console.ReadLine());
                            if (q2grade <= 100)
                            {
                                q2avg += q2grade;
                                q2count++;
                            }
                        }
                        Console.Write("The average is: " + (q2avg / q2count));
                        //
                        Console.ReadLine(); break;
                    case 3:
                        Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                        //
                        Console.Write("Enter Time: ");
                        double q3time = double.Parse(Console.ReadLine());
                        double q3win = q3time;
                        while (q3time >= 0)
                        {
                            Console.Write("Enter Time: ");
                            q3time = double.Parse(Console.ReadLine());
                            if (q3time >= 0)
                            {
                                q3win = Math.Min(q3win, q3time);
                            }
                        }
                        Console.Write("The winner had the time of {0}.", q3win);
                        //
                        Console.ReadLine(); break;
                    case 4:
                        Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                        //
                        int dist, ndist, count = 1;
                        Console.Write("How much did he push this step (1-20)? ");
                        ndist = int.Parse(Console.ReadLine());
                        dist = ndist;
                        while (dist < 50)
                        {
                            Console.WriteLine("You Moved {0}/50 on {1} steps.", dist, count);
                            Console.Write("How much did he push this step (1-20)? ");
                            ndist = int.Parse(Console.ReadLine());
                            if ((ndist > 0) && (ndist < 21))
                            {
                                dist += ndist;
                                count++;
                            }
                        }
                        Console.WriteLine("You Moved {0}/50 on {1} steps. You Passed 50 By {2}", dist, count, (dist - 50));
                        //
                        Console.ReadLine(); break;
                    case 5:
                        Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                        //
                        int grade, lgrade = 0, lgrademax = 0, lgrademin = 100, lgradesum = 0;
                        Console.Write("Enter Grade: ");
                        grade = int.Parse(Console.ReadLine());
                        if ((grade >= 60) && (grade <= 100))
                        {
                            lgradesum = grade;
                            lgrademin = grade;
                            lgrademax = grade;
                            lgrade++;
                        }
                        while (grade >= 0)
                        {
                            Console.Write("Enter Grade: ");
                            grade = int.Parse(Console.ReadLine());
                            if ((grade >= 60) && (grade <= 100))
                            {
                                lgradesum += grade;
                                lgrademin = Math.Min(lgrademin, grade);
                                lgrademax = Math.Max(lgrademax, grade); ;
                                lgrade++;
                            }
                        }
                        Console.WriteLine("Number of valids {0} ,Average is {1}, Highest valid {2}, Lowest valid {3}", lgrade, (lgradesum / lgrade), lgrademax, lgrademin);
                        //
                        Console.ReadLine(); break;
                    case 6:
                        Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                        //
                        uint n;
                        int digs = 0;
                        Console.Write("Enter num:");
                        n = uint.Parse(Console.ReadLine());
                        while (n != 0)
                        {
                            digs++;
                            n = n / 10;
                        }
                        Console.WriteLine("Number of digits is digs {0}", digs);
                        //
                        Console.ReadLine(); break;
                    case 7:
                        Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                        //
                        int n7,digs7 = 0;
                        double n7n, n7count = 0;
                        Console.Write("Enter num:");
                        n7 = int.Parse(Console.ReadLine());
                        int n7t = n7;
                        while (n7t != 0)
                        {
                            digs7++;
                            n7t = n7t / 10;
                        }
                        for (int i = 1; i < digs7+1;i++)
                        {
                            n7n =(n7 % 10 )* Math.Pow(10,digs7 - i);
                            n7count += n7n;
                            n7 = n7 / 10;
                        }

                        Console.WriteLine(n7count);
                        //
                        Console.ReadLine(); break;
                }
            }
        }
    }
}
