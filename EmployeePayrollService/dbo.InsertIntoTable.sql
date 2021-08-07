CREATE PROCEDURE dbo.InsertIntoTable
(
    @Id int,
	@Name varchar(200),
	@BasicPay float,
	@StartDate Date,
	@Gender char(1),
	@PhoneNumber varchar(20),
	@Address varchar(150),
	@Department varchar(150),
	@TaxablePay float,
	@Deductions float,
	@NetPay float,
	@Incometax float
	)
AS
BEGIN
	Insert into employee_payroll(id,name,basic_pay,startDate,gender,phonenumber,address,department,taxable_pay,deductions,net_pay,incometax) values(@Id,@Name,@BasicPay,GETDATE(),@Gender,@PhoneNumber,@Address,@Department,@TaxablePay,@Deductions,@NetPay,@Incometax)
	Insert into employee(EmployeeId,Name,Gender,PhoneNumber,Address) values(@Id,@Name,@Gender,@PhoneNumber,@Address)
	Insert into payroll_details(Id,StartDate,Basic_pay,Deductions,Taxable_pay,Net_pay,Incometax) values(@Id,GETDATE(),@BasicPay,@Deductions,@TaxablePay,@NetPay,@Incometax)
END