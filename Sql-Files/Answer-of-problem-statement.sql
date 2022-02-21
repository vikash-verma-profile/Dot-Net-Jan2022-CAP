--employee database
use EmployeeDb;
--employee table creation
Create table employee (Id int identity(1,1),EmployeeID nvarchar(28),EmployeeFirstName varchar(200),
EmployeeLastName varchar(200),Gender varchar(200),IsDeleted int default 0,EmployeeAge int,EmployeeDataofBirth date,
EmployeeEmail nvarchar(200),Primary key(Id)
);
--Department table creation
create table department(Id int identity(1,1),Department varchar(200),IsDeleted int default 0, Primary key(Id));

--Employee Department mapping table creation
create table EmployeeDepartmentMapping(Id int identity(1,1),EmployeeID  int ,DepartmentID int,Primary key(Id),
FOREIGN KEY(EmployeeID) References employee(ID),FOREIGN KEY(DepartmentID) References department(ID));


--Function to get employee Full name
create function GetEmployeeFullName(@EmployeeID int) returns varchar(200) as 
Begin
return (select Concat(EmployeeFirstName,EmployeeLastName) as EmployeeName from employee where Id=@EmployeeID);
END;

--calling a function
select EmployeeDb.dbo.GetEmployeeFullName(1);

--select query to get all information
select EmployeeDb.dbo.GetEmployeeFullName(E.Id) as EmployeeName,Gender,EmployeeEmail,D.Department from employee E 
inner join EmployeeDepartmentMapping EDM on EDM.EmployeeID=E.Id inner join department D on D.Id=EDM.DepartmentID;

--creation of procedure
Create Proc GetAllInformation as
begin

select EmployeeDb.dbo.GetEmployeeFullName(E.Id) as EmployeeName,Gender,EmployeeEmail,D.Department from employee E 
inner join EmployeeDepartmentMapping EDM on EDM.EmployeeID=E.Id inner join department D on D.Id=EDM.DepartmentID;

end

--executing the procedure
exec GetAllInformation;



