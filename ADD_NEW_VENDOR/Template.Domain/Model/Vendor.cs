using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Domain.Model
{
     public class Vendor
    {
        public int Id { get; set; }
        public string VendorName { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Market { get; set; }
        public string Email { get; set; }
        public string PhoneCode { get; set; }
        public string Website { get; set; }
        public string ContractType { get; set; }
        public string VendorConfidence { get; set; }
        public string Phone { get; set; }
    }
}
