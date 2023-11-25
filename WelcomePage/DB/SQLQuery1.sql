CREATE TABLE [dbo].[Categories]
( 
	[UserID]      INT           NOT NULL,
    [Spending] NCHAR(10) NULL, 
    [Savings] NCHAR(10) NULL, 
    [Bills] NCHAR(10) NULL, 
    [Subscriptions] NCHAR(10) NULL, 
    [Other] NCHAR(10) NULL
	PRIMARY KEY CLUSTERED ([UserID] ASC)
);
