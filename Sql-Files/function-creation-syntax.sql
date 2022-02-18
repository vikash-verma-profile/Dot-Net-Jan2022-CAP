
CREATE FUNCTION EmployeeName (@employeeID int) RETURNS varchar(200) 
AS
Begin 

	return (SELECT employeename from [EmployeeDetail] where id=@employeeID)
	
end

