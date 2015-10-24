using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            double Price;
            int Quantity;
            int Precent;
            double Total1;
            double Total2;

            Console.Write("Enter Price Per Umbrealla: ");
            Price = double.Parse(Console.ReadLine());
            Console.Write("Enter Amount Of Umbreallas: ");
            Quantity = int.Parse(Console.ReadLine());
            Console.Write("Enter Discount Precentage: ");
            Precent = int.Parse(Console.ReadLine());
            Total1 = (Price - ((Price * Precent) / 100));
            Total2 = Quantity * (Price - ((Price * Precent) / 100));

            Console.WriteLine("The Price For One Umbrella Is " + Total1 + " And Total Is " + Total2 + " Shekels.");
            Console.Read();


        }
    }
}
