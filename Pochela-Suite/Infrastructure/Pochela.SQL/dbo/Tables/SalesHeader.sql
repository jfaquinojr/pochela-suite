CREATE TABLE [dbo].[SalesHeader] (
    [ID]          INT      IDENTITY (1, 1) NOT NULL,
    [TotalAmount] MONEY    NOT NULL,
    [CreatedBy]   INT      NULL,
    [CreatedOn]   DATETIME NOT NULL,
    [ModifiedBy]  INT      NULL,
    [ModifiedOn]  DATETIME NULL,
    CONSTRAINT [PK_SalesHeader] PRIMARY KEY CLUSTERED ([ID] ASC)
);

