using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business
{
    abstract public class Employee
    {
        public Employee(Guid IdValue, 
                        string FirstNameValue, 
                        string LastNameValue, 
                        double SalaryValue, 
                        DateTime StartDateValue)
        {
            Id = IdValue;
            FirstName = FirstNameValue;
            LastName = LastNameValue;
            StartDate = StartDateValue;
            EndDate = DateTime.MinValue;
            Salary = SalaryValue;
        }

        public Guid Id { get; private set; }

        public string LastName { get; private set; }

        public string FirstName { get; private set; }
        
        public DateTime StartDate { get; private set; }

        public DateTime EndDate { get; set; }

        public double Salary { get; set; }

        public string GetFullName() { return FirstName + " " + LastName; }

        public bool IsActive() { return EndDate == DateTime.MinValue; }

        public abstract string Saluation();
    }
}
