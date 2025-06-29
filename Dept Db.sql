USE [CSDB]
GO

/****** Object:  Table [dbo].[Dept]    Script Date: 29-06-2025 03:32:37 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Dept](
	[DeptNo] [int] NOT NULL,
	[Dname] [varchar](50) NULL,
	[Location] [varchar](50) NULL,
 CONSTRAINT [Deptno_PK] PRIMARY KEY CLUSTERED 
(
	[DeptNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO Dept (DeptNo, Dname, Location) VALUES
(10, 'Marketing', 'Mumbai'),
(20, 'Sales', 'Chennai'),
(30, 'Finance', 'Delhi'),
(40, 'Production', 'Kolkota');
Go
