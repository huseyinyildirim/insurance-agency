using System.Collections.Generic;
using InsuranceAgency.Data.Entities;

namespace InsuranceAgency.Data.Repository
{
    public interface IInsuranceProviderRepository
    {
        IEnumerable<InsuranceProvider> GetAllInsuranceProviders();

        InsuranceProvider GetInsuranceProviderById(int insuranceProviderId);

        void CreateInsuranceProvider(InsuranceProvider insuranceProvider);

        void UpdateInsuranceProvider(InsuranceProvider insuranceProvider);

        void DeleteInsuranceProvider(InsuranceProvider insuranceProvider);
    }
}
