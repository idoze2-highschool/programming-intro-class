using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Color
    {
        public static void Random()
        {
            Random random = new Random();
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
        }
    }
}
