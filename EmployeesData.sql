USE [EmployeesSystem]
GO
SET ANSI_PADDING OFF
GO

SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([Id], [EmployeeName], [EmployeeTitle], [ManagerId]) VALUES (1, N'Diaaeldin', N'Software Engineer III', 2)
INSERT [dbo].[Employees] ([Id], [EmployeeName], [EmployeeTitle], [ManagerId]) VALUES (2, N'Hany', N'Team Leader', NULL)
INSERT [dbo].[Employees] ([Id], [EmployeeName], [EmployeeTitle], [ManagerId]) VALUES (3, N'Aly', N'Technical Advisor', 2)
INSERT [dbo].[Employees] ([Id], [EmployeeName], [EmployeeTitle], [ManagerId]) VALUES (4, N'Mohsen', N'Team Leader', NULL)
SET IDENTITY_INSERT [dbo].[Employees] OFF
