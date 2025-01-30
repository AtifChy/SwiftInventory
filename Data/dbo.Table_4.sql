CREATE TABLE [dbo].[StockTransaction] (
    [TransactionID]   INT             IDENTITY (1, 1) NOT NULL,
    [ProductID]       INT             NOT NULL,
    [TransactionType] VARCHAR (50)    NOT NULL,
    [Quantity]        INT             NOT NULL,
    [TransactionDate] DATETIME        NOT NULL,
    [ReferenceID]     INT             NOT NULL,
    PRIMARY KEY CLUSTERED ([TransactionID] ASC),
    CONSTRAINT [FK_StockTransaction_Product] FOREIGN KEY ([ProductID]) REFERENCES [dbo].[Product] ([ProductID]) ON DELETE CASCADE ON UPDATE CASCADE,
    CHECK ([TransactionType]='Purchase' OR [TransactionType]='Sale' OR [TransactionType]='Adjustment')
);