using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business
{
    public class Manager : Employee
    {
        public Manager(Guid IdValue, 
                       string FirstNameValue, 
                       string LastNameValue, 
                       double SalaryValue,
                       DateTime StartDateValue) : base(IdValue, FirstNameValue, LastNameValue, SalaryValue, StartDateValue)
        {
        }

        public override string Saluation()
        {
            return "Hello dear manager " + FirstName + " " + LastName;
        }
    }
}
