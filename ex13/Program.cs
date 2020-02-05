using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Easter Egg
//                                                        \‾‾‾‾\
//                                                        /    /
//                                                       /    /
//                                                      /     \
//‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾\      \                        /‾‾‾‾‾‾‾‾‾‾‾‾‾\
//‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾\  /‾‾‾‾‾\     \‾‾‾‾‾‾‾‾\‾/‾‾\‾/‾‾\‾/‾‾\‾/‾‾\‾/               \
//                                        /‾‾       ‾\    \        |    |    |    |    |      Ido        |
//_______________________________________/   |‾‾‾‾|   \____\       |    |    |    |    |      Zeira      |
//‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾\   |____|   /‾‾‾‾/       |    |    |    |    |      ©2016      | 
//                                        \__       _/    /        |    |    |    |    |                 |
//________________________________________/  \_____/     /________/_\__/_\__/_\__/_\__/_\               /
//________________________________________________________/     /                        \_____________/
//                                                       \     /    
//                                                        \    \    
//                                                         \    \   
//                                                         /____/   
namespace LabEx13
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
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Choose A Question With the Arrow Keys,");
                    Console.WriteLine("Press Enter To Confirm.");
                    Console.ResetColor();
                    //
                    questionID = 0;
                    QuestionBox(x, questionID, "Exit");
                    questionID = 1;
                    QuestionBox(x, questionID, "Question 1: Draw Char In Col");
                    questionID = 2;
                    QuestionBox(x, questionID, "Question 2: Move Your Character Horizonally");
                    questionID = 3;
                    QuestionBox(x, questionID, "Question 3: Move Your Character Freely");
                    questionID = 4;
                    QuestionBox(x, questionID, "Question 4: Draw Triangle");
                    questionID = 5;
                    QuestionBox(x, questionID, "Question 5: Check For Triangular Number");
                    questionID = 6;
                    QuestionBox(x, questionID, "Question 6: Round The Second Number After The '.'");
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
                        //
                        int col1 = 0;
                        while (col1 >= 0)
                        {
                            Console.Clear(); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Question " + quest); Console.ResetColor(); Console.WriteLine();
                            Console.Write("Enter Your Collum Or A Negative Number To Exit:");
                            col1 = int.Parse(Console.ReadLine());
                            if (col1 >= 0)
                            {
                                DrawCharinCol(col1, '#');
                                Console.WriteLine();
                                Console.WriteLine("Press Enter To For Another One...");
                                Console.ReadLine();
                            }
                        }
                        //
                        chose = false; break;
                    case 2:
                        //
                        int col2 = 1;
                        bool IsEsc = false;
                        while (!IsEsc)
                        {
                            Console.Clear(); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Question " + quest); Console.ResetColor(); Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Move With Left And Right Keys Or Press Escape To Exit.");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("#");
                            Console.ResetColor();
                            DrawCharinCol(col2, '!');
                            input = Console.ReadKey();
                            switch (input.Key)
                            {
                                case ConsoleKey.RightArrow:
                                    if (col2 < 20)
                                        col2++;
                                    break;
                                case ConsoleKey.LeftArrow:
                                    if (col2 > 0)
                                        col2--;
                                    break;
                                case ConsoleKey.Escape:
                                    IsEsc = true;
                                    break;
                            }

                        }
                        //
                        chose = false; break;
                    case 3:
                        //
                        int xc = 0, yc = 0;
                        IsEsc = false;
                        while (!IsEsc)
                        {
                            Console.Clear(); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Question " + quest); Console.ResetColor(); Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Move With Arrow Keys Or Press Escape To Exit.");
                            Console.ResetColor();
                            DrawChar('@', xc, yc);
                            input = Console.ReadKey();
                            switch (input.Key)
                            {
                                case ConsoleKey.RightArrow:
                                    xc++;
                                    break;
                                case ConsoleKey.LeftArrow:
                                    if (xc > 0)
                                        xc--;
                                    break;
                                case ConsoleKey.UpArrow:
                                    if (yc > 0)
                                        yc--;
                                    break;
                                case ConsoleKey.DownArrow:
                                    yc++;
                                    break;
                                case ConsoleKey.Escape:
                                    IsEsc = true;
                                    break;
                            }
                        }
                        //
                        chose = false; break;
                    case 4:
                        Console.Clear(); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Question " + quest); Console.ResetColor(); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Yellow; Console.ResetColor();//
                        Console.Write("Enter Number Of Lines: ");
                        int line4 = int.Parse(Console.ReadLine());
                        Console.Write("Enter Your Character: ");
                        char ch4 = char.Parse(Console.ReadLine());
                        for (int linenum = 0; linenum < line4; linenum++)
                        {
                            for (int space4 = line4 - 1; space4 > linenum; space4--)
                            {
                                Console.Write(" ");
                            }
                            for (int i = 0; i < (linenum * 2) + 1; i++)
                            {
                                Console.Write(ch4);
                            }
                            Console.WriteLine();

                        }
                        //
                        Console.WriteLine("Press Enter To Quit"); Console.ReadLine(); chose = false; break;
                    case 5:
                        //
                        string tranglist5 = "";
                        for (int i = 1; i <= 1000; i++)
                        {
                            Console.Clear();
                            Console.Clear(); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Question " + quest); Console.ResetColor(); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Yellow; Console.ResetColor();
                            Console.WriteLine(tranglist5);
                            Console.WriteLine("Checking {0}...", i);
                            if (IsTriangular(i))
                                tranglist5 += ("The Number " + i + " Is Triangular\n");
                        }
                        Console.Clear();
                        Console.Clear(); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Question " + quest); Console.ResetColor(); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Yellow; Console.ResetColor();
                        Console.WriteLine(tranglist5);
                        Console.WriteLine("Press Enter To Exit...");
                        //
                        Console.ReadLine(); chose = false; break;
                    case 6:
                        Console.Clear(); Console.WriteLine("Question " + quest); Console.WriteLine();
                        //
                        Console.Write("Enter Your Amount: ");
                        double num6 = double.Parse(Console.ReadLine());
                        Console.WriteLine(Round10(num6));
                        Console.WriteLine("Press Enter To Exit");
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
        static void DrawCharinCol(int col, char character)
        {  
            int i = 0;           
            for (i = 0; i < col; i++)
            {                    
                Console.Write(" ");
            }                    
            Console.Write(character);
        }
        static void DrawChar(char character, int xc, int yc)
        {                        
            for (int y = 0; y < yc; y++)
            {
                Console.WriteLine("");
            }
            for (int x = 0; x < xc; x++)
            {
                Console.Write(" ");
            }
            Console.Write(character);
        }
        static bool IsTriangular(int num)
        {
            int sum = 0;
            int temp = num;
            while (temp > 0)
            {
                sum += (int)Math.Pow((temp % 10), 3);
                temp /= 10;
            }
            return sum == num;
        }
        public static double Round10(double num)
        {
            double temp = Math.Round(num * 100);
            if (temp % 10 > 4 && temp % 10 != 0)
                temp += 10 - (temp % 10);
            else if (temp % 10 != 0)
                temp -= 10 - (temp % 10); ;
            return temp / 100;
        }
    }

}