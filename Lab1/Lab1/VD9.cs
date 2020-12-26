using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class VD9
    {
        static void Main9(string[] args)
        {
            string userName;
            int age;
            double salary;
            Console.WriteLine("Enter your name: ");
            userName = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the salary: ");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Name:{0}, Age:{1}, Salary:{2}", userName, age, salary);
        }
    }
}
