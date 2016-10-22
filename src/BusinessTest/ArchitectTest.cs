using System;
using Business;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessTest
{
    [TestClass]
    public class ArchitectTest
    {
        [TestMethod]
        public void When_SalutationIsCalled_Then_HelloDearManagerPlusFirstNamePlusLastNameIsReturned()
        {
            Architect ArchitectInstance = new Architect(Guid.NewGuid(), "Ana", "Ionescu", 456789045, DateTime.Now);
            string ExpectedOutput = "Hello dear architect Ana Ionescu";
            ExpectedOutput.Should().Be(ArchitectInstance.Saluation());
        }
    }
}
