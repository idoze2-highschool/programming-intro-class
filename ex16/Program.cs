using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEx15
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
                    Menu.QuestionBox(x, questionID, "Exit");
                    questionID = 1;
                    Menu.QuestionBox(x, questionID, "Question " + questionID);
                    questionID = 2;
                    Menu.QuestionBox(x, questionID, "Question " + questionID);
                    questionID = 3;
                    Menu.QuestionBox(x, questionID, "Question " + questionID);
                    questionID = 4;
                    Menu.QuestionBox(x, questionID, "Question " + questionID);
                    questionID = 5;
                    Menu.QuestionBox(x, questionID, "Question " + questionID);
                    questionID = 6;
                    Menu.QuestionBox(x, questionID, "Question " + questionID);
                    //
                    input = Console.ReadKey();
                    if (input.Key == ConsoleKey.DownArrow)
                    {
                        if (x < questionID/*Number Of Questions*/)
                        {
                            x++;
                            Console.Clear();
                        }
                        else if (x == questionID)
                        {
                            x = 0;
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
                        else if (x == 0)
                        {
                            x = questionID;
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
                        Menu.StartQuest(quest);
                        //
                        int[] myArr = ArrayTools.NewRandom(10, 99);
                        ArrayTools.Print(myArr, "myArr");
                        Console.WriteLine();
                        for (int i = 0; i < 5; i++)
                        {
                            Console.Write("Enter A Number To Check If Its In The Array: ");
                            int Check = int.Parse(Console.ReadLine());
                            if (ArrayIndexOf(Check,myArr)>-1)
                                Console.WriteLine("True, {0} Is in the Array In Index {1}",Check,ArrayIndexOf(Check,myArr));
                            else
                                Console.WriteLine("False, {0} Is Not In This Array.",Check);
                        }
                        //
                        Console.ReadLine(); chose = false; break;
                    case 2:
                        Menu.StartQuest(quest);
                        //

                        //
                        Console.ReadLine(); chose = false; break;
                    case 3:
                        Menu.StartQuest(quest);
                        //
                        //
                        Console.ReadLine(); chose = false; break;
                    case 4:
                        Menu.StartQuest(quest);
                        //
                        //
                        Console.ReadLine(); chose = false; break;
                    case 5:
                        Menu.StartQuest(quest);
                        //
                        //
                        Console.ReadLine(); chose = false; break;
                    case 6:
                        Menu.StartQuest(quest);
                        //
                        //
                        Console.ReadLine(); chose = false; break;
                }
            }
        }

        static int ArrayIndexOf(int NumberToFind, int[] ArrayName)
        {
            for (int i = 0; i < ArrayName.Length; i++)
            {
                if (ArrayName[i] == NumberToFind)
                    return i;
            }
            return -1;
        }
        class Menu
        {
            public static void StartQuest(int quest)
            {
                Console.Clear();
                Console.WriteLine("Question " + quest);
                Console.WriteLine();
            }
            public static void QuestionBox(int x, int QuestionNumber, string BoxTitle)
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
        class ArrayTools
        {
            public static void Print(int[] arr, string ArrayTitle)
            {

                Console.Write(ArrayTitle + ":");
                for (int i = 0, x = 0; i < arr.Length-1; i++, x++)
                {
                    Console.Write("{0},", arr[i]);
                    if (x == 10)
                    {
                        Console.WriteLine();
                        x = 0;
                    }
                }
                Console.Write("{0,2}", arr[arr.Length-1]);
            }
            public static int[] Read(int[] arr, string ArrayTitle)
            {
                Console.Write(ArrayTitle + ":\n");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("Enter Value For Cell #{0}: ", i);
                    arr[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
                return arr;
            }
            public static int[] NewRandom(int ArrayLength, int MaxValueOfCell)
            {
                int[] arr = new int[ArrayLength];

                Random rand = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rand.Next(MaxValueOfCell + 1);
                }
                return arr;
            }

        }
    }
}
