USE [HAMS_DB]
GO
SET IDENTITY_INSERT [dbo].[Patients] ON 
GO
INSERT [dbo].[Patients] ([Id], [PatientUHID], [FirstName], [MiddleName], [LastName], [MobileNo], [EmailID], [BloodGroup], [Gender], [DateOfBirth], [Address], [City], [ZipCode], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn]) VALUES (1, N'UHID00001', N'Sagar', N'Sharad', N'Patil', N'9421475805', N'test@gmail.com', N'B+', N'male', CAST(N'1994-03-23T18:30:00.0000000' AS DateTime2), N'Lonkheda', N'Shahada', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Patients] ([Id], [PatientUHID], [FirstName], [MiddleName], [LastName], [MobileNo], [EmailID], [BloodGroup], [Gender], [DateOfBirth], [Address], [City], [ZipCode], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn]) VALUES (2, N'UHID00002', N'Ashwini', NULL, N'Patil', N'9876543210', N'test@test.com', NULL, N'female', CAST(N'2002-01-22T18:30:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Patients] OFF
GO
SET IDENTITY_INSERT [dbo].[Departments] ON 
GO
INSERT [dbo].[Departments] ([Id], [DepartmentName], [DepartmentDesc], [IsAdminDepartment]) VALUES (1, N'Account', N'Patient Admission, billing and discharge', 1)
GO
INSERT [dbo].[Departments] ([Id], [DepartmentName], [DepartmentDesc], [IsAdminDepartment]) VALUES (2, N'Nephrology', N'Kidney Treatment', 0)
GO
INSERT [dbo].[Departments] ([Id], [DepartmentName], [DepartmentDesc], [IsAdminDepartment]) VALUES (3, N'Cardiology', N'Heart Disease', 0)
GO
INSERT [dbo].[Departments] ([Id], [DepartmentName], [DepartmentDesc], [IsAdminDepartment]) VALUES (4, N'Oncology', N'Cancer Treatment', 0)
GO
INSERT [dbo].[Departments] ([Id], [DepartmentName], [DepartmentDesc], [IsAdminDepartment]) VALUES (5, N'Ayurvedic', N'Ayurvedic Treatment', 0)
GO
INSERT [dbo].[Departments] ([Id], [DepartmentName], [DepartmentDesc], [IsAdminDepartment]) VALUES (1002, N'Admin', N'Hospital Owner', 1)
GO
SET IDENTITY_INSERT [dbo].[Departments] OFF
GO
SET IDENTITY_INSERT [dbo].[UserRoles] ON 
GO
INSERT [dbo].[UserRoles] ([Id], [RoleName], [RoleDescription]) VALUES (1, N'Admin', N'Admin')
GO
INSERT [dbo].[UserRoles] ([Id], [RoleName], [RoleDescription]) VALUES (2, N'Doctor', N'Doctor')
GO
INSERT [dbo].[UserRoles] ([Id], [RoleName], [RoleDescription]) VALUES (3, N'Accountant', N'Accountant')
GO
INSERT [dbo].[UserRoles] ([Id], [RoleName], [RoleDescription]) VALUES (4, N'Nurse', N'Nurse')
GO
SET IDENTITY_INSERT [dbo].[UserRoles] OFF
GO
SET IDENTITY_INSERT [dbo].[Staffs] ON 
GO
INSERT [dbo].[Staffs] ([Id], [StaffId], [FirstName], [MiddleName], [LastName], [MobileNo], [EmailId], [Address], [City], [ZipCode], [Gender], [DateOfBirth], [JoiningDate], [IsPermanent], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [DepartmentsId], [UserRoleId]) VALUES (2, N'S-00001', N'Ashwini', N'Rajendra', N'Patil', N'9876543201', N'test.11@gmail.com', N'Panipat', N'Panipat', N'345267', N'female', CAST(N'1997-08-30T18:30:00.0000000' AS DateTime2), CAST(N'2021-05-27T18:30:00.0000000' AS DateTime2), 1, N'Admin', CAST(N'2022-06-04T17:50:15.7581159' AS DateTime2), N'Admin', CAST(N'2022-06-12T21:15:22.7229752' AS DateTime2), 4, 1)
GO
INSERT [dbo].[Staffs] ([Id], [StaffId], [FirstName], [MiddleName], [LastName], [MobileNo], [EmailId], [Address], [City], [ZipCode], [Gender], [DateOfBirth], [JoiningDate], [IsPermanent], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [DepartmentsId], [UserRoleId]) VALUES (3, N'S-00002', N'Rajiv', N'Hari', N'Bhatia', N'1234567890', N'ak@akworld.com', N'Lokhnadwala', N'Mumbai', N'400001', N'male', CAST(N'1980-10-31T06:48:00.0000000' AS DateTime2), CAST(N'2022-06-04T12:18:55.0000000' AS DateTime2), 1, N'Admin', CAST(N'2022-06-04T17:53:02.1348546' AS DateTime2), N'Admin', CAST(N'2022-06-04T17:53:02.1348569' AS DateTime2), 1, 2)
GO
INSERT [dbo].[Staffs] ([Id], [StaffId], [FirstName], [MiddleName], [LastName], [MobileNo], [EmailId], [Address], [City], [ZipCode], [Gender], [DateOfBirth], [JoiningDate], [IsPermanent], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [DepartmentsId], [UserRoleId]) VALUES (4, N'S-00001', N'Manushi', N'A', N'Chhillar', N'9876543202', N'test@gmail.com', N'Panipat', N'Panipat', N'345267', N'female', CAST(N'2000-06-28T12:18:00.0000000' AS DateTime2), CAST(N'2022-06-04T12:18:55.0000000' AS DateTime2), 1, NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1002, 2)
GO
INSERT [dbo].[Staffs] ([Id], [StaffId], [FirstName], [MiddleName], [LastName], [MobileNo], [EmailId], [Address], [City], [ZipCode], [Gender], [DateOfBirth], [JoiningDate], [IsPermanent], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [DepartmentsId], [UserRoleId]) VALUES (5, N'S-00003', N'Ankita', N'P', N'Chaudhari', N'9876543203', N'test1@gmail.com', N'Panipat', N'Panipat', N'345267', N'female', CAST(N'1995-09-19T18:30:00.0000000' AS DateTime2), CAST(N'2020-03-31T18:30:00.0000000' AS DateTime2), 1, N'Admin', CAST(N'2022-06-11T19:56:40.4135982' AS DateTime2), N'Admin', CAST(N'2022-06-11T21:29:22.3968726' AS DateTime2), 5, 1)
GO
INSERT [dbo].[Staffs] ([Id], [StaffId], [FirstName], [MiddleName], [LastName], [MobileNo], [EmailId], [Address], [City], [ZipCode], [Gender], [DateOfBirth], [JoiningDate], [IsPermanent], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [DepartmentsId], [UserRoleId]) VALUES (6, N'S-00004', N'Payal', N'S', N'PAtil', N'1234567891', N'test@test.com', N'lonkheda', N'Shahada', N'425426', N'female', CAST(N'2000-06-11T15:44:15.9710000' AS DateTime2), CAST(N'2022-02-21T15:44:00.0000000' AS DateTime2), 1, N'Admin', CAST(N'2022-06-11T21:28:56.9038116' AS DateTime2), N'Admin', CAST(N'2022-06-11T21:28:56.9038495' AS DateTime2), 2, 1)
GO
INSERT [dbo].[Staffs] ([Id], [StaffId], [FirstName], [MiddleName], [LastName], [MobileNo], [EmailId], [Address], [City], [ZipCode], [Gender], [DateOfBirth], [JoiningDate], [IsPermanent], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [DepartmentsId], [UserRoleId]) VALUES (12, N'S-00007', N'Manju Devu', N'BrijBhushan', N'Pandey', N'1231231234', N'test_test@gmail.com', N'Phulera', N'Fakauli Bajar', N'123123', N'female', CAST(N'1973-09-07T13:28:00.0000000' AS DateTime2), CAST(N'2014-08-19T13:28:00.0000000' AS DateTime2), 1, N'Admin', CAST(N'2022-06-12T19:49:52.7193661' AS DateTime2), N'Admin', CAST(N'2022-06-12T19:49:52.7194341' AS DateTime2), 2, 4)
GO
SET IDENTITY_INSERT [dbo].[Staffs] OFF
GO
SET IDENTITY_INSERT [dbo].[PatientAppointments] ON 
GO
INSERT [dbo].[PatientAppointments] ([Id], [PatientId], [PatientName], [MobileNo], [EmailID], [DepartmentId], [AppointmentDate], [AppointmentTimeLSlot], [IsCompleted], [IsCancelled], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [StaffId]) VALUES (3, 2, N'Sagar Patil', N'1234567890', N'test@test', 1, CAST(N'2022-06-10T08:23:36.0490000' AS DateTime2), NULL, 0, 0, NULL, NULL, NULL, NULL, 3)
GO
INSERT [dbo].[PatientAppointments] ([Id], [PatientId], [PatientName], [MobileNo], [EmailID], [DepartmentId], [AppointmentDate], [AppointmentTimeLSlot], [IsCompleted], [IsCancelled], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [StaffId]) VALUES (4, 1, N'Sagar Patil', N'9421475805', N'test@test.com', 1002, CAST(N'2022-06-10T08:45:43.8930000' AS DateTime2), NULL, 0, 0, NULL, NULL, NULL, NULL, 4)
GO
INSERT [dbo].[PatientAppointments] ([Id], [PatientId], [PatientName], [MobileNo], [EmailID], [DepartmentId], [AppointmentDate], [AppointmentTimeLSlot], [IsCompleted], [IsCancelled], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [StaffId]) VALUES (10, 1, N'Sagar Patil', N'9421475805', N'asdasd', 2, CAST(N'2022-06-12T08:49:02.6800000' AS DateTime2), NULL, 0, 0, NULL, NULL, NULL, NULL, 6)
GO
SET IDENTITY_INSERT [dbo].[PatientAppointments] OFF
GO
SET IDENTITY_INSERT [dbo].[InPatientDirectory] ON 
GO
INSERT [dbo].[InPatientDirectory] ([Id], [PatientId], [PatientUHID], [RoomType], [BedNo], [IsInsured], [InsuranceCompany], [AdminssionDate], [DischargeDate], [DischargeSummary], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [StaffId], [IsDischarged], [DiagnosisDetails]) VALUES (1, 1, N'UHID00001', N'2', N'4th Floor - 407', 1, N'3', CAST(N'2022-06-12T00:33:01.3585301' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL, 3, 0, NULL)
GO
INSERT [dbo].[InPatientDirectory] ([Id], [PatientId], [PatientUHID], [RoomType], [BedNo], [IsInsured], [InsuranceCompany], [AdminssionDate], [DischargeDate], [DischargeSummary], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [StaffId], [IsDischarged], [DiagnosisDetails]) VALUES (2, 1, N'UHID00001', N'2', N'4th Floor - 407', 1, N'3', CAST(N'2022-06-12T00:35:58.9578442' AS DateTime2), CAST(N'2022-06-17T12:17:58.0700000' AS DateTime2), NULL, NULL, NULL, NULL, NULL, 3, 1, NULL)
GO
SET IDENTITY_INSERT [dbo].[InPatientDirectory] OFF
GO
SET IDENTITY_INSERT [dbo].[LoginDetails] ON 
GO
INSERT [dbo].[LoginDetails] ([Id], [UserName], [UserPassword], [StaffId]) VALUES (1, N'admin', N'admin', 2)
GO
INSERT [dbo].[LoginDetails] ([Id], [UserName], [UserPassword], [StaffId]) VALUES (2, N'sa', N'sa', 3)
GO
INSERT [dbo].[LoginDetails] ([Id], [UserName], [UserPassword], [StaffId]) VALUES (3, N'admin1', N'admin', 4)
GO
INSERT [dbo].[LoginDetails] ([Id], [UserName], [UserPassword], [StaffId]) VALUES (7, N'Manju Devu.Pandey', N'Manju Devu.Pandey@231', 12)
GO
SET IDENTITY_INSERT [dbo].[LoginDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[PatientPrescriptionHistories] ON 
GO
INSERT [dbo].[PatientPrescriptionHistories] ([Id], [PatientAppointmentId], [StaffId], [DrugType], [DrugName], [IsBeforeFood], [IsMorning], [IsAfternoon], [IsEvening], [PrescribedOn], [PatientId]) VALUES (1, 3, 3, N'tab', N'dolo 650', 0, 1, 0, 1, CAST(N'2022-06-12T01:36:49.4121836' AS DateTime2), 2)
GO
INSERT [dbo].[PatientPrescriptionHistories] ([Id], [PatientAppointmentId], [StaffId], [DrugType], [DrugName], [IsBeforeFood], [IsMorning], [IsAfternoon], [IsEvening], [PrescribedOn], [PatientId]) VALUES (2, 3, 3, N'tab', N'Pan D 40', 1, 1, 0, 1, CAST(N'2022-06-12T01:36:49.4142802' AS DateTime2), 2)
GO
SET IDENTITY_INSERT [dbo].[PatientPrescriptionHistories] OFF
GO
SET IDENTITY_INSERT [dbo].[IPDPatientTreatmentBreakup] ON 
GO
INSERT [dbo].[IPDPatientTreatmentBreakup] ([Id], [TreatmentName], [TreatmentType], [TreatmentDate], [Quantity], [TreatmentAmount], [CreatedBy], [InPatientDirectoryId]) VALUES (1, N'OT Charges', N'Surgery', CAST(N'2022-06-12T00:00:00.0000000' AS DateTime2), 1, 12000, NULL, 1)
GO
INSERT [dbo].[IPDPatientTreatmentBreakup] ([Id], [TreatmentName], [TreatmentType], [TreatmentDate], [Quantity], [TreatmentAmount], [CreatedBy], [InPatientDirectoryId]) VALUES (2, N'Anasthsia-Dr Rahil CHaudhari', N'anasthesia', CAST(N'2022-06-12T00:00:00.0000000' AS DateTime2), 1, 3000, NULL, 1)
GO
INSERT [dbo].[IPDPatientTreatmentBreakup] ([Id], [TreatmentName], [TreatmentType], [TreatmentDate], [Quantity], [TreatmentAmount], [CreatedBy], [InPatientDirectoryId]) VALUES (3, N'Consulataion - Dr Patel', N'Consulataion', CAST(N'2022-06-12T00:00:00.0000000' AS DateTime2), 1, 5000, NULL, 1)
GO
INSERT [dbo].[IPDPatientTreatmentBreakup] ([Id], [TreatmentName], [TreatmentType], [TreatmentDate], [Quantity], [TreatmentAmount], [CreatedBy], [InPatientDirectoryId]) VALUES (4, N'Injection 1', N'injection', CAST(N'2022-06-13T00:00:00.0000000' AS DateTime2), 1, 370, NULL, 1)
GO
INSERT [dbo].[IPDPatientTreatmentBreakup] ([Id], [TreatmentName], [TreatmentType], [TreatmentDate], [Quantity], [TreatmentAmount], [CreatedBy], [InPatientDirectoryId]) VALUES (5, N'Renodapt S360', N'Tablet', CAST(N'2022-06-13T00:00:00.0000000' AS DateTime2), 2, 830, NULL, 1)
GO
INSERT [dbo].[IPDPatientTreatmentBreakup] ([Id], [TreatmentName], [TreatmentType], [TreatmentDate], [Quantity], [TreatmentAmount], [CreatedBy], [InPatientDirectoryId]) VALUES (6, N'Blood Report CBC', N'Blood Test', CAST(N'2022-06-13T00:00:00.0000000' AS DateTime2), 1, 890, NULL, 1)
GO
SET IDENTITY_INSERT [dbo].[IPDPatientTreatmentBreakup] OFF
GO
