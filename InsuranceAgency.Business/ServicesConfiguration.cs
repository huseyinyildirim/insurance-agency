using InsuranceAgency.Business.Services;
using Microsoft.Extensions.DependencyInjection;

namespace InsuranceAgency.Business
{
    public static class ServicesConfiguration
	{
		public static void AddBusinessServices(this IServiceCollection services)
		{
			services.AddScoped<IQuotationService, QuotationService>();
			services.AddScoped<IInsuranceProviderService, InsuranceProviderService>();
			services.AddScoped<IOfferService, OfferService>();
		}
	}
}
