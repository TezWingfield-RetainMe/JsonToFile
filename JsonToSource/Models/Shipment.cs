namespace JsonToSource.Models
{
    public class Shipment
    {
        public string ShipmentId { get; set; }
        public string ShippingMethodId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsGift { get; set; }
        public string GiftMessage { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string ZipPostalCode { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string CountryCode { get; set; }
        public string ProvinceCode { get; set; }
        public string OutputId { get; set; }
    }
}
