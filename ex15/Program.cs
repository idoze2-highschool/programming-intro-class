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
                    QuestionBox(x, questionID, "Exit");
                    questionID = 1;
                    QuestionBox(x, questionID, "Question " + questionID);
                    questionID = 2;
                    QuestionBox(x, questionID, "Question " + questionID);
                    questionID = 3;
                    QuestionBox(x, questionID, "Question " + questionID);
                    questionID = 4;
                    QuestionBox(x, questionID, "Question " + questionID);
                    questionID = 5;
                    QuestionBox(x, questionID, "Question " + questionID);
                    questionID = 6;
                    QuestionBox(x, questionID, "Question " + questionID);
                    questionID = 7;
                    QuestionBox(x, questionID, "Question " + questionID);
                    questionID = 8;
                    QuestionBox(x, questionID, "Question " + questionID);
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
                int[] arr1 = { 123, 516, 7, 8935, 189, 7, 8965, 479, 4, 21, 686, 412, 346, 8546 };
                switch (quest)
                {
                    case 1:
                        Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                        //
                        int counteven = 0, countodd = 0;

                        for (int i = 0; i < arr1.Length; i++)
                        {
                            if (i % 2 == 0)
                                counteven += arr1[i];
                            else
                                countodd += arr1[i];
                        }
                        if (countodd > counteven)
                            Console.WriteLine("Odd Locations: (" + countodd + ") > Even Locations (" + counteven + ")");
                        else if (countodd < counteven)
                            Console.WriteLine("Odd Locations: (" + countodd + ") < Even Locations (" + counteven + ")");
                        else
                            Console.WriteLine("Odd Locations: (" + countodd + ") = Even Locations (" + counteven + ")");
                        //
                        Console.ReadLine(); chose = false; break;
                    case 2:
                        Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                        //
                        int[] mults = new int[arr1.Length];
                        for (int i = 0; i < arr1.Length; i++)
                        {
                            mults[i] = arr1[i] * 2;
                        }
                        for (int i = 0; i < arr1.Length; i++)
                        {
                            Console.WriteLine("({0,2}) {1,6}   |{2,6}", i, arr1[i], mults[i]);
                        }
                        //
                        Console.ReadLine(); chose = false; break;
                    case 3:
                        Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                        //
                        Random rand = new Random();
                        int[] arr3 = new int[6];
                        for (int i = 0; i < 100; i++)
                        {
                            int dice = rand.Next(1, 7);
                            arr3[dice - 1]++;
                        }
                        for (int i = 0; i < arr3.Length; i++)
                            Console.WriteLine("{0} = {1,2}", i + 1, arr3[i]);
                        //
                        Console.ReadLine(); chose = false; break;
                    case 4:
                        Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                        //
                        Console.Write("Enter The Length Of The Array: ");
                        int num4 = int.Parse(Console.ReadLine());
                        int[] arr4 = new int[num4];
                        InsertRandom(arr4, 10, 99);
                        PrintArray(arr4,"arr4");
                        //
                        Console.ReadLine(); chose = false; break;
                    case 5:
                        Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                        //
                        int[] arr5a = { 1, 8, 4, 3, 5 };
                        PrintArray(arr5a,"arr5a");
                        Console.WriteLine("," + IsTmora(arr5a));
                        int[] arr5b = { 2, 4, 3, 1 };
                        PrintArray(arr5b,"arr5b");
                        Console.WriteLine("," + IsTmora(arr5b));
                        int[] arr5c = { 1, 6, 4, 2 };
                        PrintArray(arr5c,"arr5c");
                        Console.WriteLine("," + IsTmora(arr5c));
                        int[] arr5d = { 1, 2 };
                        PrintArray(arr5d,"arr5d");
                        Console.WriteLine("," + IsTmora(arr5d));
                        //
                        Console.ReadLine(); chose = false; break;
                    case 6:
                        Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                        //
                        Console.Write("Enter Number Of Students: ");
                        int Length6 = int.Parse(Console.ReadLine());
                        int[] grade1 = new int[Length6];
                        ReadArray(grade1,"grade1");
                        int[] grade2 = new int[grade1.Length];
                        ReadArray(grade2,"grade2");
                        int[] finalGrade = new int[grade1.Length];
                        for (int i = 0; i < grade1.Length; i++)
                        {
                            finalGrade[i] = Math.Max(grade1[i], grade2[i]);
                        }
                        PrintArray(finalGrade,"FinalGrade");
                        //
                        Console.ReadLine(); chose = false; break;
                    case 7:
                        Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                        //
                        int[] numbers = new int[6];
                        ReadArray(numbers,"Numbers");
                        int[] positive = new int[numbers.Length];
                        int[] negative = new int[numbers.Length];
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            if (numbers[i] >= 0)
                                positive[i] = numbers[i];
                            else
                                negative[i] = numbers[i];
                        }
                        PrintArray(numbers,"Numbers");
                        Console.WriteLine();
                        PrintArray(positive,"Positive");
                        Console.WriteLine();
                        PrintArray(negative,"Negative");
                        //
                        Console.ReadLine(); chose = false; break;
                    case 8:
                        Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                        //
                        Random rnd = new Random();
                        int[] arr81 = new int[rnd.Next(3,16)];
                        for (int i = 0; i < arr81.Length; i++)
                        {
                            arr81[i] = rnd.Next(1, 50);
                        }
                        int[] arr82 = new int[rnd.Next(3, 16)];
                        for (int i = 0; i < arr82.Length; i++)
                        {
                            arr82[i] = rnd.Next(1, 50);
                        }
                        int[] arr83 = new int[Math.Max(arr81.Length,arr82.Length)];
                        int arr3loc = 0;
                        int[] found = new int[50];
                        for (int i = 0; i < arr81.Length; i++)
                        {
                            for (int k = 0; k < arr82.Length; k++)
                            {
                                if ((arr81[i] == arr82[k])&&(found[k]<1))
                                {
                                    found[k]++;
                                    arr83[arr3loc] = arr81[i];
                                    arr3loc++;
                                    break;
                                }   
                            }
                        }
                        PrintArray(arr81, "arr1");
                        Console.WriteLine();
                        PrintArray(arr82, "arr2");
                        Console.WriteLine();
                        PrintArray(arr83,"arr3");
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
        static int[] InsertRandom(int[] arr, int low, int high)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(low, high + 1);
            }
            return arr;
        }
        static void PrintArray(int[] arr, string ArrayTitle)
        {
            Console.Write(ArrayTitle+": ");
            for (int i = 0; i < arr.Length-1; i++)
            {
                Console.Write("{0,2},", arr[i]);

            }
            Console.Write("{0,2}", arr[arr.Length-1]);
        }
        static bool IsTmora(int[] arr)
        {
            int[] found = new int[arr.Length];
            bool IsTmora = true;
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] < 1) || (arr[i] > arr.Length))
                {
                    IsTmora = false;
                    return IsTmora;
                }
            }
            for (int i = 1; i <= arr.Length; i++)
            {
                found[i - 1]++;
                if (found[i - 1] > 1)
                {
                    IsTmora = false;
                    return IsTmora;
                }
            }

            return IsTmora;
        }
        static int[] ReadArray(int[] arr,string ArrayTitle)
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
    }
}
