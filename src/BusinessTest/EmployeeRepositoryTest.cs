using System;
using Business;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace BusinessTest
{
    public class EmployeeRepositoryTest
    {
        [TestMethod]
        public void When_RetriveArchitects_Then_ReturnsAllArchitects()
        {
            EmployeeRepository EmployeeRepositoryInstance = Sut;
            EmployeeRepositoryInstance.RetriveArchitects().Should().BeEquivalentTo(InitialArchitects);
        }

        [TestMethod]
        public void When_RetriveArchitects_Then_ReturnsAllManagers()
        {
            EmployeeRepository EmployeeRepositoryInstance = Sut;
            EmployeeRepositoryInstance.RetriveManagers().Should().BeEquivalentTo(InitialManagers);
        }

        [TestMethod]
        public void When_ActiveEmployees_Then_ReturnAllActiveEmployees()
        {
            EmployeeRepository EmployeeRepositoryInstance = Sut;
            EmployeeRepositoryInstance.ActiveEmployees().Should().BeEquivalentTo(InitialEmployees);
        }

        [TestMethod]
        public void When_RetriveAllOrderBySalaryDescending_Then_ReturnOrderdEmployees()
        {
            EmployeeRepository EmployeeRepositoryInstance = Sut;
            IEnumerable<Employee> ExpectedOutput = from p in InitialEmployees
                                                   where true
                                                   orderby p.Salary descending
                                                   select p;
            EmployeeRepositoryInstance.RetriveAllOrderBySalaryDescending().
                                       Should().
                                       BeEquivalentTo(ExpectedOutput);
        }

        [TestMethod]
        public void When_RetriveAllOrderBySalaryAscending_Then_ReturnOrderdEmployees()
        {
            EmployeeRepository EmployeeRepositoryInstance = Sut;
            IEnumerable<Employee> ExpectedOutput = from p in InitialEmployees
                                                   where true
                                                   orderby p.Salary ascending
                                                   select p;
            EmployeeRepositoryInstance.RetriveAllOrderBySalaryAscending().
                                       Should().
                                       BeEquivalentTo(ExpectedOutput);
        }

        [TestMethod]
        public void When_RetriveAllContainsInName_Then_ReturnOrderdEmployees()
        {
            EmployeeRepository EmployeeRepositoryInstance = Sut;
            IEnumerable<Employee> ExpectedOutput = from p in InitialEmployees
                                                   where p.FirstName.Contains("0") || p.LastName.Contains("0")
                                                   select p;
            EmployeeRepositoryInstance.RetriveAllContainsInName("0").
                                       Should().
                                       BeEquivalentTo(ExpectedOutput);
        }

        protected EmployeeRepository Sut;
        public static List<Employee> InitialEmployees = new List<Employee>();
        public static List<Employee> InitialArchitects = new List<Employee>();
        public static List<Employee> InitialManagers = new List<Employee>();
        static EmployeeRepositoryTest()
        {
            InitialManagers.Add(new Manager(Guid.NewGuid(), "Ana0", "Ana", 100000000, new DateTime(1995, 7, 5, 0, 0, 0)));
            InitialManagers.Add(new Manager(Guid.NewGuid(), "Ana1", "Ana", 10000000, new DateTime(1995, 7, 5, 0, 0, 0)));
            InitialManagers.Add(new Manager(Guid.NewGuid(), "Ana2", "Ana", 100000, new DateTime(1995, 7, 5, 0, 0, 0)));
            InitialManagers.Add(new Manager(Guid.NewGuid(), "Ana3", "Ana", 1000000, new DateTime(1995, 7, 5, 0, 0, 0)));
            InitialManagers.Add(new Manager(Guid.NewGuid(), "Ana4", "Ana", 10000, new DateTime(1995, 7, 5, 0, 0, 0)));
            InitialArchitects.Add(new Architect(Guid.NewGuid(), "Ana5", "Ana", 1000, new DateTime(1995, 7, 5, 0, 0, 0)));
            InitialArchitects.Add(new Architect(Guid.NewGuid(), "Ana6", "Ana", 10, new DateTime(1995, 7, 5, 0, 0, 0)));
            InitialArchitects.Add(new Architect(Guid.NewGuid(), "Ana7", "Ana", 100, new DateTime(1995, 7, 5, 0, 0, 0)));
            InitialArchitects.Add(new Architect(Guid.NewGuid(), "Ana8", "Ana", 100000000, new DateTime(1995, 7, 5, 0, 0, 0)));
            InitialArchitects.Add(new Architect(Guid.NewGuid(), "Ana9", "Ana", 100000000, new DateTime(1995, 7, 5, 0, 0, 0)));
            InitialEmployees.AddRange(InitialManagers);
            InitialEmployees.AddRange(InitialArchitects);
        }
    }
}
