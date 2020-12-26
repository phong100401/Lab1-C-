using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class VD24
    {
        static void Main24(string[] args)
        {
            int num = 6;
            string msg = "";
            if(num < 0)
            {
                msg = "The number: " + num + " is negative";
            }
            else if ((num % 2) == 0)
            {
                msg = "The number: " + num + " is even";
            }
            else
            {
                msg = "The number: " + num + " is odd";
            }
            if(msg != "")
            {
                Console.WriteLine(msg);
            }
        }
    }
}
