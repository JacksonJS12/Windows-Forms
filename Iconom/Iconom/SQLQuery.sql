﻿CREATE TABLE [dbo].[Inhabitant](
	[Id] INT PRIMARY KEY IDENTITY,
	[FullName] NVARCHAR(100) NOT NULL ,
	[AppartementNumber] INT NOT NULL,
	[Status] NVARCHAR(30) NOT NULL,
	[BirthYear] INT NOT NULL,
	[EnterDate] DATE NOT NULL,
	[LeavingDate] DATE NOT NULL,
	[PhoneNumber] NVARCHAR(12) UNIQUE NOT NULL
);


INSERT INTO [dbo].[Inhabitant]([FullName], [AppartementNumber], [Status], [BirthYear], [EnterDate], [LeavingDate], [PhoneNumber])
VALUES (N'Иван Иванов Иванов', 12, N'наемател', 1980, '2000-02-02','2005-02-02', '089-995-4442'),
		(N'Христо Стоичков Стоичков', 20, N'собственик', 1966 , '1989-12-05', '2009-12-05', '089-345-5551'),
		(N'Димитър Иванов Бербатов', 101, N'собственик', 1981 , '2012-08-25', '2015-08-25', '088-342-5678');

SELECT * 
FROM [dbo].[Inhabitant]

DROP TABLE [Inhabitant]