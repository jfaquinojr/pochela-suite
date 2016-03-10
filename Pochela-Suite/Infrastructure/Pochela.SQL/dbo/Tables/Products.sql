CREATE TABLE [dbo].[Products] (
    [ID]            INT           IDENTITY (1, 1) NOT NULL,
    [Name]          VARCHAR (50)  NOT NULL,
    [Description]   VARCHAR (500) NULL,
    [ProductCode]   VARCHAR (30)  NOT NULL,
    [UnitOfMeasure] VARCHAR (20)  NULL,
    [UnitPrice]     MONEY         NOT NULL,
    [CreatedBy]     INT           NULL,
    [CreatedOn]     DATETIME      NULL,
    [ModifiedBy]    INT           NULL,
    [ModifiedOn]    DATETIME      NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [IX_Products_UQ_Name] UNIQUE NONCLUSTERED ([Name] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_Products_UQ_Code]
    ON [dbo].[Products]([ProductCode] ASC);

