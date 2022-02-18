create table employeedepartmentmapping(id int identity(1,1),employeeID int,departmentId int);

select * from employeedepartmentmapping
insert into employeedepartmentmapping(employeeID,departmentId) values(1,1)
insert into employeedepartmentmapping(employeeID,departmentId) values(1,2)
insert into employeedepartmentmapping(employeeID,departmentId) values(2,1)
insert into employeedepartmentmapping(employeeID,departmentId) values(3,1)
insert into employeedepartmentmapping(employeeID,departmentId) values(4,2)
select * from [EmployeeDetail]
select * from Department
insert into Department(DepartmentID,DepartmentName) values(2,'Sales')

select employeeid from employeedepartmentmapping where departmentId=1

select * from [EmployeeDetail] where id in (select employeeid from employeedepartmentmapping where departmentId=1)