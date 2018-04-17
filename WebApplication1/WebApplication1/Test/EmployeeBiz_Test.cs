using System;
using System.Collections.Generic;
using NUnit.Framework;
using WebApplication1.Models;
using NSubstitute;
using WebApplication1.BusinessLayer.EmployeeBL;
using WebApplication1.DataAccessLayer.Interface;

namespace WebApplication1.Test
{
    [TestFixture]
    public class EmployeeBiz_Test
    {
        [Test]
        public void EmployeeBiz_Retrun_one_Row()
        {
            //Arrange
            var expected = 1;
            var expectedOObject = new List<Employees>
            {
                new Employees
                {
                    EmployeeID = 123,
                    Address = "Test",
                    BirthDate = DateTime.Now,
                    City = "test"
                }
            };

            var stubEmployeeAccess = Substitute.For<IEmployeeAccess>();
            stubEmployeeAccess.GetEmployee().Returns(new List<Employees>
            {
                new Employees
                {
                    EmployeeID = 123,
                    Address = "Test",
                    BirthDate = DateTime.Now,
                    City = "test"
                }
            });

            //Act
            var target = new EmployeeBiz {ServiceImpl = stubEmployeeAccess};
            var actual = target.GetEmployee();

            //Assert
            Assert.AreEqual(expected,actual.Count);
            expectedOObject.Equals(actual);
        }
    }
}
