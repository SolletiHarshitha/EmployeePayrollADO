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
        public static string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=payroll_service;";
        SqlConnection connection = new SqlConnection(connectionString);
    }
}
