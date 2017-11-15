using System;
using System.Collections.Generic;

namespace JsonToSource.Models
{
    public class Order
    {
        public string OrderNumber { get; set; }
        public DateTime OrderCreatedAt { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal SubTotalPrice { get; set; }
        public decimal TotalShippingPrice { get; set; }
        public decimal TotalTax { get; set; }
        public decimal TaxRate { get; set; }
        public string Currency { get; set; }
        public decimal TotalDiscounts { get; set; }
        public decimal TotalProductsPrice { get; set; }
        public List<ShippingMethod> ShippingMethods { get; set; }
        public Shipment Shipment { get; set; }
        public Customer Customer { get; set; }
        public BillingAddress BillingAddress { get; set; }
        public List<Product> Products { get; set; }
    }
}
