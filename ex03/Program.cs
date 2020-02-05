using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1//
            Console.Write("Enter Number: ");
            int q1people = int.Parse(Console.ReadLine());
            int q1fullboats = q1people / 8;
            if ((q1people % 8) == 0)
                Console.WriteLine("You Will Need {0} Boats and it will cost {1} Dollars.", q1fullboats, (q1fullboats * 30) );
            else 
                Console.WriteLine("You Will Need {0} Boats and it will cost {1} Dollars.", q1fullboats + 1, (q1fullboats + 1) * 30);
            //2//
            Console.Write("Enter Number Between 1-99: ");
            int q2num = int.Parse(Console.ReadLine());
            if ((q2num % 7 == 0)||((q2num / 7 == 0)||(q2num % 10) % 7 ==0 ))
                Console.WriteLine("BOOM!");
            else
                Console.WriteLine(q2num);
            //3//
            Console.Write("Enter First Grade:");
            int q3g1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Second Grade:");
            int q3g2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Third Grade:");
            int q3g3 = int.Parse(Console.ReadLine());
            int q3count = 0;
            if (q3g1 >= 80) 
                q3count++;
            if (q3g2 >= 80)
                q3count ++;
            if (q3g3 >= 80)
                q3count ++;
            if (q3count >= 2)
                Console.WriteLine("Yes.");
            else
                Console.WriteLine("No.");
            //4//
            Console.Write("Enter Age of first: ");
            int q4a1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Gender Of First (Type m/f): ");
            char q4g1 = char.Parse(Console.ReadLine());
            Console.Write("Enter Age of Second: ");
            int q4a2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Gender Of Second (Type m/f): ");
            char q4g2 = char.Parse(Console.ReadLine());
            if ((q4a1 - q4a2 <= 5) && (q4g1 != q4g2))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            //5//
            Console.Write("enter 1st number: ");
            int q5num1 = int.Parse(Console.ReadLine());
            Console.Write("enter 2st number: ");
            int q5num2 = int.Parse(Console.ReadLine());
            Console.Write("enter 3st number: ");
            int q5num3 = int.Parse(Console.ReadLine());
            if ((q5num1 > q5num2)&&(q5num2 > q5num3))
                Console.WriteLine("Down");
            if ((q5num1 < q5num2) && (q5num2 < q5num3))
                Console.WriteLine("Up");
            else
                Console.WriteLine("Nothing");

            //6//
            Console.Write("enter 1st zela: ");
            int q6zela1 = int.Parse(Console.ReadLine());
            Console.Write("enter 2st zela: ");
            int q6zela2 = int.Parse(Console.ReadLine());
            Console.Write("enter 3st zela: ");
            int q6zela3 = int.Parse(Console.ReadLine());
            if ((q6zela1 == q6zela2) || (q6zela2 == q6zela3) || (q6zela1 == q6zela3))
                Console.WriteLine("Shve Shokaim");
            if ((q6zela1 == q6zela2) && (q6zela2 == q6zela3))
                Console.WriteLine("Shve Zlaot");
            else
                Console.WriteLine("Nothing");
            //7//
            Console.Write("Choose Liters: ");
            int q7Lit = int.Parse(Console.ReadLine());
            //8//
            Console.Read();
        }
    }
}
