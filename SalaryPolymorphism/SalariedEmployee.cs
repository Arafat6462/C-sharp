using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryPolymorphism
{
    // SalariedEmployee class that extends Employee.
    class SalariedEmployee : Employee
    {
        private decimal weeklySalary;

       
        // four-parameter
        public SalariedEmployee(string firstName, string lastName, string socialSecutityNumber, decimal weeklySalary) : base(firstName,lastName,socialSecutityNumber)
        {
            WeeklySalary = weeklySalary;
        }

        public decimal WeeklySalary
        {
            get
            {
                return weeklySalary;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),value,$"{nameof(WeeklySalary)} must be >= 0 ");
                }
                weeklySalary = value;
            }
        }

        // calculate earnings; override abstract method Earnings in Employee
        public override decimal Earnings() => WeeklySalary;


        // return string representation of SalariedEmployee object
        public override string ToString() => $"salaried employee: {base.ToString()}\n" + $"weekly salaty: {WeeklySalary:C}";
         



    }
}
