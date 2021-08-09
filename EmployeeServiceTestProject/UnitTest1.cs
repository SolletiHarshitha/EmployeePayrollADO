using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeePayrollService;
namespace EmployeeServiceTestProject
{
    [TestClass]
    public class UnitTest1
    {
        EmployeeRepository repository;
        EmployeeDetails details;
        [TestInitialize]
        public void SetUp()
        {
            repository = new EmployeeRepository();
            details = new EmployeeDetails();
        }

        [TestMethod]
        public void TestUpdateSalaryUsingPreparedStatement()
        {
            ///AAA Methodology
            //Arrange
            int expected = 1;
            details.EmployeeID = 6;
            details.EmployeeName = "Terissa";
            details.BasicPay = 3000000;
            //Act
            int actual = repository.UpdateSalaryusingPreparedStatement(details);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestAddEmployee()
        {
            bool expected = true;
            details.EmployeeName = "Kaveri";
            details.BasicPay = 394856;
            details.Gender = "F";
            details.PhoneNumber = "99494294852";
            details.Address = "Karnataka";
            details.Department = "HR";
            details.TaxablePay = 1000;
            details.Deductions = 100;
            details.NetPay = 20000;
            details.IncomeTax = 200;
            bool actual = repository.AddEmployee(details);
            Assert.AreEqual(expected, actual);
        }
    }
}
