CREATE TABLE [dbo].[SalesDetails] (
    [ID]            INT   IDENTITY (1, 1) NOT NULL,
    [SalesHeaderID] INT   NOT NULL,
    [ProductID]     INT   NOT NULL,
    [Quantity]      INT   NOT NULL,
    [UnitPrice]     MONEY NOT NULL,
    CONSTRAINT [PK_SalesDetails] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_SalesDetails_Products] FOREIGN KEY ([ProductID]) REFERENCES [dbo].[Products] ([ID]),
    CONSTRAINT [FK_SalesDetails_SalesDetails] FOREIGN KEY ([SalesHeaderID]) REFERENCES [dbo].[SalesDetails] ([ID])
);

