using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Domain.Model
{
    /// <summary>
    /// DatabaseGenerated attribute is used to make the Id auto increment
    /// </summary>
    public class Vendor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
        public string ServiceType { get; set; }

    }
}
