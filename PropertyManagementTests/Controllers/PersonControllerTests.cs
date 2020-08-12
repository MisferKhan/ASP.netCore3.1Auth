using System.Runtime.InteropServices.ComTypes;
using Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PropertyManagement.Controllers;

namespace PropertyManagementTests.Controllers
{
    [TestClass]
    public class PersonControllerTests
    {
        private Mock<IPersonService> _personService;

        [TestInitialize]
        public void Setup()
        {
            _personService = new Mock<IPersonService>(MockBehavior.Strict);
        }


        [TestMethod]
        public void IndexTest()
        {
            //Arrange
            
            var subject = new PersonController(_personService.Object);

        }
    }
}
