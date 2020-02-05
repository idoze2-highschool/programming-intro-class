using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEx18
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
                        int[] arr1 = { 3, 1, 16, 17, 15, 64, 65, 76 };
                        PringFollowingPairs(arr1);
                        //
                        Console.ReadLine(); chose = false; break;
                    case 2:
                        Menu.StartQuest(quest);
                        //
                        int ShowID = 1, TicketCount,MaxTicketID = 0;
                        int[] ShowTickets = new int[14];
                        while (ShowID != 0)
                        {
                            Console.Write("Which Show would you like to purchase tickets to? ");
                            ShowID = int.Parse(Console.ReadLine());
                            if (ShowID !=0)
                            {
                            Console.Write("How Many Tickets Would You Like to Purchase? ");
                            TicketCount = int.Parse(Console.ReadLine());
                            ShowTickets[ShowID - 1] = TicketCount;
                            }
                        }
                        Console.WriteLine("Number Of Tickets: ");
                        for (int i = 0; i < ShowTickets.Length; i++)
                        {
                            Console.WriteLine("Show Number {0} - {1}",i+1,ShowTickets[i]);
                            if(ShowTickets[i] > ShowTickets[MaxTicketID])
                                MaxTicketID = i+1;
                        }
                        Console.WriteLine();
                        Console.Write("Most Selling Show Is Show Number {0}.",MaxTicketID);
                        //
                        Console.ReadLine(); chose = false; break;
                    case 3:
                        Menu.StartQuest(quest);
                        //
                        Console.Write("Enter Your String: ");
                        string string3 = Console.ReadLine();
                        string3 = DuplicateLetters(string3);
                        Console.WriteLine(string3);
                        //
                        Console.ReadLine(); chose = false; break;
                    case 4:
                        Menu.StartQuest(quest);
                        //
                        Console.Write("Enter ABC Length: ");
                        Console.WriteLine(CreateABC(int.Parse(Console.ReadLine())));
                        //
                        Console.ReadLine(); chose = false; break;
                    case 5:
                        Menu.StartQuest(quest);
                        //
                        Console.Write("Enter Your String: ");
                        string string5 = Console.ReadLine();
                        if (IsPalindrome(string5))
                            Console.WriteLine("{0} - a palindrome", Backwards(string5));
                        else
                            Console.WriteLine("{0} - not a palindrome",Backwards(string5));
                        //
                        Console.ReadLine(); chose = false; break;
                }
            }
        }
        static void PringFollowingPairs(int[] ArrayName)
        {
            for (int i = 0; i < ArrayName.Length - 1; i++)
            {
                if (ArrayName[i] + 1 == ArrayName[i + 1])
                    Console.Write("{0},{1} ", ArrayName[i], ArrayName[i + 1]);
            }
        }
        static string DuplicateLetters(string stringname)
        {
            string dupedstring = "";
            stringname.Replace("*","");
            for (int i = 0; i < stringname.Length; i++)
            {
                if (stringname[i] != '*')
                {
                    dupedstring += stringname[i];
                    dupedstring += stringname[i];
                }
                    
            }
            return dupedstring;
        }
        static string CreateABC(int length)
        {
            string abc = "";
            int letterid = 97;
            for (int i = 0; i < length; i++)
            {
                abc+=(char)letterid;
                if (letterid < 122)
                {
                    letterid++;
                }
                else
                    letterid = 97;
            }
            return abc;
        }
        static string Backwards(string stringname)
        {
            string backwardsstringname = "";
            for (int i = stringname.Length - 1; i >= 0 ; i--)
			{
                backwardsstringname += stringname[i];
			}
            return backwardsstringname;
        }
        static bool IsPalindrome(string stringname)
        {
            return (stringname == Backwards(stringname));
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
            public static void Print(int[] arr)
            {

                for (int i = 0, x = 0; i < arr.Length - 1; i++, x++)
                {
                    Console.Write("{0},", arr[i]);
                    if (x == 10)
                    {
                        Console.WriteLine();
                        x = 0;
                    }
                }
                Console.Write("{0}", arr[arr.Length - 1]);
                Console.WriteLine();
            }
            public static int[] Read(int[] arr)
            {
                Console.Write("Enter A Value (Index 0): ");
                arr[0] = int.Parse(Console.ReadLine());
                for (int i = 1; i < arr.Length; i++)
                {
                    Console.Write("Enter Another Value (Index {0}): ", i);
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
                    arr[i] = rand.Next(1, MaxValueOfCell + 1);
                }
                return arr;
            }

        }
    }
}
