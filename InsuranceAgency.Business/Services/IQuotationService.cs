using System.Collections.Generic;
using InsuranceAgency.Business.Dtos;
using InsuranceAgency.Shared.Dtos;

namespace InsuranceAgency.Business.Services
{
    public interface IQuotationService
    {
        Response<List<QuotationDto>> GetAll();

        Response<QuotationDto> GetById(int id);

        Response<QuotationDto> GetByPlateTCId(string plate, string tcId);

        Response<QuotationDto> Create(QuotationCreateDto quotationCreateDto);
    }
}
