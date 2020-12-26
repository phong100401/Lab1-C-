using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class VD8
    {
        static void Main8(string[] args)
        {
            string custName;
            double loanAmount;
            float interest = 0.09F;
            double interestAmount = 0;
            double totalAmount = 0;
            Console.WriteLine("Enter the name of customer:");
            custName = Console.ReadLine();
            Console.WriteLine("Enter loan amount: ");
            loanAmount = Convert.ToDouble(Console.ReadLine());
            interestAmount = loanAmount * interest;
            totalAmount = loanAmount + interestAmount;
            Console.WriteLine("\nCustomer Name: {0}", custName);
            Console.WriteLine("Loan amount : $ {0:#,###.#0} \nInterest rate : {1:0#%} \nInterest Amount : $ {2:#,###.#0}", loanAmount, interest, interestAmount);
            Console.WriteLine("Total amount to be paid : $ {0:#,###.#0}", totalAmount);
        }
    }
}
