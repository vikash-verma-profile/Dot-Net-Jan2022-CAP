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
insert into EmployeeDetail values(4,'Vikash 4');
alter table EmployeeDetail add gender varchar(30)

update EmployeeDetail set gender='Male' 
update EmployeeDetail set gender='Female' where ID in (2,4)

--order by clasues

select * from EmployeeDetail order by employeename desc