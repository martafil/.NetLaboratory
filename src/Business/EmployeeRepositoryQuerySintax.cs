using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business
{
    public class EmployeeRepositoryQuerySintax : EmployeeRepository
    {
        public EmployeeRepositoryQuerySintax(List<Employee> InitialEmployees)
        {
            if (InitialEmployees == null)
            {
                throw new ArgumentNullException();
            }
            if (InitialEmployees.Count < 10)
            {
                throw new ArgumentException("Not enoght employees in the initial list.");
            }
            Employees = new List<Employee>(InitialEmployees);
        }

        public IEnumerable<Architect> RetriveArchitects()
        {
            IEnumerable<Architect> achitects = from p in Employees.OfType<Architect>()
                                               select p;
            return achitects;
           
        }

        public IEnumerable<Employee> RetriveManagers()
        {
            IEnumerable<Employee> managers = from p in Employees.OfType<Manager>()
                                             select p;
            return managers;
        }

        public IEnumerable<Employee> ActiveEmployees()
        {
            IEnumerable<Employee> ActiveEmployees = from p2 in Employees
                                                    where p2.IsActive()
                                                    select p2;
            return ActiveEmployees;
        }

        public IEnumerable<Employee> RetriveAllOrderBySalaryDescending()
        {
            return from p3 in Employees where true orderby p3.Salary descending select p3;
        }

        public IEnumerable<Employee> RetriveAllOrderBySalaryAscending()
        {
            return from p3 in Employees where true orderby p3.Salary ascending select p3;
        }

        public IEnumerable<Employee> RetriveAllContainsInName(string pattern)
        {
            return from p4 in Employees
                   where p4.FirstName.Contains(pattern) || p4.LastName.Contains(pattern)
                   select p4;
        }

        public IEnumerable<Employee> RetriveAllBetween(DateTime startDate, DateTime endDate)
        {
            return from p5 in Employees
                   where DateTime.Compare(p5.StartDate, startDate) <= 0 && 
                         DateTime.Compare(p5.EndDate, endDate) <= 0
                   select p5;
        }

        private List<Employee> Employees { get; set; }
    }
}
