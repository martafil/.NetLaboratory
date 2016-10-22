using System;
using Business;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessTest
{
    [TestClass]
    public class ManagerTest
    {
        [TestMethod]
        public void When_SalutationIsCalled_Then_HelloDearManagerPlusFirstNamePlusLastNameIsReturned()
        {
            Manager ManagerInstance = CreateSUT();
            string ExpectedOutput = "Hello dear manager Ana Ionescu";
            ExpectedOutput.Should().Be(ManagerInstance.Saluation());
        }

        [TestMethod]
        public void When_EndDateWasNotSet_Then_ManagerIsStillWorking()
        {
            Manager ManagerInstance = CreateSUT();
            ManagerInstance.IsActive().Should().Be(true);
        }

        [TestMethod]
        public void When_EndDateWasSet_Then_ManagerIsNotWorking()
        {
            Manager ManagerInstance = CreateSUT();
            ManagerInstance.EndDate = DateTime.Now;
            ManagerInstance.IsActive().Should().Be(false);
        }
        
        [TestMethod]
        public void When_GetFullNameIsCalled_Then_FirstNamePlusSpacePlusLastNameIsReturned()
        {
            Manager ManagerInstance = CreateSUT();
            string ExpectedOutput = "Ana Ionescu";
            ExpectedOutput.Should().Be(ManagerInstance.GetFullName());
        }

        private Manager CreateSUT()
        {
            return new Manager(Guid.NewGuid(), "Ana", "Ionescu", 456789045, DateTime.Now);
        }
    }
}
