using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class VD12
    {
        static void Main12(string[] args)
        {
            DateTime dt = DateTime.Now;
            //Return short date and short time with seconds
            Console.WriteLine("Short date and short time with seconds(G): {0:G}", dt);
            //Return month and day - M can also be used
            Console.WriteLine("Month and day (m): {0:m}", dt);
            //Return short time
            Console.WriteLine("Short time(t): {0:t}", dt);
            Console.WriteLine("Short time with seconds(T): {0:T}", dt);
            //Return year and month - Y also can be used
            Console.WriteLine("Year and Month (y): {0:y}", dt);
        }
    }
}
