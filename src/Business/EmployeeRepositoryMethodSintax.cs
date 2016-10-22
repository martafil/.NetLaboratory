using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business
{
    public class EmployeeRepositoryMethodSintax : EmployeeRepository
    {
        public EmployeeRepositoryMethodSintax(List<Employee> InitialEmployees)
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
            return Employees.OfType<Architect>(); 

        }

        public IEnumerable<Employee> RetriveManagers()
        {
            return Employees.OfType<Manager>();
        }

        public IEnumerable<Employee> ActiveEmployees()
        {
            return Employees.Where(p => p.IsActive());
        }

        public IEnumerable<Employee> RetriveAllOrderBySalaryDescending()
        {
            return Employees.OrderBy(p => p.Salary);
        }

        public IEnumerable<Employee> RetriveAllOrderBySalaryAscending()
        {
            return Employees.OrderByDescending(p => p.Salary);
        }

        public IEnumerable<Employee> RetriveAllContainsInName(string pattern)
        {
            return Employees.Where(p => p.FirstName.Contains(pattern) ||
                                        p.LastName.Contains(pattern));
        }

        public IEnumerable<Employee> RetriveAllBetween(DateTime startDate, DateTime endDate)
        {
            return Employees.Where(p => DateTime.Compare(p.StartDate, startDate) <= 0 &&
                                        DateTime.Compare(p.EndDate, endDate) <= 0);
        }

        private List<Employee> Employees { get; set; }
    }
}
