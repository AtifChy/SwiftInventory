CREATE TABLE [dbo].[PurchaseOrderDetails] (
    [PODID]         INT             IDENTITY (1, 1) NOT NULL,
    [POID]          INT             NOT NULL,
    [ProductID]     INT             NOT NULL,
    [Quantity]      INT             NOT NULL,
    [CostPerUnit]   DECIMAL (18, 2) NOT NULL,
    [Subtotal]      DECIMAL (18, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([PODID] ASC),
    CONSTRAINT [FK_PurchaseOrderDetails_PurchaseOrder] FOREIGN KEY ([POID]) REFERENCES [dbo].[PurchaseOrder] ([POID]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_PurchaseOrderDetails_Product] FOREIGN KEY ([ProductID]) REFERENCES [dbo].[Product] ([ProductID]) ON DELETE CASCADE ON UPDATE CASCADE
);