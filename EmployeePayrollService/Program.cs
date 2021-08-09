using System;

namespace EmployeePayrollService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Payroll Service using ADO.Net");
            EmployeeRepository repository = new EmployeeRepository();
            EmployeeDetails details = new EmployeeDetails();

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

            bool result = repository.AddEmployee(details);
            if (result)
                Console.WriteLine("Successfully added");
            else
                Console.WriteLine("Not added");
        }
    }
}
