using System.Collections.Generic;
using AutoMapper;
using InsuranceAgency.Business.Dtos;
using InsuranceAgency.Data.Repository;
using InsuranceAgency.Shared;
using InsuranceAgency.Shared.Dtos;

namespace InsuranceAgency.Business.Services
{
    public class InsuranceProviderService : IInsuranceProviderService
    {
        private readonly IInsuranceProviderRepository _insuranceProviderRepository;
        private readonly IMapper _mapper;

        public InsuranceProviderService(IMapper mapper, IInsuranceProviderRepository insuranceProviderRepository)
        {
            _mapper = mapper;
            _insuranceProviderRepository = insuranceProviderRepository;
        }

        public InsuranceProviderService()
        {
        }

        public Response<List<InsuranceProviderDto>> GetAll()
        {
            var insuranceProvidersResult = _insuranceProviderRepository.GetAllInsuranceProviders();

            return Response<List<InsuranceProviderDto>>.Success(_mapper.Map<List<InsuranceProviderDto>>(insuranceProvidersResult), HttpStatusCode.OK);
        }
    }
}
