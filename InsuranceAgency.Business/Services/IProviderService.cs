using InsuranceAgency.Business.Dtos;
using InsuranceAgency.Provider.Models;
using InsuranceAgency.Shared.Dtos;

namespace InsuranceAgency.Business.Services
{
    public interface IProviderService
    {
        Response<Offer> GetOffer(ProviderQueryDto providerQueryDto);
    }
}
