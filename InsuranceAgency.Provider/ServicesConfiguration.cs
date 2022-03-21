using InsuranceAgency.Provider.Providers;
using Microsoft.Extensions.DependencyInjection;

namespace InsuranceAgency.Provider
{
    public static class ServicesConfiguration
	{
		public static void AddProviderServices(this IServiceCollection services)
		{
			//services.AddScoped<IProvider, AcibademSigortaProvider>();
		}
	}
}
