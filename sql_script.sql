
CREATE DATABASE [BugTracker]
 Go

 use [BugTracker]
 Go

CREATE TABLE [dbo].[EmployeeProjectDetails](
	[EmployeeProjectId] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeId] [int] NULL,
	[ProjectId] [int] NULL,
	[WorkStartDate] [varchar](50) NULL,
	[WorkEndDate] [varchar](50) NULL,
	[AssignedBy] [int] NULL,
 CONSTRAINT [PK_EmployeeProjectDetails] PRIMARY KEY CLUSTERED 
(
	[EmployeeProjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDefectDetails]    Script Date: 1/2/2021 4:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDefectDetails](
	[DefectId] [int] IDENTITY(501,1) NOT NULL,
	[DefectName] [varchar](50) NULL,
	[UserAccountId] [int] NULL,
	[ProjectId] [varchar](50) NULL,
	[ModuleName] [varchar](50) NULL,
	[Description] [varchar](1000) NULL,
	[DefectTypeId] [int] NULL,
	[EmpId] [varchar](50) NULL,
	[Status] [varchar](50) NULL,
	[Priority] [varchar](50) NULL,
	[SendingDate] [varchar](50) NULL,
 CONSTRAINT [PK_tblDefectDetails] PRIMARY KEY CLUSTERED 
(
	[DefectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDefectHistoryDetails]    Script Date: 1/2/2021 4:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDefectHistoryDetails](
	[DefectHistoryId] [int] IDENTITY(1,1) NOT NULL,
	[DefectId] [int] NULL,
	[AssignedFrom] [varchar](50) NULL,
	[AssignedTo] [varchar](50) NULL,
	[Status] [varchar](50) NULL,
	[UpdatedDate] [varchar](50) NULL,
	[Comments] [varchar](50) NULL,
	[LoggedUserId] [int] NOT NULL,
 CONSTRAINT [PK_tblDefectHistoryDetails] PRIMARY KEY CLUSTERED 
(
	[DefectHistoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDefectTypes]    Script Date: 1/2/2021 4:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDefectTypes](
	[DefectTypeId] [int] IDENTITY(101,1) NOT NULL,
	[DefectTypeName] [varchar](50) NULL,
	[Description] [varchar](100) NULL,
	[Status] [varchar](50) NULL,
	[Priority] [varchar](10) NULL,
 CONSTRAINT [PK_tblDefectTypes] PRIMARY KEY CLUSTERED 
(
	[DefectTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblProjectDetails]    Script Date: 1/2/2021 4:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProjectDetails](
	[ProjectId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) NULL,
	[NoOfModules] [int] NULL,
	[Description] [varchar](200) NULL,
	[PlatForm] [varchar](50) NULL,
	[Client] [varchar](50) NULL,
	[ProjectStatus] [varchar](50) NULL,
	[projectStartDate] [varchar](50) NULL,
	[projectEndDate] [varchar](50) NULL,
 CONSTRAINT [PK_tblProjectDetails] PRIMARY KEY CLUSTERED 
(
	[ProjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblRoles]    Script Date: 1/2/2021 4:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblRoles](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [varchar](50) NULL,
	[Description] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUserLoginDetails]    Script Date: 1/2/2021 4:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUserLoginDetails](
	[UserAccountId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[UserPassword] [varchar](50) NULL,
	[EmpId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserAccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUsersEmployeesDetails]    Script Date: 1/2/2021 4:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUsersEmployeesDetails](
	[EmpId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Gender] [varchar](50) NULL,
	[Qualification] [varchar](50) NULL,
	[DateOfJoining] [varchar](50) NULL,
	[Designation] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[EmailId] [varchar](50) NULL,
	[PhoneNo] [varchar](50) NULL,
	[RoleId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[EmpId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblDefectHistoryDetails]  WITH CHECK ADD  CONSTRAINT [FK_tblDefectHistoryDetails_tblDefectHistoryDetails] FOREIGN KEY([DefectHistoryId])
REFERENCES [dbo].[tblDefectHistoryDetails] ([DefectHistoryId])
GO
ALTER TABLE [dbo].[tblDefectHistoryDetails] CHECK CONSTRAINT [FK_tblDefectHistoryDetails_tblDefectHistoryDetails]
GO
/****** Object:  StoredProcedure [dbo].[sp_AddempForProjects]    Script Date: 1/2/2021 4:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[sp_AddempForProjects](
 @EmployeeId int
           ,@ProjectId int 
           ,@WorkStartDate varchar(50)
           ,@WorkEndDate varchar(50)
           ,@AssignedBy int)
as
begin
INSERT INTO dbo.EmployeeProjectDetails
           (EmployeeId
           ,ProjectId
           ,WorkStartDate
           ,WorkEndDate
           ,AssignedBy)
     VALUES
            (@EmployeeId
           ,@ProjectId
           ,@WorkStartDate
           ,@WorkEndDate
           ,@AssignedBy)
 end
GO
/****** Object:  StoredProcedure [dbo].[sp_AddNewDefects]    Script Date: 1/2/2021 4:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[sp_AddNewDefects](  
@DefectName varchar(50),  
@UserAccountId int,  
@ProjectId varchar(50),  
@ModuleName varchar(50),  
@description varchar(max),  
@DefectTypeId int,  
@EmpId int,  
@Status varchar(50),  
@priority varchar(50)  
)  
as  
begin 
declare @Date varchar(50)  
set @Date=(select Convert(varchar(50),GetDate(),103))
INSERT INTO tblDefectDetails(
DefectName,UserAccountId,ProjectId, ModuleName, Description,DefectTypeId,EmpId, Status, Priority,SendingDate)
 VALUES
 (@DefectName, @UserAccountId, @ProjectId, @ModuleName, @description, @DefectTypeId, @EmpId, @Status, @priority, @Date)
 declare @DefectId int
set @DefectId=(select max(DefectId) from tblDefectDetails)

INSERT INTO tblDefectHistoryDetails
 (DefectId ,AssignedFrom ,AssignedTo,Status,UpdatedDate,Comments,LoggedUserId)
     VALUES
           (@DefectId, @UserAccountId,  @EmpId ,@Status,  @Date , 'NULL' ,@UserAccountId)

 end



GO
/****** Object:  StoredProcedure [dbo].[sp_CheckAvaliableUserName]    Script Date: 1/2/2021 4:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[sp_CheckAvaliableUserName](
@UserName varchar(50))
as
begin
select * from tblUserLoginDetails where UserName=@UserName
end
GO
/****** Object:  StoredProcedure [dbo].[sp_DefectHistoryPerAppln]    Script Date: 1/2/2021 4:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[sp_DefectHistoryPerAppln]
@ProjectId int
as
begin
Select *  from [dbo].[tblDefectHistoryDetails] A
join [dbo].[tblDefectDetails] B on A.DefectId = B.DefectId
join [dbo].[tblProjectDetails] C on B.ProjectId = C.ProjectId
join [dbo].[tblUsersEmployeesDetails] D on D.EmpId = A.AssignedTo
where C.ProjectId = @ProjectId
end
GO
/****** Object:  StoredProcedure [dbo].[sp_DefectHistoryPerEmp]    Script Date: 1/2/2021 4:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Proc [dbo].[sp_DefectHistoryPerEmp]
@EmployeeId int
as
begin
Select *  from [dbo].[tblDefectHistoryDetails] A
join [dbo].[tblDefectDetails] B on A.DefectId = B.DefectId
join [dbo].[tblProjectDetails] C on B.ProjectId = C.ProjectId
join [dbo].[tblUsersEmployeesDetails] D on D.EmpId = A.AssignedTo
where A.AssignedFrom = @EmployeeId
end
GO
/****** Object:  StoredProcedure [dbo].[SP_EmployeeProject]    Script Date: 1/2/2021 4:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_EmployeeProject](@EmpId int)  
as  
begin  
select * from tblProjectDetails  p join EmployeeProjectDetails e on p.ProjectId = e.ProjectId  
where e.EmployeeId = @EmpId 
end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetProjectsByLoginUsers]    Script Date: 1/2/2021 4:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[sp_GetProjectsByLoginUsers]  
@EmpId int  
as    
begin    
select * from EmployeeProjectDetails A  join tblUsersEmployeesDetails B on A.EmployeeId = B.EmpId    
Join tblProjectDetails C on A.ProjectId = C.ProjectId     
Where A.EmployeeId =@EmpId  
end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetProjectsByUsers]    Script Date: 1/2/2021 4:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[sp_GetProjectsByUsers]
@ProjectId int
as  
begin  
select A.EmployeeProjectId, B.FirstName+ '' + B.LastName as FullName, C.Title, A.WorkStartDate,A.WorkEndDate  from EmployeeProjectDetails A  join tblUsersEmployeesDetails B on A.EmployeeId = B.EmpId  
Join tblProjectDetails C on A.ProjectId = C.ProjectId   
Where A.ProjectId =@ProjectId
end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetProjectUsers]    Script Date: 1/2/2021 4:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[sp_GetProjectUsers]
as
begin
select A.EmployeeProjectId, B.FirstName+ '' + B.LastName as FullName, C.Title, A.WorkStartDate,A.WorkEndDate  from EmployeeProjectDetails A  join tblUsersEmployeesDetails B on A.EmployeeId = B.EmpId
Join tblProjectDetails C on A.ProjectId = C.ProjectId 
end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetUsersPerProject]    Script Date: 1/2/2021 4:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[sp_GetUsersPerProject]
@ProjectId int
as
begin
select A.EmployeeProjectId, B.FirstName+ '' + B.LastName as FullName, C.Title, A.WorkStartDate,A.WorkEndDate  from EmployeeProjectDetails A  join tblUsersEmployeesDetails B on A.EmployeeId = B.EmpId
Join tblProjectDetails C on A.ProjectId = C.ProjectId where A.ProjectId = @ProjectId
end
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertNewProject]    Script Date: 1/2/2021 4:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_InsertNewProject]
(@Title varchar(50), 
 @NoOfModules int,
 @Description varchar(200),
 @PlatForm varchar(50),
 @Client varchar(50),
 @ProjectStatus varchar(50),
 @projectStartDate varchar(50),
 @projectEndDate varchar(50))
as
begin
INSERT INTO dbo.tblProjectDetails
           (Title,NoOfModules,Description,PlatForm,Client,ProjectStatus,projectStartDate,projectEndDate)
     VALUES
           (@Title, @NoOfModules, @Description, @PlatForm, @Client, @ProjectStatus, @projectStartDate, @projectEndDate)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertUserDetails]    Script Date: 1/2/2021 4:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_InsertUserDetails](
@FirstName varchar(50),
@LastName varchar(50),
@Gender Varchar(50),
@Qualification varchar(50),
@DateOfJoin varchar(50),
@Desgination varchar(50),
@Address varchar(50),
@EmailId varchar(50),
@ContactNo varchar(50),
@RoleId int,
@UserName varchar(50),
@PassWord varchar(50)
)
as
begin
Insert into tblUsersEmployeesDetails (FirstName,LastName,Gender,Qualification,DateOfJoining,Designation,Address,EmailId,PhoneNo,RoleId)
values(@FirstName,@LastName,@Gender,@Qualification,@DateOfJoin,@Desgination,@Address,@EmailId,@ContactNo,@RoleId)
declare @AccountId int
set @AccountId=(select max(EmpId) from tblUsersEmployeesDetails)
declare @Date varchar(50)
set @Date=(select DateOfJoining from tblUsersEmployeesDetails  where EmpId=@AccountId)
set @Date=(select Convert(varchar(50),@Date,103))
update tblUsersEmployeesDetails set DateOfJoining=@Date where EmpId=@AccountId

Insert into tblUserLoginDetails values(@UserName,@PassWord,@RoleId)
end

GO
/****** Object:  StoredProcedure [dbo].[SP_LoginCheck]    Script Date: 1/2/2021 4:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_LoginCheck]
@username varchar(100),
                @pwd    varchar(100)
AS
BEGIN
                select * from [tblUserLoginDetails]
                where UserName COLLATE Latin1_general_CS_AS=@username
                and userpassword COLLATE Latin1_general_CS_AS=@pwd
END
GO
/****** Object:  StoredProcedure [dbo].[SP_LoginmployeeDetails]    Script Date: 1/2/2021 4:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_LoginmployeeDetails]    
 @userAccountId varchar(100)   
AS    
BEGIN    
 select * from tblUsersEmployeesDetails where empid = @userAccountId         
END 
GO
/****** Object:  StoredProcedure [dbo].[SP_ParticularEmployeeDetails]    Script Date: 1/2/2021 4:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ParticularEmployeeDetails]  
 @userAccountId varchar(100) 
AS  
BEGIN  
declare @Emp varchar(50)
set @Emp= (select EmpId from tblUserLoginDetails where UserAccountId = @userAccountId)
 select * from tblUsersEmployeesDetails where empid = @Emp       
END  
GO
/****** Object:  StoredProcedure [dbo].[SP_ProjectEmployee]    Script Date: 1/2/2021 4:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_ProjectEmployee](@ProjectId int)
as
begin
select * , FirstName +' '+ LastName as FullName from tblUsersEmployeesDetails e join EmployeeProjectDetails p
on e.EmpId = p.EmployeeId
where p.ProjectId = @ProjectId
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateProject]    Script Date: 1/2/2021 4:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_UpdateProject]
(@ProjectId int,
 @Title varchar(50),  
 @NoOfModules int,
 @Description varchar(200),
 @PlatForm varchar(50),
 @Client varchar(50),
 @ProjectStatus varchar(50),
 @projectStartDate varchar(50),
 @projectEndDate varchar(50))
as
begin

UPDATE tblProjectDetails
   SET Title = @Title
      ,NoOfModules = @NoOfModules
      ,Description = @Description
      ,PlatForm = @PlatForm
      ,Client = @Client
      ,ProjectStatus =  @ProjectStatus
      ,projectStartDate = @projectStartDate
      ,projectEndDate = @projectEndDate
 WHERE @ProjectId = @ProjectId
 end


GO
/****** Object:  StoredProcedure [dbo].[SP_UserDefects]    Script Date: 1/2/2021 4:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_UserDefects](  
@EmpId int)  
as
begin
select * from tblDefectDetails A join [tblProjectDetails] B on B.ProjectId = A.ProjectId 
where A.EmpId = @EmpId
end
GO
/****** Object:  StoredProcedure [dbo].[SP_UserDetails]    Script Date: 1/2/2021 4:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_UserDetails]  
                @username varchar(100),  
    @pwd varchar(100)  
AS  
BEGIN  
  
 select a.UserAccountId, a.USERNAME as LoginName, a.UserPassword, b.FirstName + '' +b.LastName as UserName ,a.EmpId, c.RoleName, b.RoleId from [dbo].[tblUserLoginDetails] a join [dbo].[tblUsersEmployeesDetails] b on  
 a.EmpId = b.EmpId join  [dbo].[tblRoles] c on c.RoleId = b.RoleId  
                where a.UserName COLLATE Latin1_general_CS_AS=@username  
                and userpassword COLLATE Latin1_general_CS_AS=@pwd  
END  
GO
/****** Object:  StoredProcedure [dbo].[sp_WinAddNewDefects]    Script Date: 1/2/2021 4:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[sp_WinAddNewDefects](    
@DefectName varchar(50),    
@UserAccountId varchar(20),    
@ProjectId varchar(50),    
@ModuleName varchar(50),    
@description varchar(max),    
@DefectTypeId varchar(20),    
@EmpId varchar(20),    
@Status varchar(50),    
@priority varchar(50)    
)    
as    
begin   
declare @Date varchar(50)    
set @Date=(select Convert(varchar(50),GetDate(),103))  
INSERT INTO tblDefectDetails(  
DefectName,UserAccountId,ProjectId, ModuleName, Description,DefectTypeId,EmpId, Status, Priority,SendingDate)  
 VALUES  
 (@DefectName,Convert( int,@UserAccountId),convert(int, @ProjectId), @ModuleName, @description,convert(int, @DefectTypeId), convert(int,@EmpId), @Status, @priority, @Date)  
 declare @DefectId int  
set @DefectId=(select max(DefectId) from tblDefectDetails)  
  
INSERT INTO tblDefectHistoryDetails  
 (DefectId ,AssignedFrom ,AssignedTo,Status,UpdatedDate,Comments,LoggedUserId)  
     VALUES  
           (@DefectId, Convert( int,@UserAccountId),  Convert( int,@EmpId) ,@Status,  @Date , 'NULL' ,Convert( int,@UserAccountId))  
  
 end  
  
GO
/****** Object:  StoredProcedure [dbo].[sp_WinAllDefectPendingReport]    Script Date: 1/2/2021 4:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[sp_WinAllDefectPendingReport](      
@UserName varchar(50))      
as      
begin      
 Select t1.DefectId, t1.DefectName,  t1.ModuleName,t3.DefectTypeName,
 t1.Description, t1.Priority, 
 t1.Status, t1.SendingDate as PostedDate
from tblDefectDetails t1    
inner join tblProjectDetails t2    
on (t1.ProjectId=t2.ProjectId)    
 join tblDefectTypes t3    
on (t1.DefectTypeId= t3.DefectTypeId)     
join tblUsersEmployeesDetails t4    
on (t1.EmpId=t4.EmpId)    
where t1.EmpId = @UserName  and t1.Status = 'Pending'    
end    
GO
/****** Object:  StoredProcedure [dbo].[sp_WinDefectHistory]    Script Date: 1/2/2021 4:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_WinDefectHistory]
as
Begin
select B.DefectName, B.ModuleName, C.Title as Application , 
D.FirstName +''+ D.LastName as AssignedUser , E.FirstName + '' + E.LastName as AssignedBy
, B.Priority, A.Status, A.UpdatedDate 
from tblDefectHistoryDetails A
join tblDefectDetails B on A.DefectId = B.DefectId
join tblProjectDetails C on C.ProjectId = B.ProjectId
join tblUsersEmployeesDetails D on D.EmpId = A.AssignedTo
join tblUsersEmployeesDetails E on E.EmpId = A.AssignedFrom
End
GO
/****** Object:  StoredProcedure [dbo].[sp_WinEditDefectPendingReport]    Script Date: 1/2/2021 4:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[sp_WinEditDefectPendingReport](          
@DefectId varchar(50))          
as          
begin          
 Select t1.DefectId, t1.EmpId, t1.DefectName,  t1.ModuleName,t3.DefectTypeName,    
 t1.Description, t1.Priority,  t2.Title ,  t1.ProjectId,t1.DefectTypeId,
 t1.Status, t1.SendingDate as PostedDate    
from tblDefectDetails t1        
inner join tblProjectDetails t2        
on (t1.ProjectId=t2.ProjectId)        
 join tblDefectTypes t3        
on (t1.DefectTypeId= t3.DefectTypeId)         
join tblUsersEmployeesDetails t4        
on (t1.EmpId=t4.EmpId)        
where t1.DefectId = @DefectId    
end   
GO
/****** Object:  StoredProcedure [dbo].[sp_winGetDetsByAppln]    Script Date: 1/2/2021 4:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_winGetDetsByAppln]
@ProjectId Varchar(50)
as
begin

select A.DefectName, A.ModuleName, A.Description, A.Status, A.Priority ,
B.DefectTypeName, A.EmpId as AssignedUser, C.FirstName + ' ' + C.LastName as UserName
from tblDefectDetails A 
join tblDefectTypes B on A.DefectTypeId = B.DefectTypeId
join tblUsersEmployeesDetails C  on A.EmpId = C.EmpId
where A.ProjectId = @ProjectId
end
GO
/****** Object:  StoredProcedure [dbo].[sp_winGetempbyApp]    Script Date: 1/2/2021 4:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_winGetempbyApp]
@ProjectId int
as
begin
select B.EmpId, B.FirstName + '' + B.LastName as FullName from [dbo].[EmployeeProjectDetails] A
join [dbo].[tblUsersEmployeesDetails] B on A.EmployeeId = B.EmpId
where ProjectId =@ProjectId
end
GO
/****** Object:  StoredProcedure [dbo].[sp_WinLoginmployeeDetails]    Script Date: 1/2/2021 4:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_WinLoginmployeeDetails]      
 @userAccountId varchar(100)     
AS      
BEGIN      
 select * , FirstName + ' '+ LastName as FullName from tblUsersEmployeesDetails where empid = @userAccountId           
END 
GO
/****** Object:  StoredProcedure [dbo].[spAllDefectPendingReport]    Script Date: 1/2/2021 4:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[spAllDefectPendingReport](    
@UserName varchar(50))    
as    
begin    
 Select *  
from tblDefectDetails t1  
inner join tblProjectDetails t2  
on (t1.ProjectId=t2.ProjectId)  
 join tblDefectTypes t3  
on (t1.DefectTypeId= t3.DefectTypeId)   
join tblUsersEmployeesDetails t4  
on (t1.EmpId=t4.EmpId)  
where t1.EmpId = @UserName  and t1.Status = 'Pending'  
end  
  
GO
/****** Object:  StoredProcedure [dbo].[spAllDefectReport]    Script Date: 1/2/2021 4:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[spAllDefectReport](  
@UserName varchar(50))  
as  
begin  
 Select *
from tblDefectDetails t1
inner join tblProjectDetails t2
on (t1.ProjectId=t2.ProjectId)
 join tblDefectTypes t3
on (t1.DefectTypeId= t3.DefectTypeId) 
join tblUsersEmployeesDetails t4
on (t1.EmpId=t4.EmpId)
where t1.EmpId = @UserName  
end


  
GO
/****** Object:  StoredProcedure [dbo].[spSelectedDefectReport]    Script Date: 1/2/2021 4:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[spSelectedDefectReport](  
@DefectId varchar(50))  
as  
begin  
 select * from tblDefectDetails A join tblDefectTypes B on A.DefectTypeId = B.DefectTypeId   
 join tblProjectDetails P on P.ProjectId = A.ProjectId join tblUsersEmployeesDetails E on   
 A.EmpId = E.EmpId  
 where A.DefectId = @DefectId  
end
GO
/****** Object:  StoredProcedure [dbo].[spUpdateDefectStatus]    Script Date: 1/2/2021 4:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[spUpdateDefectStatus](  
@DefectId int,  
@DefectName varchar(50),  
@UserAccountId int,  
@ProjectId varchar(50),  
@ModuleName varchar(50),  
@description varchar(max),  
@DefectTypeId int,  
@EmpId int,  
@Status varchar(50),  
@priority varchar(50)  
)  
as  
begin  
declare @Date varchar(50)  
set @Date=(select Convert(varchar(50),GetDate(),103))  
update tblDefectDetails set DefectName = @DefectName, UserAccountId=@UserAccountId, ProjectId= @ProjectId,  
ModuleName = @ModuleName, Description = @description, DefectTypeId = @DefectTypeId,  
EmpId = @EmpId, Status=@Status,Priority =@priority,  
SendingDate = @Date where DefectId=@DefectId  

INSERT INTO tblDefectHistoryDetails  
 (DefectId ,AssignedFrom ,AssignedTo,Status,UpdatedDate,Comments,LoggedUserId)  
     VALUES  
           (@DefectId, @UserAccountId,  @EmpId ,@Status,  @Date , 'NULL' ,@UserAccountId)  

end
GO
USE [master]
GO
ALTER DATABASE [BugTracker] SET  READ_WRITE 
GO
