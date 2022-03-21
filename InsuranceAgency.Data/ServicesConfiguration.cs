using InsuranceAgency.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace InsuranceAgency.Business
{
    public static class ServicesConfiguration
	{
		public static void AddDataServices(this IServiceCollection services)
		{
			services.AddScoped<IInsuranceProviderRepository, InsuranceProviderRepository>();
			services.AddScoped<IOfferRepository, OfferRepository>();
			services.AddScoped<IQuotationRepository, QuotationRepository>();
		}
	}
}
