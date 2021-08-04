﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollService
{
    public class EmployeeRepository
    {
        public static string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=payroll_service";
        SqlConnection connection = new SqlConnection(connectionString);

        public void GetAllEmployee()
        {
            try
            {
                EmployeeDetails details = new EmployeeDetails();
                using(this.connection)
                {
                    string query = @"Select * from employee_payroll";
                    SqlCommand command = new SqlCommand(query,this.connection);
                    this.connection.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            details.EmployeeID = Convert.ToInt32(dataReader["id"]);
                            details.EmployeeName = dataReader["name"].ToString();
                            details.BasicPay = Convert.ToDouble(dataReader["basic_pay"]);
                            details.StartDate = dataReader.GetDateTime(3);
                            details.Gender = dataReader["gender"].ToString();
                            details.PhoneNumber = dataReader["phonenumber"].ToString();
                            details.Address = dataReader["address"].ToString();
                            details.Department = dataReader["department"].ToString();
                            details.Deductions = Convert.ToDouble(dataReader["deductions"]);
                            details.TaxablePay = Convert.ToDouble(dataReader["taxable_pay"]);
                            details.IncomeTax = Convert.ToDouble(dataReader["incometax"]);
                            details.NetPay = Convert.ToDouble(dataReader["net_pay"]);
                            Console.WriteLine(details.EmployeeName + " " + details.BasicPay + " " + details.StartDate + " " + details.Gender + " " + details.PhoneNumber + " " + details.Address + " " + details.Department + " " + details.Deductions + " " + details.TaxablePay + " " + details.IncomeTax + " " + details.NetPay);
                            Console.WriteLine("\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No data found");
                    }
                    this.connection.Close();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        
    }
}
