using System;
using System.Collections.Generic;
using System.Linq;
using InsuranceAgency.Data;
using InsuranceAgency.Data.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace InsuranceAgency.WebUI
{
    public class DataSeeding
    {
        public static void Seed(IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<AppDbContext>();

            context.Database.Migrate();

            if (!context.InsuranceProviders.Any())
            {
                context.InsuranceProviders.AddRange(
                    new List<InsuranceProvider>() {
                         new InsuranceProvider() { CompanyName = "Acıbadem Sigorta", Logo="https://cdnsnet.mncdn.com/facelift/assets/img/elements/companies-icon/acibadem-sigorta.png", IsActive = true },
                         new InsuranceProvider() { CompanyName = "AKSigorta", Logo = "https://cdnsnet.mncdn.com/facelift/assets/img/elements/companies-icon/ak-sigorta.png", IsActive = true },
                         new InsuranceProvider() { CompanyName = "Allianz", Logo = "https://cdnsnet.mncdn.com/facelift/assets/img/elements/companies-icon/allianz.png", IsActive = true },
                         new InsuranceProvider() { CompanyName = "Anadolu Sigorta", Logo = "https://cdnsnet.mncdn.com/facelift/assets/img/elements/companies-icon/anadolu-sigorta.png", IsActive = true },
                         new InsuranceProvider() { CompanyName = "Axa Sigorta", Logo = "https://cdnsnet.mncdn.com/facelift/assets/img/elements/companies-icon/axa-sigorta.png", IsActive = true },
                         new InsuranceProvider() { CompanyName = "Doğa Sigorta", Logo = "https://cdnsnet.mncdn.com/facelift/assets/img/elements/companies-icon/doga-sigorta.png", IsActive = true },
                         new InsuranceProvider() { CompanyName = "Eureko", Logo = "https://cdnsnet.mncdn.com/facelift/assets/img/elements/companies-icon/eureko.png", IsActive = true },
                         new InsuranceProvider() { CompanyName = "Groupama", Logo = "https://cdnsnet.mncdn.com/facelift/assets/img/elements/companies-icon/groupama.png", IsActive = true },
                         new InsuranceProvider() { CompanyName = "HDI Sigorta", Logo = "https://cdnsnet.mncdn.com/facelift/assets/img/elements/companies-icon/hdi-sigorta.png", IsActive = true },
                         new InsuranceProvider() { CompanyName = "Mapfre Sigorta", Logo = "https://cdnsnet.mncdn.com/facelift/assets/img/elements/companies-icon/mapfre-sigorta.png", IsActive = true },
                         new InsuranceProvider() { CompanyName = "Sompo Sigorta", Logo = "https://cdnsnet.mncdn.com/facelift/assets/img/elements/companies-icon/sompo-sigorta.png", IsActive = true }
                    });
            }

            if (!context.Quotations.Any())
            {
                context.Quotations.AddRange(
                    new List<Quotation>() {
                         new Quotation() { Plate = "45KB3330", TCId = "12345678901", LicenseSerialCode = "AZ", LicenseSerialNo = "976302", CreatedAt = DateTime.Now },
                         new Quotation() { Plate = "45KA7188", TCId = "12345678902", LicenseSerialCode = "SC", LicenseSerialNo = "059694", CreatedAt = DateTime.Now  },
                         new Quotation() { Plate = "45LN482", TCId = "12345678903", LicenseSerialCode = "FV", LicenseSerialNo = "315732", CreatedAt = DateTime.Now  },
                         new Quotation() { Plate = "45ZN9997", TCId = "12345678904", LicenseSerialCode = "GB", LicenseSerialNo = "975420", CreatedAt = DateTime.Now  }
                    });
            }

            if (!context.Offers.Any())
            {
                context.Offers.AddRange(
                    new List<Offer>() {
                         new Offer() { InsuranceProviderId = 1, QuotationId = 1, CompanyName = "Acıbadem Sigorta", Logo="https://cdnsnet.mncdn.com/facelift/assets/img/elements/companies-icon/acibadem-sigorta.png", Description = "45KB3330 için verdiğimiz tekliftir.", Amount = new Random().Next(5000, 7000), Plate = "45KB3330", CreatedAt = DateTime.Now  },
                         new Offer() { InsuranceProviderId = 2, QuotationId = 1, CompanyName = "AKSigorta", Logo = "https://cdnsnet.mncdn.com/facelift/assets/img/elements/companies-icon/ak-sigorta.png", Description = "45KB3330 için verdiğimiz tekliftir.", Amount = new Random().Next(5000, 7000), Plate = "45KB3330", CreatedAt = DateTime.Now  },
                         new Offer() { InsuranceProviderId = 3, QuotationId = 1, CompanyName = "Allianz", Logo = "https://cdnsnet.mncdn.com/facelift/assets/img/elements/companies-icon/allianz.png", Description = "45KB3330 için verdiğimiz tekliftir.", Amount = new Random().Next(5000, 7000), Plate = "45KB3330", CreatedAt = DateTime.Now  },
                         new Offer() { InsuranceProviderId = 4, QuotationId = 1, CompanyName = "Anadolu Sigorta", Logo = "https://cdnsnet.mncdn.com/facelift/assets/img/elements/companies-icon/anadolu-sigorta.png", Description = "45KB3330 için verdiğimiz tekliftir.", Amount = new Random().Next(5000, 7000), Plate = "45KB3330", CreatedAt = DateTime.Now  },
                         new Offer() { InsuranceProviderId = 4, QuotationId = 2, CompanyName = "Anadolu Sigorta", Logo = "https://cdnsnet.mncdn.com/facelift/assets/img/elements/companies-icon/anadolu-sigorta.png", Description = "45KA7188 için verdiğimiz tekliftir.", Amount = new Random().Next(5000, 7000), Plate = "45KA7188", CreatedAt = DateTime.Now  },
                         new Offer() { InsuranceProviderId = 5, QuotationId = 2, CompanyName = "Axa Sigorta", Logo = "https://cdnsnet.mncdn.com/facelift/assets/img/elements/companies-icon/axa-sigorta.png", Description = "45KA7188 için verdiğimiz tekliftir.", Amount = new Random().Next(5000, 7000), Plate = "45KA7188", CreatedAt = DateTime.Now  },
                         new Offer() { InsuranceProviderId = 6, QuotationId = 3, CompanyName = "Doğa Sigorta", Logo = "https://cdnsnet.mncdn.com/facelift/assets/img/elements/companies-icon/doga-sigorta.png", Description = "45LN482 için verdiğimiz tekliftir.", Amount = new Random().Next(5000, 7000), Plate = "45LN482", CreatedAt = DateTime.Now  },
                         new Offer() { InsuranceProviderId = 7, QuotationId = 3, CompanyName = "Eureko", Logo = "https://cdnsnet.mncdn.com/facelift/assets/img/elements/companies-icon/eureko.png", Description = "45LN482 için verdiğimiz tekliftir.", Amount = new Random().Next(5000, 7000), Plate = "45LN482", CreatedAt = DateTime.Now  },
                         new Offer() { InsuranceProviderId = 9, QuotationId = 4, CompanyName = "HDI Sigorta", Logo = "https://cdnsnet.mncdn.com/facelift/assets/img/elements/companies-icon/hdi-sigorta.png", Description = "45ZN9997 için verdiğimiz tekliftir.", Amount = new Random().Next(5000, 7000), Plate = "45ZN9997", CreatedAt = DateTime.Now  },
                         new Offer() { InsuranceProviderId = 10, QuotationId = 4, CompanyName = "Mapfre Sigorta", Logo = "https://cdnsnet.mncdn.com/facelift/assets/img/elements/companies-icon/mapfre-sigorta.png", Description = "45ZN9997 için verdiğimiz tekliftir.", Amount = new Random().Next(5000, 7000), Plate = "45ZN9997", CreatedAt = DateTime.Now  }
                    });
            }

            context.SaveChanges();

        }
    }
}