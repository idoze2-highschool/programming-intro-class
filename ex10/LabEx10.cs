using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication10
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
                        int count1 = 0, grade = 0, total = 0, count90 = 0, avg1;
                        for (int i = 0; i < 4; i++)
                        {
                            grade = 0; total = 0; count1 = 0;
                            while (grade != -999)
                            {
                                Console.Write("Enter Grade Or -999 To finish: ");
                                grade = int.Parse(Console.ReadLine());
                                if (grade != -999)
                                {
                                    total += grade;
                                    count1++;
                                }
                            }
                            avg1 = total / count1;
                            Console.Write("The average of grades is " + avg1);
                            if (avg1 >= 90)
                            {
                                count90++;
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("Number Of Students who passed over 90 is: " + count90);
                        //
                        Console.ReadLine(); break;
                    case 2:
                        Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                        //
                        int num12 = 0, num22 = 1;
                        while (num12 != num22)
                        {
                            Console.Write("Enter First number: ");
                            num12 = int.Parse(Console.ReadLine());
                            Console.Write("Enter Second number: ");
                            num22 = int.Parse(Console.ReadLine());
                            for (; num12 <= num22; num12++)
                            {
                                Console.Write(num12 + " ");
                            }
                            Console.WriteLine();
                        }
                        //
                        Console.ReadLine(); break;
                    case 3:
                        Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                        //
                        int hours = 0, minutes = 0, seconds = 0;
                        while (true)
                        {
                            for (hours = 0; hours < 24; hours++)
                            {
                                for (minutes = 0; minutes < 59; minutes++)
                                {
                                    for (seconds = 0; seconds < 59; seconds++)
                                    {
                                        if (hours < 10)
                                        {
                                            if (minutes < 10)
                                            {
                                                if (seconds < 10)
                                                {
                                                    Console.WriteLine("Question " + quest); Console.WriteLine();
                                                    Console.Write("0{0}:0{1}:0{2}", hours, minutes, seconds);
                                                    Thread.Sleep(20);
                                                    Console.Clear();
                                                }
                                                if (seconds >= 10)
                                                {
                                                    Console.WriteLine("Question " + quest); Console.WriteLine();
                                                    Console.Write("0{0}:0{1}:{2}", hours, minutes, seconds);
                                                    Thread.Sleep(20);
                                                    Console.Clear();
                                                }
                                            }
                                            if (minutes >= 10)
                                            {
                                                if (seconds < 10)
                                                {
                                                    Console.WriteLine("Question " + quest); Console.WriteLine();
                                                    Console.Write("0{0}:{1}:0{2}", hours, minutes, seconds);
                                                    Thread.Sleep(20);
                                                    Console.Clear();
                                                }
                                                if (seconds >= 10)
                                                {
                                                    Console.WriteLine("Question " + quest); Console.WriteLine();
                                                    Console.Write("0{0}:{1}:{2}", hours, minutes, seconds);
                                                    Thread.Sleep(20);
                                                    Console.Clear();
                                                }
                                            }
                                        }
                                        if (hours >= 10)
                                        {
                                            if (minutes < 10)
                                            {
                                                if (seconds < 10)
                                                {
                                                    Console.WriteLine("Question " + quest); Console.WriteLine();
                                                    Console.Write("{0}:0{1}:0{2}", hours, minutes, seconds);
                                                    Thread.Sleep(20);
                                                    Console.Clear();
                                                }
                                                if (seconds >= 10)
                                                {
                                                    Console.WriteLine("Question " + quest); Console.WriteLine();
                                                    Console.Write("{0}:0{1}:{2}", hours, minutes, seconds);
                                                    Thread.Sleep(20);
                                                    Console.Clear();
                                                }
                                            }
                                            if (minutes >= 10)
                                            {
                                                if (seconds < 10)
                                                {
                                                    Console.WriteLine("Question " + quest); Console.WriteLine();
                                                    Console.Write("{0}:{1}:0{2}", hours, minutes, seconds);
                                                    Thread.Sleep(20);
                                                    Console.Clear();
                                                }
                                                if (seconds >= 10)
                                                {
                                                    Console.WriteLine("Question " + quest); Console.WriteLine();
                                                    Console.Write("{0}:{1}:{2}", hours, minutes, seconds);
                                                    Thread.Sleep(20);
                                                    Console.Clear();
                                                }
                                            }
                                        }

                                    }
                                }
                            }
                            hours = 0; minutes = 0; seconds = 0;
                        }
                    //
                    case 4:
                        Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                        //
                        Random random = new Random();
                        for (int i = 1; i <= 60; i++)
                        {
                            int x = random.Next(4, 20);
                            int y = random.Next(4, 20);
                            int c = random.Next(1, 5);
                            if (c == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            if (c == 2)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }
                            if (c == 3)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            if (c == 4)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                            }
                            for (int ty = 1; ty <= y; ty++)
                            {
                                for (int tx = 1; tx <= x; tx++)
                                {
                                    Console.Write("*");
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                        }
                        //
                        Console.ReadLine(); break;
                    case 5:
                        Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                        //
                        Console.Write("Enter Character: ");
                        string character = Console.ReadLine();
                        Console.Write("Enter Amout Of Steps: ");
                        int steps = int.Parse(Console.ReadLine());
                        Console.Clear();
                        while (true)
                        {
                            for (int i = 0; i < steps; i++)
                            {
                                Color.Random();
                                for (int K = 0; K < i; K++)
                                {
                                    Console.Write(" ");
                                }
                                Console.Write(character);
                                Thread.Sleep(150);
                                Console.Clear();
                            }
                            for (int i = steps; i > 0; i--)
                            {
                                Color.Random();
                                for (int K = 0; K < i; K++)
                                {
                                    Console.Write(" ");
                                }
                                Console.Write(character);
                                Thread.Sleep(150);
                                Console.Clear();
                            }

                        }
                    //
                    case 6:
                        Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                        int ans6 = 0, minnum = 10, next6;
                        while (ans6 != -1)
                        {
                            minnum = 10;
                            Console.Write("Enter Number: ");
                            ans6 = int.Parse(Console.ReadLine());
                            next6 = ans6;
                            while (next6 != 0)
                            {
                                if (next6 % 10 < minnum)
                                {
                                    minnum = next6 % 10;
                                }
                                next6 = next6 / 10;
                            }

                        }
                            Console.ReadLine(); break;
                        }
            }
        }
    }
}