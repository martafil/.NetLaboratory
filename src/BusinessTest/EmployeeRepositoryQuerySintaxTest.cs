using System;
using System.Collections.Generic;
using Business;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessTest
{
    [TestClass]
    public class EmployeeRepositoryQuerySintaxTest : EmployeeRepositoryTest
    {
        [TestInitialize]
        public void Setup()
        {
            Sut = new EmployeeRepositoryQuerySintax(EmployeeRepositoryTest.InitialEmployees);
        }
    }
}
