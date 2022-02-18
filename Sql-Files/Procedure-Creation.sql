USE [Sample]
GO
/****** Object:  StoredProcedure [dbo].[insertemployee]    Script Date: 18-02-2022 16:20:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[insertemployee] (@EmployeeName varchar(200))

as 
begin

insert into EmployeeDetail(EmployeeName) values(@EmployeeName)
end