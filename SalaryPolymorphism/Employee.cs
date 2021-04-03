using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryPolymorphism
{
    // Employee abstract base class.
    public abstract class Employee
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string SocialSecutityNumber { get; }


        // three-parameter constructor
        public Employee(string firstName, string lastName, string socialSecutityNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecutityNumber = socialSecutityNumber;
        }

        // return string representation of Employee object, using properties
        public override string ToString() => $"{FirstName} {LastName}\n+" +
            $"social secutity number: {SocialSecutityNumber}";

        // abstract method overridden by derived classes
        public abstract decimal Earnings();

    }
}
