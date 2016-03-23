using System;
using Xunit;

namespace WebAppDemo.Model.Test
{
    public class EmployeeTest
    {
        [Fact]
        public void IsSky_Method_Test()
        {
            // arrange
            var employee = new Employee();
            employee.LastName = "Sky";

            // act
            var result = employee.LastName;
            //var resultData = (Contact)result.ViewData.Model;

            // assert
            Assert.Equal("Sky", result);
        }
    }
}
