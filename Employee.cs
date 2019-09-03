using System;
using System.Collections.Generic;
using System.Text;

namespace TrialEmployeePayroll
{
    class Employee
    {
        public string name { set; get; }
        public double loan_amount { set; get; }
        public double gross_pay { set; get; }
        // public double loan_Deductable { set; get; }

        public Employee(string name, double gross_pay, double loan_amount)
        {
            this.name = name;
            this.loan_amount = loan_amount;
            this.gross_pay = gross_pay;

        }

        public double CalculateLoanDeductable(double gross_pay, double loan_amount)
        {



            if (loan_amount <= 30000)
            {
                return gross_pay * 0.05;
            }
            else if (loan_amount > 30000 && loan_amount < 100000)
            {
                return gross_pay * 0.1;
            }
            else if (loan_amount >= 100000)
            {
                return gross_pay * 0.2;
            }
            else
            {
                return 0;
            }

        }
        public double CalculateNetSalary(double gross_pay, double loan_deductable)
        {

            return gross_pay - loan_deductable;

        }
        public double CalculateRemainingLoanAmount(double loan_amount, double loan_deductable)
        {
            return loan_amount - loan_deductable;
        }
    }
}





