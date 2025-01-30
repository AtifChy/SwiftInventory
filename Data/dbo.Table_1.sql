CREATE TABLE [dbo].[OrderDetails] (
    [OrderDetailsID] INT             IDENTITY (1, 1) NOT NULL,
    [OrderID]        INT             NOT NULL,
    [ProductID]      INT             NOT NULL,
    [Quantity]       INT             NOT NULL,
    [Subtotal]       DECIMAL (18, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([OrderDetailsID] ASC),
    CONSTRAINT [FK_OrderDetails_Order] FOREIGN KEY ([OrderID]) REFERENCES [dbo].[Order] ([OrderID]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_OrderDetails_Product] FOREIGN KEY ([ProductID]) REFERENCES [dbo].[Product] ([ProductID]) ON DELETE CASCADE ON UPDATE CASCADE
);