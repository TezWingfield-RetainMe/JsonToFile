namespace JsonToSource.Models
{
    public class Product
    {
        public string ProductId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Tax { get; set; }
        public string ShipmentId { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
    }
}
