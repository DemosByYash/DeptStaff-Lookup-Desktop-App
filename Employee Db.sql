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

