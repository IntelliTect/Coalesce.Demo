SET IDENTITY_INSERT [dbo].[Company] ON 

INSERT [dbo].[Company] ([CompanyId], [Address1], [Address2], [City], [Name], [State], [ZipCode], [IsDeleted]) VALUES (1, N'2561 Kensington Street ', N'', N'Wheeler', N'GGR Wool', N'Pennsylvania', N'27077', 0)

INSERT [dbo].[Company] ([CompanyId], [Address1], [Address2], [City], [Name], [State], [ZipCode], [IsDeleted]) VALUES (2, N'6459 Cypress Avenue ', N'', N'Hutchins', N'GGR Aircraft', N'Idaho', N'49789', 0)

INSERT [dbo].[Company] ([CompanyId], [Address1], [Address2], [City], [Name], [State], [ZipCode], [IsDeleted]) VALUES (3, N'9501 Brighton 7th Court ', NULL, N'Shenan', N'Ford Recycling', N'Mississipp', N'31916', 1)

INSERT [dbo].[Company] ([CompanyId], [Address1], [Address2], [City], [Name], [State], [ZipCode], [IsDeleted]) VALUES (4, N'7194 Amity Street ', N'', N'Burlingame', N'GGR Transport', N'Northern Mariana Islands', N'39863', 1)

INSERT [dbo].[Company] ([CompanyId], [Address1], [Address2], [City], [Name], [State], [ZipCode], [IsDeleted]) VALUES (5, N'6941 Imlay Street ', N'', N'Scotstown', N'Orion Military', N'Wisconsin', N'32269', 1)

INSERT [dbo].[Company] ([CompanyId], [Address1], [Address2], [City], [Name], [State], [ZipCode], [IsDeleted]) VALUES (6, N'6947 Brighton 4th Terrace ', N'', N'East Crockett', N'Hundai Wool', N'New York', N'13633', 1)

INSERT [dbo].[Company] ([CompanyId], [Address1], [Address2], [City], [Name], [State], [ZipCode], [IsDeleted]) VALUES (7, N'1296 Beach 37th Street ', N'', N'Mechanicville', N'GMC Recycling', N'Pennsylvania', N'87865', 1)

INSERT [dbo].[Company] ([CompanyId], [Address1], [Address2], [City], [Name], [State], [ZipCode], [IsDeleted]) VALUES (8, N'1871 50th Street ', N'Studio 210', N'Portland', N'Franks Shipping', N'Oren', N'858', 1)

INSERT [dbo].[Company] ([CompanyId], [Address1], [Address2], [City], [Name], [State], [ZipCode], [IsDeleted]) VALUES (9, N'3665 Gravesend Neck Road ', N'852F', N'Pentict', N'Ford Fishing', N'District of Columbia', N'1629', 1)

INSERT [dbo].[Company] ([CompanyId], [Address1], [Address2], [City], [Name], [State], [ZipCode], [IsDeleted]) VALUES (10, N'2336 Kingsborough 4th Walk ', N'', N'San Ramon', N'GGR Vehicle', N'Minnesota', N'86304', 1)

SET IDENTITY_INSERT [dbo].[Company] OFF

SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([PersonId], [CompanyId], [Email], [FirstName], [Gender], [LastName], [ProfilePic], [Title], [BirthDate], [LastBath], [NextUpgrade]) VALUES (11, 4, N'Laura.Tellies@hotmail.com', N'Seth', 1, N'Lopez', NULL, 2, CAST(N'1972-05-06T04:09:29.0000000' AS DateTime2), CAST(N'1924-10-19T20:04:19.0000000' AS DateTime2), NULL)

INSERT [dbo].[Person] ([PersonId], [CompanyId], [Email], [FirstName], [Gender], [LastName], [ProfilePic], [Title], [BirthDate], [LastBath], [NextUpgrade]) VALUES (12, 3, N'Joseph.Patterson@hotmail.com', N'Mary', 2, N'Watson', NULL, 2, CAST(N'1955-04-08T17:49:43.0000000' AS DateTime2), CAST(N'1947-05-20T19:51:40.0000000' AS DateTime2), NULL)

INSERT [dbo].[Person] ([PersonId], [CompanyId], [Email], [FirstName], [Gender], [LastName], [ProfilePic], [Title], [BirthDate], [LastBath], [NextUpgrade]) VALUES (13, 2, N'Christina.Carter@live.com', N'Angelina', 1, N'Richardson', NULL, 2, CAST(N'1996-03-11T15:06:10.0000000' AS DateTime2), CAST(N'1990-11-24T23:48:12.0000000' AS DateTime2), NULL)

INSERT [dbo].[Person] ([PersonId], [CompanyId], [Email], [FirstName], [Gender], [LastName], [ProfilePic], [Title], [BirthDate], [LastBath], [NextUpgrade]) VALUES (14, 1, N'test798790819@test.com', N'Carlos', 0, N'Mitchell', NULL, 2, CAST(N'1942-02-16T11:54:42.0000000' AS DateTime2), CAST(N'1973-07-25T13:08:45.0000000' AS DateTime2), NULL)

INSERT [dbo].[Person] ([PersonId], [CompanyId], [Email], [FirstName], [Gender], [LastName], [ProfilePic], [Title], [BirthDate], [LastBath], [NextUpgrade]) VALUES (15, 10, N'Kylie.Ramirez@telus.net', N'Amanda', 0, N'Wright', NULL, 2, CAST(N'1929-04-25T12:45:06.0000000' AS DateTime2), CAST(N'1955-07-16T07:41:41.0000000' AS DateTime2), NULL)

INSERT [dbo].[Person] ([PersonId], [CompanyId], [Email], [FirstName], [Gender], [LastName], [ProfilePic], [Title], [BirthDate], [LastBath], [NextUpgrade]) VALUES (16, 9, N'Thomas.King@gmail.com', N'Marvis', 1, N'Wright', NULL, 0, CAST(N'1972-04-16T23:33:16.0000000' AS DateTime2), CAST(N'1909-06-29T21:21:19.0000000' AS DateTime2), NULL)

INSERT [dbo].[Person] ([PersonId], [CompanyId], [Email], [FirstName], [Gender], [LastName], [ProfilePic], [Title], [BirthDate], [LastBath], [NextUpgrade]) VALUES (17, 8, N'test605146959@test.com', N'Victoria', 1, N'Stewart', NULL, 0, CAST(N'1908-04-19T20:03:26.0000000' AS DateTime2), CAST(N'2000-02-11T20:13:54.0000000' AS DateTime2), NULL)

INSERT [dbo].[Person] ([PersonId], [CompanyId], [Email], [FirstName], [Gender], [LastName], [ProfilePic], [Title], [BirthDate], [LastBath], [NextUpgrade]) VALUES (18, 7, N'Danielle.Baker@gmail.com', N'Kaylee', 1, N'nzales', NULL, 1, CAST(N'1956-02-21T14:39:47.0000000' AS DateTime2), CAST(N'1990-06-25T00:50:25.0000000' AS DateTime2), NULL)

INSERT [dbo].[Person] ([PersonId], [CompanyId], [Email], [FirstName], [Gender], [LastName], [ProfilePic], [Title], [BirthDate], [LastBath], [NextUpgrade]) VALUES (19, 6, N'Isabel.Wood@live.com', N'William', 1, N'Parker', NULL, 0, CAST(N'1922-05-23T00:42:28.0000000' AS DateTime2), CAST(N'1965-10-12T01:12:50.0000000' AS DateTime2), NULL)

INSERT [dbo].[Person] ([PersonId], [CompanyId], [Email], [FirstName], [Gender], [LastName], [ProfilePic], [Title], [BirthDate], [LastBath], [NextUpgrade]) VALUES (20, 5, N'Jasmine.Garcia@telus.net', N'Blake', 1, N'Thompson', NULL, 2, CAST(N'1989-10-04T05:07:04.0000000' AS DateTime2), CAST(N'1918-09-11T16:40:32.0000000' AS DateTime2), NULL)

INSERT [dbo].[Person] ([PersonId], [CompanyId], [Email], [FirstName], [Gender], [LastName], [ProfilePic], [Title], [BirthDate], [LastBath], [NextUpgrade]) VALUES (21, 4, N'test1969108878@test.com', N'Alex', 0, N'Hill', NULL, 2, CAST(N'1971-07-29T19:53:02.0000000' AS DateTime2), CAST(N'1917-03-18T19:57:56.0000000' AS DateTime2), NULL)

INSERT [dbo].[Person] ([PersonId], [CompanyId], [Email], [FirstName], [Gender], [LastName], [ProfilePic], [Title], [BirthDate], [LastBath], [NextUpgrade]) VALUES (22, 3, N'Jacqueline.Foster@shaw.ca', N'Melanie', 0, N'Perry', NULL, 2, CAST(N'1952-10-01T09:20:42.0000000' AS DateTime2), CAST(N'1903-07-22T20:22:42.0000000' AS DateTime2), NULL)

INSERT [dbo].[Person] ([PersonId], [CompanyId], [Email], [FirstName], [Gender], [LastName], [ProfilePic], [Title], [BirthDate], [LastBath], [NextUpgrade]) VALUES (23, 4, N'Gabrielle.Williams@att.com', N'Victoria', 0, N'Wright', NULL, 0, CAST(N'1969-08-07T13:53:14.0000000' AS DateTime2), CAST(N'1966-08-03T11:03:26.0000000' AS DateTime2), NULL)

INSERT [dbo].[Person] ([PersonId], [CompanyId], [Email], [FirstName], [Gender], [LastName], [ProfilePic], [Title], [BirthDate], [LastBath], [NextUpgrade]) VALUES (24, 2, N'Liberty.Timms@att.com', N'Austin', 0, N'Rivera', NULL, 0, CAST(N'1959-06-14T12:26:02.0000000' AS DateTime2), CAST(N'2011-08-14T23:50:36.0000000' AS DateTime2), NULL)

INSERT [dbo].[Person] ([PersonId], [CompanyId], [Email], [FirstName], [Gender], [LastName], [ProfilePic], [Title], [BirthDate], [LastBath], [NextUpgrade]) VALUES (25, 4, N'Patrick.Kelly@telus.net', N'Audrey', 0, N'Rivera', NULL, 1, CAST(N'1969-02-21T00:11:08.0000000' AS DateTime2), CAST(N'2019-04-11T14:36:25.0000000' AS DateTime2), NULL)

INSERT [dbo].[Person] ([PersonId], [CompanyId], [Email], [FirstName], [Gender], [LastName], [ProfilePic], [Title], [BirthDate], [LastBath], [NextUpgrade]) VALUES (26, 7, N'Alexa.Watson@rogers.ca', N'Hailey', 0, N'Nelson', NULL, 2, CAST(N'1908-06-16T04:20:48.0000000' AS DateTime2), CAST(N'2019-10-14T18:20:11.0000000' AS DateTime2), NULL)

INSERT [dbo].[Person] ([PersonId], [CompanyId], [Email], [FirstName], [Gender], [LastName], [ProfilePic], [Title], [BirthDate], [LastBath], [NextUpgrade]) VALUES (27, 8, N'Mark.Harris@telus.net', N'Jenna', 0, N'Wilson', NULL, 2, CAST(N'2018-07-13T21:45:48.0000000' AS DateTime2), CAST(N'1949-09-25T18:43:47.0000000' AS DateTime2), NULL)

INSERT [dbo].[Person] ([PersonId], [CompanyId], [Email], [FirstName], [Gender], [LastName], [ProfilePic], [Title], [BirthDate], [LastBath], [NextUpgrade]) VALUES (28, 7, N'Devin.nzalez@microsoft.com', N'Lakeshia', 0, N'Hernandez', NULL, 2, CAST(N'1988-11-10T01:28:51.0000000' AS DateTime2), CAST(N'1968-01-08T12:04:41.0000000' AS DateTime2), NULL)

INSERT [dbo].[Person] ([PersonId], [CompanyId], [Email], [FirstName], [Gender], [LastName], [ProfilePic], [Title], [BirthDate], [LastBath], [NextUpgrade]) VALUES (29, 6, N'Carlos.Brugger@rogers.ca', N'Lorenza', 1, N'Coleman', NULL, 2, CAST(N'1953-09-26T04:21:21.0000000' AS DateTime2), CAST(N'1974-09-23T17:56:30.0000000' AS DateTime2), NULL)

INSERT [dbo].[Person] ([PersonId], [CompanyId], [Email], [FirstName], [Gender], [LastName], [ProfilePic], [Title], [BirthDate], [LastBath], [NextUpgrade]) VALUES (30, 5, N'Sydney.Lewis@att.com', N'Alexander', 1, N'Robinson', NULL, 1, CAST(N'1927-10-24T13:45:33.0000000' AS DateTime2), CAST(N'1982-05-10T07:58:57.0000000' AS DateTime2), NULL)

SET IDENTITY_INSERT [dbo].[Person] OFF

SET IDENTITY_INSERT [dbo].[Case] ON 

INSERT [dbo].[Case] ([CaseKey], [AssignedToId], [Attachment], [Description], [OpenedAt], [ReportedById], [Severity], [Status], [Title], [DevTeamAssignedId], [Duration]) VALUES (7, 15, NULL, N'I t an error message. What''s your fax number so I can send you the Polaroid I took of it?', CAST(N'2020-12-15T16:55:06.0000000-08:00' AS DateTimeOffset), 28, N'Medium', 2, N'Powerpoint is broken', 4, CAST(N'00:00:00' AS Time))

INSERT [dbo].[Case] ([CaseKey], [AssignedToId], [Attachment], [Description], [OpenedAt], [ReportedById], [Severity], [Status], [Title], [DevTeamAssignedId], [Duration]) VALUES (9, 28, NULL, N'My chair isn''t comfortable enough', CAST(N'2021-05-29T19:51:47.0000000-07:00' AS DateTimeOffset), 11, N'Low', 1, N'Issue with Office', 4, CAST(N'00:00:00' AS Time))

INSERT [dbo].[Case] ([CaseKey], [AssignedToId], [Attachment], [Description], [OpenedAt], [ReportedById], [Severity], [Status], [Title], [DevTeamAssignedId], [Duration]) VALUES (10, 29, NULL, N'I was working last night and my cat jumped on my desk but then the doorbell rang and it was the mailman but the package was damaged so I didnt sign for it but we chatted for a while about the neighbor''s new dog and then I was hungry so I went and made this really od casserole that my mother used to make for dinner and then when I went back to my desk my cat was sleeping on the keyboard and I lost all my documents. Fix please?', CAST(N'2020-10-10T18:26:26.0000000-07:00' AS DateTimeOffset), 26, NULL, 3, N'HELP FIX WORD ASAP', 3, CAST(N'00:00:00' AS Time))

INSERT [dbo].[Case] ([CaseKey], [AssignedToId], [Attachment], [Description], [OpenedAt], [ReportedById], [Severity], [Status], [Title], [DevTeamAssignedId], [Duration]) VALUES (11, 30, NULL, N'It just worked yesterday why did you guys break it?', CAST(N'2019-12-09T08:02:45.0000000-08:00' AS DateTimeOffset), 27, N'Low', 2, N'Problem with Office', 2, CAST(N'00:00:00' AS Time))

INSERT [dbo].[Case] ([CaseKey], [AssignedToId], [Attachment], [Description], [OpenedAt], [ReportedById], [Severity], [Status], [Title], [DevTeamAssignedId], [Duration]) VALUES (12, 26, NULL, N'Whenever I walk into the office I am bombarded with a strong smell of fish, ew', CAST(N'2021-01-22T09:27:25.0000000-08:00' AS DateTimeOffset), 22, N'Critical', 3, N'HELP FIX OFFICE ASAP', 1, CAST(N'00:00:00' AS Time))

INSERT [dbo].[Case] ([CaseKey], [AssignedToId], [Attachment], [Description], [OpenedAt], [ReportedById], [Severity], [Status], [Title], [DevTeamAssignedId], [Duration]) VALUES (13, 13, NULL, N'Excel doesn''t automatically fill out itself, could be better', CAST(N'2021-05-24T22:26:50.0000000-07:00' AS DateTimeOffset), 29, N'Medium', 0, N'Excel doesn''t work', 4, CAST(N'00:00:00' AS Time))

INSERT [dbo].[Case] ([CaseKey], [AssignedToId], [Attachment], [Description], [OpenedAt], [ReportedById], [Severity], [Status], [Title], [DevTeamAssignedId], [Duration]) VALUES (14, 23, NULL, N'I t an error message. What''s your fax number so I can send you the Polaroid I took of it?', CAST(N'2020-01-02T18:07:28.0000000-08:00' AS DateTimeOffset), 27, N'Medium', 3, N'Problem with Excel', 3, CAST(N'00:00:00' AS Time))

INSERT [dbo].[Case] ([CaseKey], [AssignedToId], [Attachment], [Description], [OpenedAt], [ReportedById], [Severity], [Status], [Title], [DevTeamAssignedId], [Duration]) VALUES (15, 29, NULL, N'The editor isn''t just writing the code for me, my hands are getting sore', CAST(N'2020-10-30T03:06:56.0000000-07:00' AS DateTimeOffset), 13, N'High', 1, N'Problem with Visual Studio 2013', 2, CAST(N'00:00:00' AS Time))

INSERT [dbo].[Case] ([CaseKey], [AssignedToId], [Attachment], [Description], [OpenedAt], [ReportedById], [Severity], [Status], [Title], [DevTeamAssignedId], [Duration]) VALUES (16, 12, NULL, N'Doesn''t work anymore', CAST(N'2019-12-29T14:47:00.0000000-08:00' AS DateTimeOffset), 25, N'Critical', 4, N'Office is broken', 1, CAST(N'00:00:00' AS Time))

INSERT [dbo].[Case] ([CaseKey], [AssignedToId], [Attachment], [Description], [OpenedAt], [ReportedById], [Severity], [Status], [Title], [DevTeamAssignedId], [Duration]) VALUES (17, 29, NULL, N'The default theme is the light theme, makes my eyes bleed. Please fix', CAST(N'2020-03-11T19:47:55.0000000-07:00' AS DateTimeOffset), 14, N'Medium', 4, N'Issue with Visual Studio 2015', 4, CAST(N'00:00:00' AS Time))

INSERT [dbo].[Case] ([CaseKey], [AssignedToId], [Attachment], [Description], [OpenedAt], [ReportedById], [Severity], [Status], [Title], [DevTeamAssignedId], [Duration]) VALUES (21, 28, NULL, N'Problem with esignature tabs', CAST(N'2020-03-13T18:26:55.0000000-07:00' AS DateTimeOffset), 22, N'High', 1, N'eSignature', NULL, CAST(N'00:00:00' AS Time))

SET IDENTITY_INSERT [dbo].[Case] OFF

SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ProductId], [Name], [Details_CompanyHqAddress_Address], [Details_CompanyHqAddress_City], [Details_CompanyHqAddress_PostalCode], [Details_CompanyHqAddress_State], [Details_ManufacturingAddress_Address], [Details_ManufacturingAddress_City], [Details_ManufacturingAddress_PostalCode], [Details_ManufacturingAddress_State], [ProductUniqueId]) VALUES (6, N'Visual Studio 2015', N'2850 Morton Street ', N'Roanoke', N'I5D 1N3', N'Wyoming', N'7818 Sherlock Place ', N'Crosby', N'L2W 8X3', N'Nebraska', N'5fc568fa-a230-493e-b00b-35f5e14d1f6e')

SET IDENTITY_INSERT [dbo].[Product] OFF

SET IDENTITY_INSERT [dbo].[CaseProduct] ON 

INSERT [dbo].[CaseProduct] ([CaseProductId], [CaseId], [ProductId]) VALUES (26, 17, 6)

INSERT [dbo].[CaseProduct] ([CaseProductId], [CaseId], [ProductId]) VALUES (34, 11, 6)
