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

            details.EmployeeID = 10;
            details.EmployeeName = "Kalpana";
            details.BasicPay = 394856;
            details.Gender = "F";
            details.PhoneNumber = "9393939339";
            details.Address = "Kerala";
            details.Department = "HR";
            details.TaxablePay = 1000;
            details.Deductions = 100;
            details.NetPay = 20000;
            details.IncomeTax = 200;
            bool result = repository.RemoveEmployee(10);
            if(result)
                Console.WriteLine("Successfully removed");
            else
                Console.WriteLine("Not removed");
        }
    }
}
