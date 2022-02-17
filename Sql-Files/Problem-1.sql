use Sample;


---create a table with employees
---add a new column with gender
--add all as male
--then update female staff from male to female

create table EmployeeDetail(id int,employeename varchar(200))
select * from EmployeeDetail
insert into EmployeeDetail values(1,'Vikash 1');
insert into EmployeeDetail values(2,'Vikash 2');
insert into EmployeeDetail values(3,'Vikash 3');
insert into EmployeeDetail(ID,EmployeeName,Gender) values(5,'Vikash 5','Male');
alter table EmployeeDetail add gender varchar(30)
alter table EmployeeDetail add Salary int
update EmployeeDetail set gender='Male' 
update EmployeeDetail set gender='Female' where ID in (2,4)

--order by clasues

select * from EmployeeDetail order by employeename desc


update EmployeeDetail set Salary=14000 where ID in (4)

select sum(Salary) from EmployeeDetail

select avg(Salary) from EmployeeDetail
select Max(Salary) from EmployeeDetail
select MIN(Salary) from EmployeeDetail

select * from EmployeeDetail WHERE Salary IS NULL
select ISNULL(SALARY,1000) from EmployeeDetail 




