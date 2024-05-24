create proc InsertEmp_SP
@ID int,
@Emp_Name varchar(50),
@Position varchar(50),
@Salary int
as
Begin

insert into EmpDB(ID,Emp_Name,Position,Salary)
values (@ID, @Emp_Name ,@Position ,@Salary )
end
exec InsertEmp_SP 1002,'Gagan','HR',20000

create proc ListEmp_SP
as
begin
select *from EmpDB
end
exec  ListEmp_SP


create proc UpdateEmp_SP
@ID int,
@Emp_Name varchar(50),
@Position varchar(50),
@Salary int
as
Begin

Update EmpDB set Emp_Name=@Emp_Name,Position=@Position,Salary=@Salary where ID=@ID

end
create proc DeleteEmp_SP
@ID int

as
Begin

Delete EmpDB  where ID=@ID

end