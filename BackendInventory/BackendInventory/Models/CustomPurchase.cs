namespace BackendInventory.Models
{
    public class CustomPurchase
    {

        public int ProductId { get; set; }
        public int SupplierId { get; set; }
        public float PricePerUnit { get; set; }
        public int Quantity { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public float TotalAmount { get; set; }
        public float RetailPrice { get; set; }
        public float Discount { get; set; }

    }
}
