using System;
using System.Collections.Generic;

namespace InsuranceAgency.Business.Dtos
{
    public class QuotationDto
    {
        public int Id { get; set; }

        public string Plate { get; set; }

        public string TCId { get; set; }

        public string LicenseSerialCode { get; set; }

        public string LicenseSerialNo { get; set; }

        public DateTime CreatedAt { get; set; }

        public List<OfferDto> Offers { get; set; }
    }
}