namespace JsonToSource
{
    public static class Utilities
    {
        public static string RawJson()
        {
            return "{\"OrderNumber\":null,\"OrderCreatedAt\":\"2017-11-15T16:01:47.1773047+00:00\",\"TotalPrice\":99.99,\"SubTotalPrice\":0.0,\"TotalShippingPrice\":0.0,\"TotalTax\":0.0,\"TaxRate\":0.0,\"Currency\":null,\"TotalDiscounts\":0.0,\"TotalProductsPrice\":0.0,\"ShippingMethods\":[{\"ShippingMethodId\":\"8\",\"Name\":\"Test Shipping Method\"}],\"Shipment\":{\"ShipmentId\":\"9\",\"ShippingMethodId\":\"8\",\"FirstName\":null,\"LastName\":null,\"IsGift\":false,\"GiftMessage\":null,\"Address1\":null,\"Address2\":null,\"City\":null,\"Country\":null,\"Province\":null,\"ZipPostalCode\":null,\"Phone\":null,\"Mobile\":null,\"Latitude\":null,\"Longitude\":null,\"CountryCode\":null,\"ProvinceCode\":null,\"OutputId\":null},\"Customer\":{\"CustomerId\":null,\"CustomerStatus\":null,\"Email\":null,\"FirstName\":\"TEST\",\"LastName\":\"TEST\",\"Phone\":null,\"Mobile\":null,\"IsRepeatCustomer\":false},\"BillingAddress\":{\"FirstName\":null,\"LastName\":null,\"Address1\":\"TEST\",\"Address2\":null,\"City\":null,\"Country\":null,\"Province\":null,\"ZipPostalCode\":null,\"Phone\":null,\"Latitude\":null,\"Longitude\":null,\"CountryCode\":null,\"ProvinceCode\":null},\"Products\":[{\"ProductId\":null,\"Name\":\"TEST PRODUCT\",\"ImageUrl\":null,\"Quantity\":0,\"Price\":0.0,\"Tax\":0.0,\"ShipmentId\":null,\"Color\":null,\"Size\":null}]}";
        }
    }
}
