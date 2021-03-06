USE [BugTracker]
GO
SET IDENTITY_INSERT [dbo].[EmployeeProjectDetails] ON 

INSERT [dbo].[EmployeeProjectDetails] ([EmployeeProjectId], [EmployeeId], [ProjectId], [WorkStartDate], [WorkEndDate], [AssignedBy]) VALUES (1, 2, 1, N'6/2/2020', N'6/2/2020', 1)
INSERT [dbo].[EmployeeProjectDetails] ([EmployeeProjectId], [EmployeeId], [ProjectId], [WorkStartDate], [WorkEndDate], [AssignedBy]) VALUES (3, 3, 1, N'6/2/2020', N'6/2/2020', 1)
INSERT [dbo].[EmployeeProjectDetails] ([EmployeeProjectId], [EmployeeId], [ProjectId], [WorkStartDate], [WorkEndDate], [AssignedBy]) VALUES (4, 3, 2, N'6/2/2020', N'6/2/2020', 1)
INSERT [dbo].[EmployeeProjectDetails] ([EmployeeProjectId], [EmployeeId], [ProjectId], [WorkStartDate], [WorkEndDate], [AssignedBy]) VALUES (5, 4, 1, N'6/2/2020', N'6/2/2020', 1)
INSERT [dbo].[EmployeeProjectDetails] ([EmployeeProjectId], [EmployeeId], [ProjectId], [WorkStartDate], [WorkEndDate], [AssignedBy]) VALUES (6, 4, 2, N'6/2/2020', N'6/2/2020', 1)
INSERT [dbo].[EmployeeProjectDetails] ([EmployeeProjectId], [EmployeeId], [ProjectId], [WorkStartDate], [WorkEndDate], [AssignedBy]) VALUES (7, 5, 1, N'6/2/2020', N'6/2/2020', 1)
INSERT [dbo].[EmployeeProjectDetails] ([EmployeeProjectId], [EmployeeId], [ProjectId], [WorkStartDate], [WorkEndDate], [AssignedBy]) VALUES (8, 5, 2, N'6/2/2020', N'6/2/2020', 1)
INSERT [dbo].[EmployeeProjectDetails] ([EmployeeProjectId], [EmployeeId], [ProjectId], [WorkStartDate], [WorkEndDate], [AssignedBy]) VALUES (9, 1, 1, N'6/6/202', N'5/6/2021', 2)
INSERT [dbo].[EmployeeProjectDetails] ([EmployeeProjectId], [EmployeeId], [ProjectId], [WorkStartDate], [WorkEndDate], [AssignedBy]) VALUES (10, 1, 3, N'3/5/2020', N'3/5/2020', 2)
INSERT [dbo].[EmployeeProjectDetails] ([EmployeeProjectId], [EmployeeId], [ProjectId], [WorkStartDate], [WorkEndDate], [AssignedBy]) VALUES (12, 3, 4, N'3/5/2020', N'3/5/2020', 1)
INSERT [dbo].[EmployeeProjectDetails] ([EmployeeProjectId], [EmployeeId], [ProjectId], [WorkStartDate], [WorkEndDate], [AssignedBy]) VALUES (13, 4, 3, N'3/5/2020', N'3/5/2020', 1)
INSERT [dbo].[EmployeeProjectDetails] ([EmployeeProjectId], [EmployeeId], [ProjectId], [WorkStartDate], [WorkEndDate], [AssignedBy]) VALUES (14, 5, 3, N'12/30/2020', N'1/1/2021', 49)
INSERT [dbo].[EmployeeProjectDetails] ([EmployeeProjectId], [EmployeeId], [ProjectId], [WorkStartDate], [WorkEndDate], [AssignedBy]) VALUES (15, 2, 4, N'12/31/2020', N'1/7/2021', 2)
INSERT [dbo].[EmployeeProjectDetails] ([EmployeeProjectId], [EmployeeId], [ProjectId], [WorkStartDate], [WorkEndDate], [AssignedBy]) VALUES (16, 4, 7, N'12/1/2020', N'12/22/2020', 2)
INSERT [dbo].[EmployeeProjectDetails] ([EmployeeProjectId], [EmployeeId], [ProjectId], [WorkStartDate], [WorkEndDate], [AssignedBy]) VALUES (17, 6, 7, N'12/29/2020', N'4/9/2021', 2)
SET IDENTITY_INSERT [dbo].[EmployeeProjectDetails] OFF
SET IDENTITY_INSERT [dbo].[tblDefectDetails] ON 

INSERT [dbo].[tblDefectDetails] ([DefectId], [DefectName], [UserAccountId], [ProjectId], [ModuleName], [Description], [DefectTypeId], [EmpId], [Status], [Priority], [SendingDate]) VALUES (501, N'test', 1, N'1', N'test', N'test', 107, N'2', N'Pending', N'Medium', N'26/12/2020')
INSERT [dbo].[tblDefectDetails] ([DefectId], [DefectName], [UserAccountId], [ProjectId], [ModuleName], [Description], [DefectTypeId], [EmpId], [Status], [Priority], [SendingDate]) VALUES (502, N'Arithmetic Defect', 1, N'1', N'Admin Module', N'test app', 105, N'3', N'Pending', N'High', N'26/12/2020')
INSERT [dbo].[tblDefectDetails] ([DefectId], [DefectName], [UserAccountId], [ProjectId], [ModuleName], [Description], [DefectTypeId], [EmpId], [Status], [Priority], [SendingDate]) VALUES (503, N'Testing', 1, N'2', N'User Module', N'test for this success test', 105, N'3', N'Pending', N'High', N'26/12/2020')
INSERT [dbo].[tblDefectDetails] ([DefectId], [DefectName], [UserAccountId], [ProjectId], [ModuleName], [Description], [DefectTypeId], [EmpId], [Status], [Priority], [SendingDate]) VALUES (504, N'array defect', 2, N'2', N'Covert EPMS', N'completed all defets', 105, N'5', N'Pending', N'High', N'27/12/2020')
INSERT [dbo].[tblDefectDetails] ([DefectId], [DefectName], [UserAccountId], [ProjectId], [ModuleName], [Description], [DefectTypeId], [EmpId], [Status], [Priority], [SendingDate]) VALUES (505, N'test defect', 2, N'2', N'testing', N'Auto-increment allows a unique number to be generated automatically when a new record is inserted into a table.', 105, N'2', N'Pending', N'High', N'28/12/2020')
INSERT [dbo].[tblDefectDetails] ([DefectId], [DefectName], [UserAccountId], [ProjectId], [ModuleName], [Description], [DefectTypeId], [EmpId], [Status], [Priority], [SendingDate]) VALUES (506, N'aaa', 1, N'1', N'aaa', N'aaa', 106, N'1', N'Pending', N'Low', N'12/12/20202')
INSERT [dbo].[tblDefectDetails] ([DefectId], [DefectName], [UserAccountId], [ProjectId], [ModuleName], [Description], [DefectTypeId], [EmpId], [Status], [Priority], [SendingDate]) VALUES (507, N'aa test defect', 2, N'1', N'slect module', N'ok', 105, N'501', N'Pending', N'High', N'02/01/2021')
INSERT [dbo].[tblDefectDetails] ([DefectId], [DefectName], [UserAccountId], [ProjectId], [ModuleName], [Description], [DefectTypeId], [EmpId], [Status], [Priority], [SendingDate]) VALUES (508, N'array defect', 2, N'3', N'testing', N'abcdefg', 107, N'4', N'Pending', N'High', N'28/12/2020')
INSERT [dbo].[tblDefectDetails] ([DefectId], [DefectName], [UserAccountId], [ProjectId], [ModuleName], [Description], [DefectTypeId], [EmpId], [Status], [Priority], [SendingDate]) VALUES (509, N'array defect', 1, N'3', N'testing', N'wecome completed', 105, N'1', N'Completed', N'High', N'28/12/2020')
INSERT [dbo].[tblDefectDetails] ([DefectId], [DefectName], [UserAccountId], [ProjectId], [ModuleName], [Description], [DefectTypeId], [EmpId], [Status], [Priority], [SendingDate]) VALUES (510, N'array defect', 1, N'3', N'Covert EPMS', N'fxvbcvcvnv', 105, N'4', N'Pending', N'High', N'28/12/2020')
INSERT [dbo].[tblDefectDetails] ([DefectId], [DefectName], [UserAccountId], [ProjectId], [ModuleName], [Description], [DefectTypeId], [EmpId], [Status], [Priority], [SendingDate]) VALUES (511, N'array defect', 2, N'7', N'Report Modules', N'soon to be completed the defect', 106, N'6', N'Pending', N'medium', N'29/12/2020')
INSERT [dbo].[tblDefectDetails] ([DefectId], [DefectName], [UserAccountId], [ProjectId], [ModuleName], [Description], [DefectTypeId], [EmpId], [Status], [Priority], [SendingDate]) VALUES (513, N'a', 2, N'1', N'a', N'hello', 105, N'501', N'Pending', N'a', N'02/01/2021')
INSERT [dbo].[tblDefectDetails] ([DefectId], [DefectName], [UserAccountId], [ProjectId], [ModuleName], [Description], [DefectTypeId], [EmpId], [Status], [Priority], [SendingDate]) VALUES (514, N'a', 1, N'1', N'aa', N'a', 105, N'2', N'Pending', N'aaa', N'01/01/2021')
INSERT [dbo].[tblDefectDetails] ([DefectId], [DefectName], [UserAccountId], [ProjectId], [ModuleName], [Description], [DefectTypeId], [EmpId], [Status], [Priority], [SendingDate]) VALUES (515, N'test', 2, N'7', N'test', N'done', 108, N'501', N'Completed', N'high', N'02/01/2021')
SET IDENTITY_INSERT [dbo].[tblDefectDetails] OFF
SET IDENTITY_INSERT [dbo].[tblDefectHistoryDetails] ON 

INSERT [dbo].[tblDefectHistoryDetails] ([DefectHistoryId], [DefectId], [AssignedFrom], [AssignedTo], [Status], [UpdatedDate], [Comments], [LoggedUserId]) VALUES (1, 501, N'1', N'2', N'Created', N'12/25/2020', N'2 day prioroty', 1)
INSERT [dbo].[tblDefectHistoryDetails] ([DefectHistoryId], [DefectId], [AssignedFrom], [AssignedTo], [Status], [UpdatedDate], [Comments], [LoggedUserId]) VALUES (3, 501, N'1', N'2', N'Inprogess', N'12/25/2020', N'will complete soon', 2)
INSERT [dbo].[tblDefectHistoryDetails] ([DefectHistoryId], [DefectId], [AssignedFrom], [AssignedTo], [Status], [UpdatedDate], [Comments], [LoggedUserId]) VALUES (4, 504, N'1', N'5', N'Pending', N'27/12/2020', N'NULL', 1)
INSERT [dbo].[tblDefectHistoryDetails] ([DefectHistoryId], [DefectId], [AssignedFrom], [AssignedTo], [Status], [UpdatedDate], [Comments], [LoggedUserId]) VALUES (5, 505, N'1', N'2', N'Pending', N'27/12/2020', N'NULL', 1)
INSERT [dbo].[tblDefectHistoryDetails] ([DefectHistoryId], [DefectId], [AssignedFrom], [AssignedTo], [Status], [UpdatedDate], [Comments], [LoggedUserId]) VALUES (6, 507, N'1', N'2', N'Pending', N'28/12/2020', N'NULL', 1)
INSERT [dbo].[tblDefectHistoryDetails] ([DefectHistoryId], [DefectId], [AssignedFrom], [AssignedTo], [Status], [UpdatedDate], [Comments], [LoggedUserId]) VALUES (7, 508, N'2', N'4', N'Pending', N'28/12/2020', N'NULL', 2)
INSERT [dbo].[tblDefectHistoryDetails] ([DefectHistoryId], [DefectId], [AssignedFrom], [AssignedTo], [Status], [UpdatedDate], [Comments], [LoggedUserId]) VALUES (8, 505, N'2', N'2', N'Pending', N'28/12/2020', N'NULL', 2)
INSERT [dbo].[tblDefectHistoryDetails] ([DefectHistoryId], [DefectId], [AssignedFrom], [AssignedTo], [Status], [UpdatedDate], [Comments], [LoggedUserId]) VALUES (9, 509, N'1', N'1', N'Pending', N'28/12/2020', N'NULL', 1)
INSERT [dbo].[tblDefectHistoryDetails] ([DefectHistoryId], [DefectId], [AssignedFrom], [AssignedTo], [Status], [UpdatedDate], [Comments], [LoggedUserId]) VALUES (10, 510, N'1', N'4', N'Pending', N'28/12/2020', N'NULL', 1)
INSERT [dbo].[tblDefectHistoryDetails] ([DefectHistoryId], [DefectId], [AssignedFrom], [AssignedTo], [Status], [UpdatedDate], [Comments], [LoggedUserId]) VALUES (11, 509, N'1', N'1', N'Pending', N'28/12/2020', N'NULL', 1)
INSERT [dbo].[tblDefectHistoryDetails] ([DefectHistoryId], [DefectId], [AssignedFrom], [AssignedTo], [Status], [UpdatedDate], [Comments], [LoggedUserId]) VALUES (12, 509, N'1', N'1', N'Completed', N'28/12/2020', N'NULL', 1)
INSERT [dbo].[tblDefectHistoryDetails] ([DefectHistoryId], [DefectId], [AssignedFrom], [AssignedTo], [Status], [UpdatedDate], [Comments], [LoggedUserId]) VALUES (13, 511, N'2', N'6', N'Pending', N'29/12/2020', N'NULL', 2)
INSERT [dbo].[tblDefectHistoryDetails] ([DefectHistoryId], [DefectId], [AssignedFrom], [AssignedTo], [Status], [UpdatedDate], [Comments], [LoggedUserId]) VALUES (14, 513, N'1', N'2', N'Pending', N'01/01/2021', N'NULL', 1)
INSERT [dbo].[tblDefectHistoryDetails] ([DefectHistoryId], [DefectId], [AssignedFrom], [AssignedTo], [Status], [UpdatedDate], [Comments], [LoggedUserId]) VALUES (15, 514, N'1', N'2', N'Pending', N'01/01/2021', N'NULL', 1)
INSERT [dbo].[tblDefectHistoryDetails] ([DefectHistoryId], [DefectId], [AssignedFrom], [AssignedTo], [Status], [UpdatedDate], [Comments], [LoggedUserId]) VALUES (16, 515, N'2', N'2', N'Pending', N'02/01/2021', N'NULL', 2)
INSERT [dbo].[tblDefectHistoryDetails] ([DefectHistoryId], [DefectId], [AssignedFrom], [AssignedTo], [Status], [UpdatedDate], [Comments], [LoggedUserId]) VALUES (17, 515, N'2', N'501', N'Completed', N'02/01/2021', N'NULL', 2)
INSERT [dbo].[tblDefectHistoryDetails] ([DefectHistoryId], [DefectId], [AssignedFrom], [AssignedTo], [Status], [UpdatedDate], [Comments], [LoggedUserId]) VALUES (18, 507, N'2', N'501', N'Pending', N'02/01/2021', N'NULL', 2)
INSERT [dbo].[tblDefectHistoryDetails] ([DefectHistoryId], [DefectId], [AssignedFrom], [AssignedTo], [Status], [UpdatedDate], [Comments], [LoggedUserId]) VALUES (19, 513, N'2', N'501', N'Pending', N'02/01/2021', N'NULL', 2)
SET IDENTITY_INSERT [dbo].[tblDefectHistoryDetails] OFF
SET IDENTITY_INSERT [dbo].[tblDefectTypes] ON 

INSERT [dbo].[tblDefectTypes] ([DefectTypeId], [DefectTypeName], [Description], [Status], [Priority]) VALUES (105, N'Arithmetic Defects', N'asa', N'Rare', N'High')
INSERT [dbo].[tblDefectTypes] ([DefectTypeId], [DefectTypeName], [Description], [Status], [Priority]) VALUES (106, N'Logical Defects', N'Logical Defects', N'often', N'Low')
INSERT [dbo].[tblDefectTypes] ([DefectTypeId], [DefectTypeName], [Description], [Status], [Priority]) VALUES (107, N'Syntax Defects', N'Syntax Defects', N'Rare', N'High')
INSERT [dbo].[tblDefectTypes] ([DefectTypeId], [DefectTypeName], [Description], [Status], [Priority]) VALUES (108, N'Multithreading Defects', N'Multithreading Defects', N'often', N'Medium')
INSERT [dbo].[tblDefectTypes] ([DefectTypeId], [DefectTypeName], [Description], [Status], [Priority]) VALUES (109, N'Interface Defects', N'Interface Defects', N'Rare', N'Medium')
INSERT [dbo].[tblDefectTypes] ([DefectTypeId], [DefectTypeName], [Description], [Status], [Priority]) VALUES (110, N'Performance Defects', N'Performance Defects', N'Rare', N'Low')
SET IDENTITY_INSERT [dbo].[tblDefectTypes] OFF
SET IDENTITY_INSERT [dbo].[tblProjectDetails] ON 

INSERT [dbo].[tblProjectDetails] ([ProjectId], [Title], [NoOfModules], [Description], [PlatForm], [Client], [ProjectStatus], [projectStartDate], [projectEndDate]) VALUES (1, N'NDTV', 5, N'NDTV', N'asp.net', N'no', N'started', N'5/5/2020', NULL)
INSERT [dbo].[tblProjectDetails] ([ProjectId], [Title], [NoOfModules], [Description], [PlatForm], [Client], [ProjectStatus], [projectStartDate], [projectEndDate]) VALUES (2, N'EPMS', 3, N'EPMS', N'java', N'no', N'progress', N'6/6/2020', NULL)
INSERT [dbo].[tblProjectDetails] ([ProjectId], [Title], [NoOfModules], [Description], [PlatForm], [Client], [ProjectStatus], [projectStartDate], [projectEndDate]) VALUES (3, N'GoogleEx', 10, N'testingg', N'asp.net', N'no', N'Progress', N'6/6/2020', NULL)
INSERT [dbo].[tblProjectDetails] ([ProjectId], [Title], [NoOfModules], [Description], [PlatForm], [Client], [ProjectStatus], [projectStartDate], [projectEndDate]) VALUES (4, N'Bug Tracker', 5, N'about Bugs', N'C#', N'no', N'progess', N'9/9/2020', NULL)
INSERT [dbo].[tblProjectDetails] ([ProjectId], [Title], [NoOfModules], [Description], [PlatForm], [Client], [ProjectStatus], [projectStartDate], [projectEndDate]) VALUES (5, N'SCMS', 10, N'test', N'Java', N'Ultra pvt Ltd.,', N'open', N'1/1/2021', N'3/19/2021')
INSERT [dbo].[tblProjectDetails] ([ProjectId], [Title], [NoOfModules], [Description], [PlatForm], [Client], [ProjectStatus], [projectStartDate], [projectEndDate]) VALUES (6, N'GoogleEx', 10, N'google google', N'asp.net', N'no', N'Progress', N'6/6/2020', N'')
INSERT [dbo].[tblProjectDetails] ([ProjectId], [Title], [NoOfModules], [Description], [PlatForm], [Client], [ProjectStatus], [projectStartDate], [projectEndDate]) VALUES (7, N'Bug Tracker', 6, N'Bug Tracker project', N'C#.Net', N'xyz', N'open', N'12/29/2020', N'7/20/2021')
SET IDENTITY_INSERT [dbo].[tblProjectDetails] OFF
SET IDENTITY_INSERT [dbo].[tblRoles] ON 

INSERT [dbo].[tblRoles] ([RoleId], [RoleName], [Description]) VALUES (1, N'Admin', N'Admin')
INSERT [dbo].[tblRoles] ([RoleId], [RoleName], [Description]) VALUES (2, N'Developer', N'Developer')
INSERT [dbo].[tblRoles] ([RoleId], [RoleName], [Description]) VALUES (3, N'Senior Developer', N'SD')
INSERT [dbo].[tblRoles] ([RoleId], [RoleName], [Description]) VALUES (4, N'Manager', N'M')
INSERT [dbo].[tblRoles] ([RoleId], [RoleName], [Description]) VALUES (5, N'Senior Manager', N'SM')
INSERT [dbo].[tblRoles] ([RoleId], [RoleName], [Description]) VALUES (6, N'Associate', N'A')
INSERT [dbo].[tblRoles] ([RoleId], [RoleName], [Description]) VALUES (7, N'Senior Associate', N'SA')
INSERT [dbo].[tblRoles] ([RoleId], [RoleName], [Description]) VALUES (8, N'IT Analyst', N'ITA')
SET IDENTITY_INSERT [dbo].[tblRoles] OFF
SET IDENTITY_INSERT [dbo].[tblUserLoginDetails] ON 

INSERT [dbo].[tblUserLoginDetails] ([UserAccountId], [UserName], [UserPassword], [EmpId]) VALUES (1, N'Kathy', N'Kathy', 2)
INSERT [dbo].[tblUserLoginDetails] ([UserAccountId], [UserName], [UserPassword], [EmpId]) VALUES (2, N'matt', N'matt', 1)
INSERT [dbo].[tblUserLoginDetails] ([UserAccountId], [UserName], [UserPassword], [EmpId]) VALUES (3, N'admin', N'admin', 3)
INSERT [dbo].[tblUserLoginDetails] ([UserAccountId], [UserName], [UserPassword], [EmpId]) VALUES (4, N'mike', N'mike', 4)
INSERT [dbo].[tblUserLoginDetails] ([UserAccountId], [UserName], [UserPassword], [EmpId]) VALUES (5, N'John', N'John', 5)
INSERT [dbo].[tblUserLoginDetails] ([UserAccountId], [UserName], [UserPassword], [EmpId]) VALUES (6, N'roy', N'roy', 8)
SET IDENTITY_INSERT [dbo].[tblUserLoginDetails] OFF
SET IDENTITY_INSERT [dbo].[tblUsersEmployeesDetails] ON 

INSERT [dbo].[tblUsersEmployeesDetails] ([EmpId], [FirstName], [LastName], [Gender], [Qualification], [DateOfJoining], [Designation], [Address], [EmailId], [PhoneNo], [RoleId]) VALUES (1, N'Mathew', N'John', N'M', N'mca', N'12/12/2007', N'Admin', N'USA', N'Matt@gmail.com', N'123456789', 1)
INSERT [dbo].[tblUsersEmployeesDetails] ([EmpId], [FirstName], [LastName], [Gender], [Qualification], [DateOfJoining], [Designation], [Address], [EmailId], [PhoneNo], [RoleId]) VALUES (2, N'Katheryn', N'Christoper', N'F', N'Msc', N'01/03/2012', N'SA', N'USA', N'Kathy@gmail.com', N'123456778', 1)
INSERT [dbo].[tblUsersEmployeesDetails] ([EmpId], [FirstName], [LastName], [Gender], [Qualification], [DateOfJoining], [Designation], [Address], [EmailId], [PhoneNo], [RoleId]) VALUES (3, N'Admin', N'Admin', N'M', N'B.E', N'10/1/2009', N'A', N'USA', N'AdminUser@webmail.com', N'5342538', 2)
INSERT [dbo].[tblUsersEmployeesDetails] ([EmpId], [FirstName], [LastName], [Gender], [Qualification], [DateOfJoining], [Designation], [Address], [EmailId], [PhoneNo], [RoleId]) VALUES (4, N'Michael', N'Richard', N'F', N'B.E', N'6/6/2008', N'M', N'USA', N'Mike2@webmail.com', N'767364726', 5)
INSERT [dbo].[tblUsersEmployeesDetails] ([EmpId], [FirstName], [LastName], [Gender], [Qualification], [DateOfJoining], [Designation], [Address], [EmailId], [PhoneNo], [RoleId]) VALUES (5, N'Johnson', N'Michael', N'Male', N'test', N'9/3/2019', N'test', N'USA', N'John@yahoo.com', N'3423423423', 8)
INSERT [dbo].[tblUsersEmployeesDetails] ([EmpId], [FirstName], [LastName], [Gender], [Qualification], [DateOfJoining], [Designation], [Address], [EmailId], [PhoneNo], [RoleId]) VALUES (6, N'Roy', N'Donald', N'Male', N'MCA', N'12/29/2020', N'Team Lead', N'Hartford, CT, USA', N'Roy@webmail.com', N'20111111', 8)
SET IDENTITY_INSERT [dbo].[tblUsersEmployeesDetails] OFF
