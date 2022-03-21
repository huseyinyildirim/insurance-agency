using System.Collections.Generic;

namespace InsuranceAgency.Business.Dtos
{
    public class InsuranceProviderDto
    {
        public int Id { get; set; }

        public string CompanyName { get; set; }

        public string Logo { get; set; }

        public bool IsActive { get; set; }

        public List<OfferDto> Offers { get; set; }
    }
}