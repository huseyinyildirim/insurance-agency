using System;

namespace InsuranceAgency.Business.Dtos
{
    public class OfferDto
    {
        public int Id { get; set; }

        public int InsuranceProviderId { get; set; }

        public int QuotationId { get; set; }

        public string CompanyName { get; set; }

        public string Logo { get; set; }

        public string Description { get; set; }

        public decimal Amount { get; set; }

        public string Plate { get; set; }

        public DateTime CreatedAt { get; set; }

        public InsuranceProviderDto InsuranceProvider { get; set; }

        public QuotationDto Quotation { get; set; }
    }
}