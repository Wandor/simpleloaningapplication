using System;
using System.Collections.Generic;

namespace TrialEmployeePayroll

{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>();
            

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter the name of the customer");

                string name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the salary of the customer");
                double gross_pay = 0;
                while (!double.TryParse(Console.ReadLine(), out gross_pay))
                {
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Please enter a valid salary");
                }
                if (gross_pay < 0)
                {
                    Console.WriteLine("You can not enter a NEGATIVE value as salary");
                    Console.WriteLine("Please enter a valid salary");
                    while (!double.TryParse(Console.ReadLine(), out gross_pay))
                    {
                        Console.WriteLine("You have entered an invalid input");
                        Console.WriteLine("Please enter a valid salary");
                    }


                }

                Console.WriteLine("Enter the loan  of the customer");
                double loan_amount = 0;
                while (!double.TryParse(Console.ReadLine(), out loan_amount))+
                {
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Please enter a loan amount");
                }
                if (loan_amount < 0)
                {
                    Console.WriteLine("You can not enter a NEGATIVE value as salary");
                    Console.WriteLine("Please enter a valid salary");
                    while (!double.TryParse(Console.ReadLine(), out loan_amount))
                    {
                        Console.WriteLine("You have entered an invalid input");
                        Console.WriteLine("Please enter a valid salary");
                    }


                }
                Employee employee = new Employee(name, gross_pay, loan_amount);
                employees.Add(employee);
            }

            foreach (var item in employees)
            {
                Console.WriteLine("Employee name : {0}",item.name);
                Console.WriteLine("Employee Gross Salary : {0}", item.gross_pay);
                Console.WriteLine("Employee Loan Amount : {0}", item.loan_amount);

                Console.WriteLine("Employee Loan Deductable : {0}", item.CalculateLoanDeductable(item.gross_pay, item.loan_amount));

                
                double net_salary = item.CalculateNetSalary(item.gross_pay, item.CalculateLoanDeductable(item.gross_pay, item.loan_amount));
                double balance = item.CalculateRemainingLoanAmount(item.loan_amount, item.CalculateLoanDeductable(item.gross_pay, item.loan_amount));

                if (balance<0)
                {
                    double bal;
                    bal = balance * -1;
                    net_salary = net_salary + bal;
                    balance = 0;
                }

                Console.WriteLine("Employee Net Salary : {0}", net_salary);
                Console.WriteLine("Employee's Remaining Loan Balance : {0}",balance);
            }






        }
    }
}
