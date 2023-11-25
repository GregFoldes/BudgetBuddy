CREATE TABLE [dbo].[PersonalFinance] (
    [UserID]		INT				NOT NULL,
	[TransactionID] INT             NOT NULL,
    [Category]      VARCHAR (50)    NOT NULL,
    [Description]   VARCHAR (255)   NULL,
    [Amount]        DECIMAL (10, 2) NOT NULL,
    [Date]          DATE            NOT NULL,
    [Notes]         TEXT            NULL,
    PRIMARY KEY CLUSTERED ([TransactionID] ASC),
    CONSTRAINT [chk_amount_non_negative] CHECK ([Amount]>=(0))
);

