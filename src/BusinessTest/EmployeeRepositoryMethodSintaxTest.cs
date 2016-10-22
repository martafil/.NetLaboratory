using System;
using System.Collections.Generic;
using Business;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessTest
{
    [TestClass]
    public class EmployeeRepositoryMethodSintaxTest : EmployeeRepositoryTest
    {
        [TestInitialize]
        public void Setup()
        {
            Sut = new EmployeeRepositoryMethodSintax(EmployeeRepositoryTest.InitialEmployees);
        }
    }
}
