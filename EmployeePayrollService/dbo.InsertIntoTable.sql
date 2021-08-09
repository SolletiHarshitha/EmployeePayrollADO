CREATE PROCEDURE dbo.InsertIntoTable
(
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
	Insert into employee_payroll(name,basic_pay,startDate,gender,phonenumber,address,department,taxable_pay,deductions,net_pay,incometax) values(@Name,@BasicPay,GETDATE(),@Gender,@PhoneNumber,@Address,@Department,@TaxablePay,@Deductions,@NetPay,@Incometax)
END