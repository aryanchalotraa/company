create proc InsertEmp_SP
@ID int,
@Emp_Name varchar(50),
@Poition varchar(50),
@Salary int
as 
begin
insert into Emp_test(ID,Emp