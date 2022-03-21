using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace InsuranceAgency.Data.Entities
{
    public class Quotation : IEntity
    {
        public int Id { get; set; }

        public string Plate { get; set; }

        public string TCId { get; set; }

        public string LicenseSerialCode { get; set; }

        public string LicenseSerialNo { get; set; }

        public DateTime CreatedAt { get; set; }

        [NotMapped]
        public List<Offer> Offers { get; set; }
    }
}