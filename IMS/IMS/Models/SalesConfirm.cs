namespace IMS.Models
{

    public class SalesConfirm
    {
        public int id { get; set; }
        public int ProductId { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public decimal price { get; set; }
    }
}
