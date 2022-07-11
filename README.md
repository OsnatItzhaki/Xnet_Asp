# Xnet_Asp
server side Xnet task

# Xnet_Asp
server side Xnet task

create new Database "tests",
create 2 tabels:customer and city:
and also Addclient store procedure

script for city:

USE [tests]
GO
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cities](
	[code] [int] IDENTITY(1,1) NOT NULL,
	[description] [varchar](200) NULL,
 CONSTRAINT [PK_Cities] PRIMARY KEY CLUSTERED 
(
	[code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

script for customer:

USE [tests]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Customers](
	[customerId] [int] IDENTITY(1,1) NOT NULL,
	[fullName] [varchar](200) NULL,
	[fullNameEng] [varchar](200) NULL,
	[dateBirth] [datetime] NULL,
	[identityCard] [varchar](50) NULL,
	[cityCode] [int] NULL,
	[bank] [int] NULL,
	[bankBranches] [int] NULL,
	[BankAccountNumber] [int] NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[customerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Customers]  WITH CHECK ADD FOREIGN KEY([cityCode])
REFERENCES [dbo].[Cities] ([code])
GO

ALTER TABLE [dbo].[Customers]  WITH CHECK ADD FOREIGN KEY([cityCode])
REFERENCES [dbo].[Cities] ([code])
GO

script for storeprocedure:
USE [tests]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AddClient_sp]
@fullName varchar(50),
@fullNameEng varchar(50),
@dateBirth date,
@identityCard varchar(9),
@cityCode int,
@bank int,
@bankBranches int,
@BankAccountNumber int
as
begin
	insert into [dbo].[Customers]([fullName], [fullNameEng], [dateBirth], [identityCard], [cityCode], [bank], [bankBranches], [BankAccountNumber])
	values(@fullName,@fullNameEng,@dateBirth,@identityCard,@cityCode,@bank,@bankBranches,@BankAccountNumber)
end






