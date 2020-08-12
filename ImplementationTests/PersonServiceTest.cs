using System;
using System.Collections.Generic;
using Implementation;
using Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.Domain_Models;
using Moq;

namespace ImplementationTests
{
    [TestClass]
    public class PersonServiceTest
    {
        private Mock<IPersonRepository> _personRepository;

        [TestInitialize]
        public void Setup()
        {
            _personRepository = new Mock<IPersonRepository>(MockBehavior.Strict);
        }


        [TestMethod]
        public void AddPersonTest()
        {
            //Arrange
            var testSubject = new PersonService(_personRepository.Object);
            var person = new Person
            {
                PersonId = 1,
                PersonAddress = "Lahore",
                PersonTelephone = "923004400613",
                PersonName = "Mustafa Ali Hassan",
                Location = new List<Location>
                {
                    new Location
                    {
                        LocationOwner = 1
                    }
                }
            };
            _personRepository.Setup(a => a.Add(person));
            _personRepository.Setup(a => a.SaveChanges());

            //Execute
            var result = testSubject.Add(person);

            //Assert
            _personRepository.VerifyAll();
            Assert.AreEqual(result, true);
        }
    }
}
