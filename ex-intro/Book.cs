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
            string title;
            string auth;
            double price;
            int pages;

            title = "Rebirth For Dummies";
            auth = "Ed McMillan";
            price = 14.5;
            pages = 143;

            Console.WriteLine("The book " + title + " by " + auth + " costs "+price+" Dollars, and it has "+pages+" Pages.");
            Console.Read();
        }
    }
}
