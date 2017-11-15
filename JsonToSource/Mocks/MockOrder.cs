using JsonToSource.Models;
using System;
using System.Collections.Generic;

namespace JsonToSource.Mocks
{
    public static class MockOrder
    {
        public static Order ToMock()
        {
            return new Order
            {
                OrderCreatedAt = DateTime.Now,
                TotalPrice = 99.99M,
                ShippingMethods = new List<ShippingMethod>
                {
                    new ShippingMethod
                    {
                        ShippingMethodId = "8",
                        Name = "Test Shipping Method"
                    }
                },
                Shipment = new Shipment
                {
                    ShipmentId = "9",
                    ShippingMethodId = "8",

                },
                Customer = new Customer
                {
                    FirstName = "TEST",
                    LastName = "TEST"
                },
                BillingAddress = new BillingAddress
                {
                    Address1 = "TEST"
                },
                Products = new List<Product>
                {
                    new Product
                    {
                        Name = "TEST PRODUCT"
                    }
                }
            };
        }
    }
}
