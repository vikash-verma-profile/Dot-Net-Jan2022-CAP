Create table tblrole (Id int identity(1,1),RoleName varchar(20),IsDeleted int default 0,Primary key(Id));
Create table tblmenumaster (Id int identity(1,1),PageName varchar(200),IsDeleted int default 0,Primary key(Id));
Create table tblroleusermapping (Id int identity(1,1),RoleId int,UserId int,IsDeleted int default 0,Primary key(Id),
FOREIGN KEY(RoleId) References tblrole(ID),
FOREIGN KEY(UserId) References tbluser(ID)
);
Create table tblmenurolemapping (Id int identity(1,1),RoleId int,MenuId int,IsDeleted int default 0,Primary key(Id),
FOREIGN KEY(RoleId) References tblrole(ID),
FOREIGN KEY(MenuId) References tblmenumaster(ID)
);

Create proc GetMenuByUser(@UserID int)
As Begin

select M.PageName from tbluser T inner join tblroleusermapping TUM on TUM.UserId=T.UserId 
inner join tblmenurolemapping MRM on MRM.RoleId=TUM.RoleId 
inner join tblmenumaster M on M.Id=MRM.MenuId where T.Id=@UserID;

End

exec GetMenuByUser 1