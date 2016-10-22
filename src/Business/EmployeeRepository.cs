using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business
{
    public interface EmployeeRepository
    {
        IEnumerable<Architect> RetriveArchitects();
        IEnumerable<Employee> RetriveManagers();
        IEnumerable<Employee> ActiveEmployees();
        IEnumerable<Employee> RetriveAllOrderBySalaryDescending();
        IEnumerable<Employee> RetriveAllOrderBySalaryAscending();
        IEnumerable<Employee> RetriveAllContainsInName(string pattern);
        IEnumerable<Employee> RetriveAllBetween(DateTime startDate, DateTime endDate);
    }
}
