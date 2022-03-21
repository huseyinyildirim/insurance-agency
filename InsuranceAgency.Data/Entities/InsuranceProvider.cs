using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace InsuranceAgency.Data.Entities
{
    public class InsuranceProvider : IEntity
    {
        public int Id { get; set; }

        public string CompanyName { get; set; }

        public string Logo { get; set; }

        public bool IsActive { get; set; }

        [NotMapped]
        public List<Offer> Offers { get; set; }
    }
}