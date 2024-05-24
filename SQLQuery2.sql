create proc InsertEmp_SP
@ID int,
@Emp_Name varchar(50),
@Position varchar(50),
@Salary int
as 
begin 
insert into EmpDB