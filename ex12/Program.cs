using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEx12
{
    class Program
    {
        static void Main(string[] args)
        {
            string questc;
            int quest = 1;
            while (quest >= 0)
            {
                Console.Clear();
                Console.Write("Go to Question: ");
                quest = int.Parse(Console.ReadLine());
                if (quest >= 0)
                {
                    Console.Write("Press Enter to Confirm Going To Question {0} Or Type Something To Cancel> ", quest);
                }
                else
                {
                    Console.Write("Press Enter to Confirm Quitting The Program Or Type Something To Cancel> ", quest);
                }
                questc = Console.ReadLine();
                if (questc == "")
                {
                    switch (quest)
                    {
                        case 1:
                            Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                            //
                            Console.Write("A.\nEnter Your Number To Find Its Absolute value: ");
                            int num1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("|{0}| = {1}", num1, Abs(num1));
                            Console.Write("B.\nEnter Your Number: ");
                            num1 = int.Parse(Console.ReadLine());
                            Console.Write("Enter Your Power: ");
                            int num1p = int.Parse(Console.ReadLine());
                            Console.WriteLine("{0}^{1} = {2}", num1, num1p, Pow(num1, num1p));
                            Console.Write("C.\n");
                            num1 = 1;
                            while (num1 != 0)
                            {
                                if (num1 != 0)
                                {
                                    Console.Write("Enter A Number Or Enter 0 to exit: ");
                                    num1 = int.Parse(Console.ReadLine());
                                    Console.WriteLine(Abs(num1) + "," + Pow(2, Abs(num1)));
                                }
                            }

                            //
                            break;
                        case 2:
                            Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                            //
                            Console.Write("A.\nEnter Your Number To Find If It isn't boom: ");
                            int num2 = int.Parse(Console.ReadLine());
                            bool Boom = IsBoom(num2);
                            if (Boom)
                                Console.WriteLine("Boom.");
                            if (!Boom)
                                Console.WriteLine("Not Boom.");
                            Console.Write("B.\nPress Enter To Start");
                            Console.ReadLine();
                            for (int i = 1; i <= 999; i++)
                            {
                                Boom = IsBoom(i);
                                if (Boom)
                                    Console.Write("Boom! ");
                                if (!Boom)
                                    Console.Write("{0}! ", i);
                            }
                            //
                            Console.ReadLine(); break;
                        case 3:
                            Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                            //
                            Console.Write("A.\nEnter A Name: ");
                            string name3 = Console.ReadLine();
                            Console.Write("Enter {0}'s Age: ", name3);
                            int age3 = int.Parse(Console.ReadLine());
                            Console.WriteLine(Greet(name3, age3));
                            Console.Write("B.\n");
                            for (int i = 0; i < 5; i++)
                            {
                                Console.Write("Enter A Name: ");
                                name3 = Console.ReadLine();
                                Console.Write("Enter {0}'s Age: ", name3);
                                age3 = int.Parse(Console.ReadLine());
                                Console.WriteLine(Greet(name3, age3));
                            }
                            //
                            Console.ReadLine(); break;
                        case 4:
                            Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                            //
                            string word4 = " ";
                            while (word4 != "")
                            {
                                if (word4 != "")
                                {
                                    Console.Write("Enter A Word To Frame It Or Press Enter To Quit:");
                                    word4 = Console.ReadLine();
                                    Console.WriteLine(Frame(word4));
                                }
                            }
                            word4 = Console.ReadLine();
                            Console.WriteLine(Frame(word4));
                            //
                            break;
                        case 5:
                            Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                            //
                            for (int i = 0; i < 6; i++)
                            {
                                Console.Write("Enter Length: ");
                                int l = int.Parse(Console.ReadLine());
                                Console.Write("Enter Height: ");
                                int h = int.Parse(Console.ReadLine());
                                Console.Write("Enter Char: ");
                                char ch = char.Parse(Console.ReadLine());
                                Console.Write(Rectangle(h, l, ch));

                            }
                            //
                            Console.ReadLine(); break;
                        case 6:
                            Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                            //
                            Console.Write("Enter A Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Enter {0}'s Age: ", name);
                            int age = int.Parse(Console.ReadLine());
                            Console.WriteLine(Frame(Greet(name, age)));
                            Console.WriteLine(Rectangle(age,age,'@'));
                            //
                            Console.ReadLine(); break;
                    }
                }
            }
        }

        //functions
        static int Abs(int num1)
        {
            if (num1 < 0)
                num1 *= -1;
            return num1;
        }
        static int Pow(int num, int pow)
        {
            int sum = 1;
            for (int i = 0; i < pow; i++)
            {
                sum *= num;
            }
            return sum;
        }
        static bool IsBoom(int num)
        {
            if ((num % 7 == 0) || ((num % 10 == 7) || (num / 10 % 10 == 7) || (num / 100 == 7)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static string Greet(string name, int age)
        {
            if (age == 0)
            {
                return "No Birthday For " + name + "!";
            }
            else if (age == 1)
            {
                return "Happy 1st Birthday, " + name + "!";
            }
            else if (age == 2)
            {
                return "Happy 2nd Birthday, " + name + "!";
            }
            else if (age == 3)
            {
                return "Happy 3rd Birthday, " + name + "!";
            }
            else
            {
                return "Happy " + age + "th Birthday, " + name + "!";
            }

        }
        static string Frame(string word)
        {
            string frame = "";
            frame += "*";
            for (int i = 0; i < word.Length; i++)
            {
                frame += "*";
            }
            frame += "*\n*";
            frame += word + "*\n";
            frame += "*";
            for (int i = 0; i < word.Length; i++)
            {
                frame += "*";
            }
            frame += "*";
            return frame;
        }
        static string Rectangle(int height, int length, char character)
        {
            string rectangle = "";
            for (int i = 0; i < height; i++)
            {
                for (int k = 0; k < length; k++)
                {
                    rectangle += character;
                }
                rectangle += "\n";
            }
            return rectangle;
        }
        //functions


    }
}
