namespace SwiftInventory.Common
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal PricePerUnit { get; set; }
        public decimal Subtotal { get; set; }
        public string ProductImage { get; set; }
    }
}
