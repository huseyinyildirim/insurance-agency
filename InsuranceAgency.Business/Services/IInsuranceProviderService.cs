using System.Collections.Generic;
using InsuranceAgency.Business.Dtos;
using InsuranceAgency.Shared.Dtos;

namespace InsuranceAgency.Business.Services
{
    public interface IInsuranceProviderService
    {
        Response<List<InsuranceProviderDto>> GetAll();
    }
}
