using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace InsuranceAgency.Data.Entities
{
    public class Offer : IEntity
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

        [NotMapped]
        public InsuranceProvider InsuranceProvider { get; set; }

        [NotMapped]
        public Quotation Quotation { get; set; }
    }
}