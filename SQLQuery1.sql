create proc InsertEmp_Sp
@ID int,
@Emp_Name varchar(50),
@Position varchar(50),
@Salary int
as 
begin 
insert into EmpDB (ID,Emp_Name,Position,Salary)
