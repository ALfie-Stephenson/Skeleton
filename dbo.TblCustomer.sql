CREATE TABLE [dbo].[TblCustomer] (
    [CustomerNo]           INT           IDENTITY (1, 1)  NOT NULL,
    [CustomerName]         VARCHAR (50)  NULL,
    [CustomerAddress]      VARCHAR (100) NULL,
    [CustomerCardNo]       BIGINT        NULL,
    [CustomerExpiryDate]   DATE          NULL,
    [CustomerCVC]          INT           NULL,
    [CustomerJoinDate]     DATE          NULL,
    [AccountActivity]      BIT           NULL,
    [CustomerEmailAddress] VARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([CustomerNo] ASC)
);

