using System;

namespace Python_to_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            const double tax_rate = 0.20;
            const double standard_deduction = 10000.00;
            const double dependent_deduction = 3000.00;

            Console.WriteLine("Enter the gross income:");
            string grossIncomeAsString = Console.ReadLine();
            Console.WriteLine("Enter the number of dependents:");
            string dependentsAsString = Console.ReadLine();

            double grossIncome = Convert.ToDouble(grossIncomeAsString);
            int dependents = Convert.ToInt32(dependentsAsString);

            double taxable_income = grossIncome - standard_deduction - (dependent_deduction * dependents);
            double incomeTax = taxable_income * tax_rate;

            Console.WriteLine("The income tax is $" + incomeTax);

        }
    }
}
