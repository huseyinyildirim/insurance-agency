using System.Collections.Generic;
using InsuranceAgency.Business.Dtos;
using InsuranceAgency.Shared.Dtos;

namespace InsuranceAgency.Business.Services
{
    public interface IOfferService
    {
        Response<List<OfferDto>> GetAllByTCId(string tcId);

        Response<OfferDto> Create(OfferCreateDto offerCreateDto);
    }
}
