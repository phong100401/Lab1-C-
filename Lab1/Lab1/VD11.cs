using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class VD11
    {
        static void Main11(string[] args)
        {
            DateTime dt = DateTime.Now;
            //Return short date {MM//DD//YYYY}
            Console.WriteLine("Short date format(d): {0:d}", dt);
            //Return long date {Day,Month Date,Year}
            Console.WriteLine("Long date format(D): {0:D}", dt);
            //Return full date with time without seconds
            Console.WriteLine("Full date with time with seconds(f): {0:f}", dt);
            //Return full date with time without seconds
            Console.WriteLine("Full date with time with seconds(F): {0:F}", dt);
            //Return short date short time without seconds
            Console.WriteLine("Short date and short time without seconds (g): {0:g}", dt);

        }
    }
}
