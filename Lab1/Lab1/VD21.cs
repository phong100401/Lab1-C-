using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class VD21
    {
        static void Main21(string[] args)
        {
            int valueOne = 5;
            int valueTwo = 10;
            Console.WriteLine("Value = " + valueOne);
            valueOne += 4;
            Console.WriteLine("Value +=4= " + valueOne);
            valueOne -= 8;
            Console.WriteLine("Value -=8= " + valueOne);
            valueOne *= 7;
            Console.WriteLine("Value *=7= " + valueOne);
            valueOne /= 2;
            Console.WriteLine("Value /=2= " + valueOne);
            Console.WriteLine("Value1 == value2 : {0}", (valueOne == valueTwo));
        }
    }
}
