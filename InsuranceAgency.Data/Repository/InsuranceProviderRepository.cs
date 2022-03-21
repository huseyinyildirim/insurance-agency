using System.Collections.Generic;
using System.Linq;
using InsuranceAgency.Data.Entities;

namespace InsuranceAgency.Data.Repository
{
    public class InsuranceProviderRepository : BaseRepository<InsuranceProvider>, IInsuranceProviderRepository
    {
        public InsuranceProviderRepository(AppDbContext context) : base(context)
        {

        }

        public void CreateInsuranceProvider(InsuranceProvider insuranceProvider)
        {
            Create(insuranceProvider);
        }

        public void DeleteInsuranceProvider(InsuranceProvider insuranceProvider)
        {
            Delete(insuranceProvider);
        }

        public IEnumerable<InsuranceProvider> GetAllInsuranceProviders()
        {
            return FindAll();
        }

        public InsuranceProvider GetInsuranceProviderById(int insuranceProviderId)
        {
            return FindByCondition(x => x.Id == insuranceProviderId).FirstOrDefault();
        }

        public void UpdateInsuranceProvider(InsuranceProvider insuranceProvider)
        {
            Update(insuranceProvider);
        }
    }
}
