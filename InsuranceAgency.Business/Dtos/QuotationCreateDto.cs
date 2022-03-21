using System;

namespace InsuranceAgency.Business.Dtos
{
    public class QuotationCreateDto
    {
        public string Plate { get; set; }

        public string TCId { get; set; }

        public string LicenseSerialCode { get; set; }

        public string LicenseSerialNo { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}