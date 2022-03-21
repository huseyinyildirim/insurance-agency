using System.ComponentModel.DataAnnotations;

namespace InsuranceAgency.WebUI.Models
{
    public class QuotationCreateInput
    {
        [Display(Name = "Plaka")]
        public string Plate { get; set; }

        [Display(Name = "TC No")]
        public string TCId { get; set; }

        [Display(Name = "Ruhsat Seri Kodu")]
        public string LicenseSerialCode { get; set; }

        [Display(Name = "Ruhsat Seri No")]
        public string LicenseSerialNo { get; set; }
    }
}
