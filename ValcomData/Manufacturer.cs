using System;

namespace ValcomData
{
    public class Manufacturer
    {
        public int ID { get; set; }
        public int ManufacturerID { get; set; }
        public int ManufacturerName { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string Notes { get; set; }
    }
}
