using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class VD25
    {
        static void Main(string[] args)
        {
            int numOne = 5;
            int numTwo = 25;
            int numThree = 15;
            int result = 0;
            if(numOne > numTwo)
            {
                result = (numOne > numThree) ? result = numOne : result = numThree;
            }
            else
            {
                result = (numTwo > numThree) ? result = numTwo : result = numThree;
            }
            if(result == 0)
            {
                Console.WriteLine("{0} is the largerst number", result);
            }
        }
    }
}
