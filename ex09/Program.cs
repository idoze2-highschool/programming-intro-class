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
            int quest = 1;
            while (quest > 0)
            {
                Console.Clear();
                Console.Write("Go To Question: ");
                quest = int.Parse(Console.ReadLine());
                switch (quest)
                {
                    case 1: Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                        //
                        Random random = new Random();
                        Console.WriteLine("Hello User!");
                        int num = random.Next(1, 21);
                        Console.WriteLine("I'm thinking of a number between 1 and 20");
                        Console.Write("Guess My Number: ");
                        int guess = int.Parse(Console.ReadLine());
                        int count = 1;
                        while (guess != num)
                        {
                            if (guess < num)
                            {
                                Console.WriteLine("Try Higher!");
                                count++;
                            }
                            if (guess > num)
                            {
                                Console.WriteLine("Try Lower!");
                                count++;
                            }
                            Console.Write("Guess My Number:");
                            guess = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("Good Job! You Tried {0} times!",count);
                        //
                        Console.ReadLine(); break;
                    case 2: Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                        //
                        for (int x = 1; x < 7; x++)
                        {
                            for (int y = 1; y < 7; y++)
                            {
                                Console.Write("({0},{1}) ",x,y);
                            }
                            Console.WriteLine();
                        }
                        //
                        Console.ReadLine(); break;
                    case 3: Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                        //
                        for (int y = 1; y <= 10; y++)
                        {
                            for (int x = 1; x <= 10; x++)
                            {
                                Console.Write("{0,4}",x*y);
                            }
                            Console.WriteLine();
                        }
                        //
                        Console.ReadLine(); break;
                    case 4: Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                        //
                        Console.Write("Enter Length: ");
                        int length = int.Parse(Console.ReadLine());
                        Console.Write("Enter Height: ");
                        int height = int.Parse(Console.ReadLine());
                        for (int y = 0 ; y < height; y++)
                        {
                            for (int x = 0; x < length; x++)
                            {
                                Console.Write('*');
                            }
                            Console.WriteLine();
                        }
                        //
                        Console.ReadLine(); break;
                    case 5: Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                        //
                        Console.Write("Enter N: ");
                        int n = int.Parse(Console.ReadLine());
                        char sub = 'A';
                        while (sub != 'G')
                        {
                            Console.Clear();
                            Console.Write("sub-Question(A-F) or G to exit: ");
                            sub = char.Parse(Console.ReadLine());
                            switch (sub)
                            {
                                case 'A':
                                    Console.WriteLine(sub);
                                    for (int y = 1; y <= n; y++)
                                    {
                                        for (int x = 1; x <= y; x++)
                                        {
                                            Console.Write("*");
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ReadLine();break;
                                case 'B':
                                    Console.WriteLine(sub);
                                    for (int y = n; y >= 1; y--)
                                    {
                                        for (int x = 1; x <= y; x++)
                                        {
                                            Console.Write('*');
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ReadLine();break;
                                case 'C':
                                    Console.WriteLine(sub);
                                    for (int y = 1; y <= n; y++)
                                    {
                                        for (int x = 1; x <= y; x++)
                                        {
                                            Console.Write(x);
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ReadLine(); break;
                                case 'E':
                                    Console.WriteLine(sub);
                                    for (int y = n; y >= 1; y--)
                                    {
                                        for (int x = 1; x <= y; x++)
                                        {
                                            Console.Write(x);
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ReadLine(); break;
                                case 'D':
                                    Console.WriteLine(sub);
                                    for (int y = 1; y <= n; y++)
                                    {
                                        for (int x = 1; x <=y ; x++)
                                        {
                                            Console.Write(y);
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ReadLine(); break;
                                case 'F':
                                    Console.WriteLine(sub);
                                    for (int y = n; y >= 1; y--)
                                    {
                                        for (int x = 1; x <= y; x++)
                                        {
                                            Console.Write((n-y)+1);
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ReadLine(); break;
                            }
                        }
                        //
                        break;
                }
            }
        }
    }
}
