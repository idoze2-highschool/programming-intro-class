using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEx14
{
    class Program
    {
        static void Main(string[] args)
        {
            int quest = 1;
            int x = 1;
            int questionID = 0;

            ConsoleKeyInfo input = new ConsoleKeyInfo();
            bool chose = false;
            while (quest > 0)
            {
                while (!chose)
                {
                    Console.Clear();
                    Console.WriteLine("Choose A Question With the Arrow Keys,");
                    Console.WriteLine("Press Enter To Confirm.");
                    //
                    questionID = 0;
                    QuestionBox(x, questionID, "Exit");
                    questionID = 1;
                    QuestionBox(x, questionID, "Question 1: Classes");
                    questionID = 2;
                    QuestionBox(x, questionID, "Question 2: Array Adding");
                    questionID = 3;
                    QuestionBox(x, questionID, "Question 3: Array Loop");
                    questionID = 4;
                    QuestionBox(x, questionID, "Question 4: Backwards");
                    questionID = 5;
                    QuestionBox(x, questionID, "Question 5: String Arrays");
                    questionID = 6;
                    QuestionBox(x, questionID, "Question 6: Student Heights");
                    questionID = 7;
                    QuestionBox(x, questionID, "Question 7: Ascending Check");
                    //
                    input = Console.ReadKey();
                    if (input.Key == ConsoleKey.DownArrow)
                    {
                        if (x < questionID/*Number Of Questions*/)
                        {
                            x++;
                            Console.Clear();
                        }
                    }
                    if (input.Key == ConsoleKey.UpArrow)
                    {
                        if (x > 0/*Number Of Questions*/)
                        {
                            x--;
                            Console.Clear();
                        }
                    }
                    if (input.Key == ConsoleKey.Enter)
                    {
                        chose = true;
                        quest = x;
                    }

                }
                switch (quest)
                {
                    case 1:
                        Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                        //
                        Console.Write("Enter Your First Number: ");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter Your Second Number: ");
                        int num2 = int.Parse(Console.ReadLine());
                        Console.Write(MyMath.MyMax(num1, num2) + " Is Bigger, ");
                        if (MyMath.IsPrime((int)MyMath.MyMax(num1, num2)))
                        {
                            Console.Write("And It's A Prime Number.");
                            DrawShape.DrawSquare((int)MyMath.MyMax(num1, num2));
                        }
                        else
                            Console.Write("But It's Not A Prime Number.");
                        //
                        Console.ReadLine(); chose = false; break;
                    case 2:
                        Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                        //
                        int[] Arr2 = new int[3];
                        Console.Write("Enter Num1: ");
                        Arr2[0] = int.Parse(Console.ReadLine());
                        Console.Write("Enter Num2: ");
                        Arr2[1] = int.Parse(Console.ReadLine());
                        Arr2[2] = Arr2[0] + Arr2[1];
                        Console.WriteLine("[0] = {0}\n[1] = {1}\n[2] = {2}", Arr2[0], Arr2[1], Arr2[2]);
                        //
                        Console.ReadLine(); chose = false; break;
                    case 3:
                        Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                        //
                        int[] Arr3 = new int[5];
                        for (int i = 0; i < 5; i++)
                        {
                            if (i == 0)
                                Console.Write("Enter A Number: ");
                            else
                                Console.Write("Enter Another Number: ");
                            Arr3[i] = int.Parse(Console.ReadLine());
                        }
                        for (int i = 0; i < 5; i++)
                        {
                            Console.Write("{0} ", Arr3[i] * 2);
                        }
                        Console.WriteLine("");
                        //
                        Console.ReadLine(); chose = false; break;
                    case 4:
                        Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                        //
                        int[] Arr4 = new int[6];
                        for (int i = 0; i < Arr4.Length; i++)
                        {
                            if (i == 0)
                                Console.Write("Enter A Number: ");
                            else
                                Console.Write("Enter Another Number: ");
                            Arr4[i] = int.Parse(Console.ReadLine());
                        }
                        for (int i = Arr4.Length; i > 0; i--)
                        {
                            Console.Write(Arr4[i] + " ");
                        }
                        //
                        Console.ReadLine(); chose = false; break;
                    case 5:
                        Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                        //
                        string[] Arr5 = new string[4];
                        for (int i = 0; i < Arr5.Length; i++)
                        {
                            if (i == 0)
                                Console.Write("Enter String: ");
                            else
                                Console.Write("Enter Another One: ");
                            Arr5[i] = Console.ReadLine();
                        }
                        for (int i = 0; i < Arr5.Length; i++)
                        {
                            if (Arr5[i].IndexOf(" ") > 0)
                            {
                                Console.Write(Arr5[i] + "\n");
                            }
                        }
                        //
                        Console.ReadLine(); chose = false; break;
                    case 6:
                        Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                        //
                        int[] Arr6 = new int[6];
                        for (int i = 0; i < Arr6.Length; i++)
                        {
                            if (i == 0)
                                Console.Write("Enter A Number: ");
                            else
                                Console.Write("Enter Another Number: ");
                            Arr6[i] = int.Parse(Console.ReadLine());
                        }
                        int sum6 = 0;
                        for (int i = 0; i < Arr6.Length; i++)
                        {
                            sum6 += Arr6[i];
                        }
                        sum6 /= Arr6.Length;
                        for (int i = 0; i < Arr6.Length; i++)
                        {
                            if (Arr6[i] > sum6)
                                Console.Write(Arr6[i] + " ");
                        }
                        //
                        Console.ReadLine(); chose = false; break;
                    case 7:
                        Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                        //
                        Console.Write("Enter Your Number: ");
                        int num7 = int.Parse(Console.ReadLine());
                        int[] Arr7 = new int[num7];
                        for (int i = 0; i < Arr7.Length; i++)
                        {
                            if (i == 0)
                                Console.Write("Enter A Number: ");
                            else
                                Console.Write("Enter Another Number: ");
                            Arr7[i] = int.Parse(Console.ReadLine());
                        }
                        int count7 = 1;
                       for (int i = 0; i < Arr7.Length-1; i++)
			           {
			            if(Arr7[i] < Arr7[i+1])
                            count7++;
			           }
                        if((count7==Arr7.Length)||(Arr7.Length == 1))
                        {
                            for (int i = 0; i < Arr7.Length; i++)
                            {
                                Console.Write(Arr7[i]+" ");
                            }
                            Console.WriteLine();
                            Console.WriteLine("This Is Ascending Perfectly!");
                        }
                        else
                            Console.WriteLine("That's Not Ascending.");
                        //
                        Console.ReadLine(); chose = false; break;
                }
            }
        }
        static void QuestionBox(int x, int QuestionNumber, string BoxTitle)
        {
            if (x == QuestionNumber)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
            }
            Console.Write(BoxTitle);
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
