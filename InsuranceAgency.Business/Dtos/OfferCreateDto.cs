namespace InsuranceAgency.Business.Dtos
{
    public class OfferCreateDto
    {
        public int InsuranceProviderId { get; set; }

        public int QuotationId { get; set; }

        public string CompanyName { get; set; }

        public string Logo { get; set; }

        public string Description { get; set; }

        public decimal Amount { get; set; }

        public string Plate { get; set; }
    }
}