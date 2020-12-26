using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class VD22
    {
        static void Main22(string[] args)
        {
            int valueOne = 10;
            Console.WriteLine((4 * 5 - 3) / 6 + 7 - 8 % 5);
            Console.WriteLine((32 < 4) || (8 == 8));
            Console.WriteLine((valueOne *= 6) > (valueOne += 5) &&
                (valueOne /= 2) != (valueOne -= 5));
        }
    }
}
