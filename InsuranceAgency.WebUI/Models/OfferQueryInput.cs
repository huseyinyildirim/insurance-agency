using System.ComponentModel.DataAnnotations;

namespace InsuranceAgency.WebUI.Models
{
    public class OfferQueryInput
    {
        [Display(Name = "TC No")]
        public string TCId { get; set; }
    }
}
