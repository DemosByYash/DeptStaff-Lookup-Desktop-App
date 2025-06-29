USE [CSDB]
GO

/****** Object:  Table [dbo].[Employee]    Script Date: 29-06-2025 03:30:47 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employee](
	[Eno] [int] NOT NULL,
	[Ename] [varchar](50) NULL,
	[Job] [varchar](50) NULL,
	[Salary] [money] NULL,
	[Photo] [varbinary](max) NULL,
	[Status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Eno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Employee] ADD  DEFAULT ((1)) FOR [Status]
GO

INSERT INTO Employee (Eno, Ename, Job, Salary, Photo, Status) VALUES
(1001, 'Alice Lee', 'Manager', 75000.00, NULL, 1),
(1002, 'Bob', 'Developer', 60000.00, NULL, 1),
(1003, 'Charlie', 'Designer', 55000.00, NULL, 1),
(1004, 'David', 'Tester', 50000.00, NULL, 0),
(1005, 'Eve', 'HR', 58000.00, NULL, 1),
(1006, 'Yash Gupta', 'Web Systems Developer', 100000.00, NULL, 1),
(1007, 'Om Kashyap', 'Content Editor', 55000.00, NULL, 1),
(1008, 'Radhe Smith', 'Driver', 18500.00, NULL, 0),
(1009, 'Wayne', 'Security', 17000.00, NULL, 1),
(1010, 'CF Das', 'Marketing Strategist', 65000.00, NULL, 0);

Go
